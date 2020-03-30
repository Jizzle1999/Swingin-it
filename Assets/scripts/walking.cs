using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walking : MonoBehaviour
{
    // Start is called before the first frame update
    public int humpheight;
    public int jumpheight;
    Vector3 jumpVelocity;
    public Rigidbody rigidbody;
    void Start()
    {
        Debug.Log("wow code");
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "klimbaar")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("heeej");
            transform.position += Vector3.up * Time.deltaTime * humpheight;
        }

        if (collision.gameObject.tag == "springbaar")
        {
           

            jumpVelocity.x = rigidbody.velocity.x; // Preserve the x and z axis of the velocity
            jumpVelocity.z = rigidbody.velocity.z;
            jumpVelocity.y = jumpheight;  // The jump force

            rigidbody.velocity = jumpVelocity;
        }
    }
}
