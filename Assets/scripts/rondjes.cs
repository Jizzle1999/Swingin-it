using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rondjes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // gameObject.transform.rotation;
       // gameObject.transform.position = new Vector3(0.75f, 0.0f, 0.0f);
        gameObject.transform.Rotate(0.0f, 1.0f, 0.0f, Space.Self);
    }
}
