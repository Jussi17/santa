using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom81 : MonoBehaviour
{
    public Camera cam;
    public float camSize;
    private bool canClick = true;

    private void Update()
    {
        camSize = cam.orthographicSize;
        if (PlayerPrefs.HasKey("Close"))
        {
            if (canClick == true)
            {
                cam.orthographicSize = 6.979978f * 0.8f;
            }
        }
        if (PlayerPrefs.HasKey("Far"))
        {
            if (canClick == true)
            {
                cam.orthographicSize = 6.979978f * 1.2f;
            }
        }
        if (!PlayerPrefs.HasKey("Far") && !PlayerPrefs.HasKey("Close"))
        {
            if (canClick == true)
            {
                cam.orthographicSize = 6.979978f;
            }
        }
    }


    public void OnZoomClick()
    {
        canClick = false;
        cam.orthographicSize = 9.8f;
    }
    public void OnZoomOff()
    {
        canClick = true;
        if (PlayerPrefs.HasKey("Close"))
        {
            cam.orthographicSize = 6.979978f * 0.8f;
        }
        if (PlayerPrefs.HasKey("Far"))
        {
            cam.orthographicSize = 6.979978f * 1.2f;
        }
        if (!PlayerPrefs.HasKey("Far") && !PlayerPrefs.HasKey("Close"))
        {
            cam.orthographicSize = 6.979978f;
        }
    }
}
