using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityStandardAssets.CrossPlatformInput;

public class ZoomOut : MonoBehaviour
{
    [SerializeField]
    float zoomFactor = 1.0f;

    [SerializeField]
    float zoomSpeed = 5.0f;

    private float originalSize = 0f;

    private Camera thisCamera;

    void Start()
    {
        thisCamera = GetComponent<Camera>();
        originalSize = thisCamera.orthographicSize;
    }


    public void ZoomausOut()
    {
        float targetSize = originalSize * zoomFactor * 1.67f;
        if (targetSize != thisCamera.orthographicSize)
        {
            thisCamera.orthographicSize = Mathf.Lerp(thisCamera.orthographicSize,
    targetSize, Time.deltaTime * zoomSpeed);
        }
    }

    public void ZoomausBack()
    {
        float targetSize = originalSize * zoomFactor * 1f;
        if (targetSize != thisCamera.orthographicSize)
        {
            thisCamera.orthographicSize = Mathf.Lerp(thisCamera.orthographicSize,
    targetSize, Time.deltaTime * zoomSpeed);
        }
    }


    void SetZoom(float zoomFactor)
    {
        this.zoomFactor = zoomFactor;
    }
}