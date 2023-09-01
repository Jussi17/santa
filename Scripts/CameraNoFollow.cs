using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraNoFollow : MonoBehaviour
{
    Timer3 timer;
    public GameObject backGround;
    NewCamera camera;
    public GameObject cam;
    void Start()
    {
        camera = cam.GetComponent<NewCamera>();
        timer = backGround.GetComponent<Timer3>();
    }

    void Update()
    {
        if (timer.timer > 22.7f)
        {
            camera.player = null;
        }
    }
}
