using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shadow : MonoBehaviour
{
    public Transform ball;

    void Update()
    {
        transform.position = new Vector2(ball.position.x, transform.position.y);
    }
}