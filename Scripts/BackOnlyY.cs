using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackOnlyY : MonoBehaviour
{
    public Transform cam;
    public Vector3 offset;

    private void FixedUpdate()
    {
        Vector3 position = transform.position;
        position.x = (cam.position + offset).x * 0f;
        position.y = (cam.position + offset).y * 0.16f;
        transform.position = position;
    }
}
