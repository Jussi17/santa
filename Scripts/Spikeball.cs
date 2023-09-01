using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikeball : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private Transform ball;
    [SerializeField] private Transform respawnPoint;
    [SerializeField] private AudioSource rollSound;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Lava")
        {
            ball.transform.position = respawnPoint.transform.position;
            rb.velocity = new Vector2(0, 0);
        }
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            rollSound.Play();
        }
    }
}
