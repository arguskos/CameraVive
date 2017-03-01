using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarClip : ViveGrip_Grabbable
{

    public bool Grabbed;
    public Camera Cam;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!Grabbed)
        {
            Cam.farClipPlane = Vector3.Distance(transform.position, Cam.transform.position);

            transform.position = Cam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, Cam.farClipPlane));
        }
    }
    void ViveGripGrabStart(ViveGrip_GripPoint gripPoint)
    {
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        Grabbed = true;
    }
    void ViveGripGrabStop(ViveGrip_GripPoint gripPoint)
    {
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        Grabbed = false;
        Cam.farClipPlane = Vector3.Distance(transform.position, Cam.transform.position);


    }
}
