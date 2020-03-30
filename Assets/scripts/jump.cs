using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public Rigidbody lichaam;
    public int jumpheight;
    bool magspringen= true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && magspringen == true)
        {
          lichaam.AddForce(Vector3.up * jumpheight);
            magspringen = false;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "vloer" )
        {
magspringen = true;
        }

        if (collision.gameObject.tag == "springbaar")
        {
            magspringen = true;
        }

    }
    }


