using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cut56Cam : MonoBehaviour
{
    NewCamera cam;
    MoveNext56 mNext;
    public GameObject MoveNext;
    void Start()
    {
        cam = GetComponent<NewCamera>();
        cam.enabled = false;
        mNext = MoveNext.GetComponent<MoveNext56>();
    }

    private void Update()
    {
        if (mNext.isFinished == true)
        {
            cam.enabled = false;
        }
    }

    public void ActivateCamera()
    {
        cam.enabled = true;
    }
}
