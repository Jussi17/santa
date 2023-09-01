using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMap : MonoBehaviour
{
    public GameObject cameraMap;
    public Camera cameraMain;
    public CameraOverWorld cameraScript;
    public GameObject buttonMap;
    public GameObject buttonMapOff;
    public GameObject canvas;
    public GameObject info;
    public GameObject home;
    public GameObject pause;
    public GameObject settings;
    void Start()
    {
        cameraMap.SetActive(false);
        buttonMapOff.SetActive(false);
    }

    public void OnCameraMapClick()
    {
        cameraMap.SetActive(true);
        cameraMain.enabled = false;
        cameraScript.enabled = false;
        buttonMap.SetActive(false);
        buttonMapOff.SetActive(true);
        canvas.SetActive(false);
        info.SetActive(false);
        home.SetActive(false);
        pause.SetActive(false);
        settings.SetActive(false);
    }
    public void OnCameraMapOffClick()
    {
        cameraMap.transform.position = new Vector3(-46.7f, -225.5f, -10);
        cameraMap.SetActive(false);
        cameraMain.enabled = true;
        cameraScript.enabled = true;
        buttonMap.SetActive(true);
        buttonMapOff.SetActive(false);
        canvas.SetActive(true);
        info.SetActive(true);
        home.SetActive(true);
        pause.SetActive(true);
        settings.SetActive(true);
    }
}
