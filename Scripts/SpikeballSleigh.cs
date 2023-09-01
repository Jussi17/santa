using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeballSleigh : MonoBehaviour
{
    [SerializeField] private AudioSource rollSound;
    [SerializeField] private Transform ball;
    [SerializeField] private Transform respawnPoint;
    public GameObject spike;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            rollSound.Play();
        }
        if (col.gameObject.tag == "Lava")
        {
            ball.transform.position = respawnPoint.transform.position;
            rb.velocity = new Vector2(0, 0);
            spike.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Lava")
        {
            ball.transform.position = respawnPoint.transform.position;
            rb.velocity = new Vector2(0, 0);
            spike.SetActive(false);
        }
    }
}