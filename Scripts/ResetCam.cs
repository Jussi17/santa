using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCam : MonoBehaviour
{
    public GameObject Cam;
    NewCameraG camScript;
    void Start()
    {
        camScript = Cam.GetComponent<NewCameraG>();
        camScript.enabled = false;
    }

}
