using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamHelper : ViveGrip_Grabbable {

    // Use this for initialization
    public bool Grabbed;
	void Start () {
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;

    }

    // Update is called once per frame
    void Update () {
		
	}
      void ViveGripGrabStart(ViveGrip_GripPoint gripPoint) {
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        Grabbed = true;
    }
      void ViveGripGrabStop(ViveGrip_GripPoint gripPoint) {
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        Grabbed = false;


    }
}
