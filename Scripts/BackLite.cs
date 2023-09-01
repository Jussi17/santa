using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackLite : MonoBehaviour
{
    public Transform cam;
    public Vector3 offset;

    private void FixedUpdate()
    {
        Vector3 position = transform.position;
        position.x = (cam.position + offset).x * 0.055f;
        position.y = (cam.position + offset).y * 0.055f;
        transform.position = position;
    }
}
