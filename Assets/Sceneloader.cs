﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Sceneloader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void buttonclick()
    {
        SceneManager.LoadScene("BPW v3", LoadSceneMode.Single);
    }
    public void buttonclick2()
    {
        SceneManager.LoadScene("menu", LoadSceneMode.Single);
    }
    public void endgame() { Application.Quit(); }
}
