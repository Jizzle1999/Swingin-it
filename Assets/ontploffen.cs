using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ontploffen : MonoBehaviour
{
    public int waarde;
     void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("heeeej"+ collision);
        if (collision.gameObject.name == "FirstPerson - AIO") ;
        {
            Debug.Log("swoosh");
            collision.gameObject.GetComponent<Rigidbody>().AddForce(0,0, waarde);
        }
    }
}
