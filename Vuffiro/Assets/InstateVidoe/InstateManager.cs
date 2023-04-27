using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstateManager : MonoBehaviour
{
    public GameObject ObjeIns;
    public Camera cam;
    // Update is called once per frame
    void Update()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitpoint;
        if (Physics.Raycast(ray,out hitpoint))
        {
            ObjeIns.transform.position = new Vector3(hitpoint.point.x,hitpoint.point.y,0);
        }
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(ObjeIns,hitpoint.point,Quaternion.identity);
        }
    }
}
