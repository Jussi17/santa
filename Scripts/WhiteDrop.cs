using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteDrop : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private AudioSource waterSound;
    [SerializeField] private AudioSource windSound;
    private bool hasPlayed = false;
    [SerializeField] private Transform platform;
    [SerializeField] private Transform respawnPoint;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Reindeer" || collision.gameObject.tag == "Player")
        {
            windSound.Play();
            rb.gravityScale = 2.1f;
        }
        if (collision.gameObject.tag == "Lava")
        {
            if (!hasPlayed)
            {
                waterSound.Play();
                hasPlayed = true;
            }
            StartCoroutine(Takas());           
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Lava")
        {
            if (!hasPlayed)
            {
                waterSound.Play();
                hasPlayed = true;
            }
            StartCoroutine(Takas());

        }
    }


    IEnumerator Takas()
    {
        yield return new WaitForSeconds(3f);
        platform.transform.position = respawnPoint.transform.position;
        rb.velocity = new Vector2(0, 0);
        rb.gravityScale = 0;
        hasPlayed = false;
    }
}
