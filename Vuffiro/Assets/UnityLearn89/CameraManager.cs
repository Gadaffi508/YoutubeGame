using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Camera first;
    public Camera Main;
    public Camera topCam;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Main.enabled = false;
            topCam.enabled = false;
            first.enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            first.enabled = false;
            topCam.enabled = false;
            Main.enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            first.enabled = false;
            Main.enabled = false;
            topCam.enabled = true;
        }
    }

}
