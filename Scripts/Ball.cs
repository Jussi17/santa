using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Transform respawnPoint;
    private Rigidbody2D rb;
    [SerializeField] private Transform ball;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Lava")
        {
            ball.transform.position = respawnPoint.transform.position;
            rb.velocity = new Vector2(0, 0);
        }
    }

}
