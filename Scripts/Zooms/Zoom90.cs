using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom90 : MonoBehaviour
{
    public Camera Maincam;
    public Camera Sleighcam;
    public Camera Maincam2;
    public float camSize;
    private bool canClick = true;

    private void Update()
    {
        if (Maincam.enabled == true)
        {
            if (PlayerPrefs.HasKey("Close"))
            {
                if (canClick == true)
                {
                    Maincam.orthographicSize = 6.613029f * 0.8f;
                }
            }
            if (PlayerPrefs.HasKey("Far"))
            {
                if (canClick == true)
                {
                    Maincam.orthographicSize = 6.613029f * 1.2f;
                }
            }
            if (!PlayerPrefs.HasKey("Far") && !PlayerPrefs.HasKey("Close"))
            {
                if (canClick == true)
                {
                    Maincam.orthographicSize = 6.613029f;
                }
            }
        }
        if (Sleighcam.enabled == true)
        {
            if (PlayerPrefs.HasKey("Close"))
            {
                if (canClick == true)
                {
                    Sleighcam.orthographicSize = 10.64331f * 0.8f;
                }
            }
            if (PlayerPrefs.HasKey("Far"))
            {
                if (canClick == true)
                {
                    Sleighcam.orthographicSize = 10.64331f * 1.2f;
                }
            }
            if (!PlayerPrefs.HasKey("Far") && !PlayerPrefs.HasKey("Close"))
            {
                if (canClick == true)
                {
                    Sleighcam.orthographicSize = 10.64331f;
                }
            }
        }
        if (Maincam2.enabled == true)
        {
            if (PlayerPrefs.HasKey("Close"))
            {
                if (canClick == true)
                {
                    Maincam2.orthographicSize = 6.613029f * 0.8f;
                }
            }
            if (PlayerPrefs.HasKey("Far"))
            {
                if (canClick == true)
                {
                    Maincam2.orthographicSize = 6.613029f * 1.2f;
                }
            }
            if (!PlayerPrefs.HasKey("Far") && !PlayerPrefs.HasKey("Close"))
            {
                if (canClick == true)
                {
                    Maincam2.orthographicSize = 6.613029f;
                }
            }
        }

    }


    public void OnZoomClick()
    {
        canClick = false;
        if (Maincam.enabled == true)
        {
            Maincam.orthographicSize = 9.4f;
        }
        if (Sleighcam.enabled == true)
        {
            Sleighcam.orthographicSize = 14.6f;
        }
        if (Maincam2.enabled == true)
        {
            Maincam2.orthographicSize = 9.4f;
        }
    }
    public void OnZoomOff()
    {
        canClick = true;
        if (Maincam.enabled == true)
        {
            if (PlayerPrefs.HasKey("Close"))
            {
                if (canClick == true)
                {
                    Maincam.orthographicSize = 6.613029f * 0.8f;
                }
            }
            if (PlayerPrefs.HasKey("Far"))
            {
                if (canClick == true)
                {
                    Maincam.orthographicSize = 6.613029f * 1.2f;
                }
            }
            if (!PlayerPrefs.HasKey("Far") && !PlayerPrefs.HasKey("Close"))
            {
                if (canClick == true)
                {
                    Maincam.orthographicSize = 6.613029f;
                }
            }
        }
        if (Sleighcam.enabled == true)
        {
            if (PlayerPrefs.HasKey("Close"))
            {
                if (canClick == true)
                {
                    Sleighcam.orthographicSize = 10.64331f * 0.8f;
                }
            }
            if (PlayerPrefs.HasKey("Far"))
            {
                if (canClick == true)
                {
                    Sleighcam.orthographicSize = 10.64331f * 1.2f;
                }
            }
            if (!PlayerPrefs.HasKey("Far") && !PlayerPrefs.HasKey("Close"))
            {
                if (canClick == true)
                {
                    Sleighcam.orthographicSize = 10.64331f;
                }
            }
        }
        if (Maincam2.enabled == true)
        {
            if (PlayerPrefs.HasKey("Close"))
            {
                if (canClick == true)
                {
                    Maincam2.orthographicSize = 6.613029f * 0.8f;
                }
            }
            if (PlayerPrefs.HasKey("Far"))
            {
                if (canClick == true)
                {
                    Maincam2.orthographicSize = 6.613029f * 1.2f;
                }
            }
            if (!PlayerPrefs.HasKey("Far") && !PlayerPrefs.HasKey("Close"))
            {
                if (canClick == true)
                {
                    Maincam2.orthographicSize = 6.613029f;
                }
            }
        }
    }
}
