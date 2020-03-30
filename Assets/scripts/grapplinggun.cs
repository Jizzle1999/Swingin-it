using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grapplinggun : MonoBehaviour
{
    private LineRenderer lr;
    private Vector3 grapplepoint;
    public LayerMask whatisgrappleable;
    public Transform guntip, camera, player;
    private float maxDistance = 100f;
    public SpringJoint joint;
    Vector3 nulpunt;
    public FirstPersonAIO FirstPersonController;
    Vector2 inputXY;
    bool grappling = false;
    public Rigidbody PlayerRigidBody;
    public float ForceMultiplier = 1.0f;


    void Awake()
    {
        lr = GetComponent<LineRenderer>();
        nulpunt.x = 0;
        nulpunt.y = 0;
        nulpunt.z =0;
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            StartGrapple();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            StopGrapple();
        }
    }

    void LateUpdate()
    {
        DrawRope();
        ControlAdditionalPlayerForce();

    }

    void ControlAdditionalPlayerForce()
    {
        //get input on each axis 
        //add force on that axis, make sure to limit it?
        float horizontalInput = Input.GetAxis("Horizontal");
        // float verticalInput = Input.GetAxis("Vertical");
        //inputXY = new Vector2(horizontalInput, verticalInput);


        //if (inputXY.magnitude > 1) { inputXY.Normalize(); }

        if (grappling)
            PlayerRigidBody.AddForce(Vector3.forward * horizontalInput * ForceMultiplier);
    }

    void StartGrapple()
    {
        RaycastHit hit;
        if (Physics.Raycast(origin: camera.position, direction: camera.forward, out hit, maxDistance, whatisgrappleable));
        if (hit.point == nulpunt) { return; }
              grapplepoint = hit.point;
        joint = player.gameObject.AddComponent<SpringJoint>();
        joint.autoConfigureConnectedAnchor = false;
        joint.connectedAnchor = grapplepoint;

        float distanceFromPoint = Vector3.Distance(a: player.position, b: grapplepoint);
        Debug.Log(distanceFromPoint);
        joint.maxDistance = distanceFromPoint * 1f;
        joint.minDistance = distanceFromPoint * 0.25f;


        joint.spring = 8;
        joint.damper = 7f;
        joint.massScale = 4.5f;

        lr.positionCount = 2;

        FirstPersonController.playerCanInputMove= false;
        grappling = true;
        //FirstPersonController.enabled = false;
    }

 
    void StopGrapple()
    {
        lr.positionCount = 0;
        Destroy(joint);
        FirstPersonController.playerCanInputMove = true;
        grappling = false;
        //FirstPersonController.enabled = true;
    }
    void DrawRope()
    {
        if (!joint) return;

        lr.SetPosition(index: 0, guntip.position);
        lr.SetPosition(index: 1, grapplepoint);
    }

    public bool IsGrappling()
    {
        return joint != null;
    }

    public Vector3 getgrapplepoint()
    {
        return grapplepoint;
    }
}
