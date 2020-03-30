using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ROTATEGUN : MonoBehaviour
{
    public grapplinggun grappling;
    private void Update()
    {
        if (grappling.IsGrappling()) return;
        transform.LookAt(grappling.getgrapplepoint());
    }
}
