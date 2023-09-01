using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    public Transform camera;
    public Vector3 offset;
    void Update()
    {
        Vector3 position = transform.position;
        position.x = (camera.position + offset).x * 0.1f;
        position.y = (camera.position + offset).y * 0.08f;
        transform.position = position;
    }
}
