using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class die : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "FirstPerson - AIO") ;
        {
            Debug.Log("maaknieuit");
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        } 
    }
}
