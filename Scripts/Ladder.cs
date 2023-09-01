using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{
    [SerializeField] private AudioSource hitSound;
    private bool hasPlayed;
    private Rigidbody2D rb;
    private Vector3 vc;
    [SerializeField] private Transform ball;
    [SerializeField] private Transform respawnPoint;
    public bool hasPlayer = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        vc = new Vector3(0, 0, 0);
    }

    IEnumerator hasLadder()
    {
        yield return new WaitForSeconds(12);
        transform.rotation = Quaternion.Euler(0, 0, 0);
        ball.transform.position = respawnPoint.transform.position;
        rb.velocity = new Vector2(0, 0);
        hasPlayed = false;
        hasPlayer = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            if (!hasPlayed)
            {
                hitSound.Play();
                hasPlayed = true;
            }
        }
        if (collision.gameObject.tag == "Player" && !hasPlayer)
        {
            hasPlayer = true;
            StartCoroutine(hasLadder());
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Puu")
        {
            if (!hasPlayed)
            {
                hitSound.Play();
                hasPlayed = true;
            }
        }
    }
}
