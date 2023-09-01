using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisYellow : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private Transform yellow;
    [SerializeField] private Transform respawnPoint;
    [SerializeField] private AudioSource warnSound;
    private bool hasPlayed = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && !hasPlayed || collision.gameObject.tag == "Sleigh" && !hasPlayed)
        {
            warnSound.Play();
            rb.gravityScale = 6f;
            hasPlayed = true;
            StartCoroutine(ReturnPos());
        }
    }

    IEnumerator ReturnPos()
    {
        yield return new WaitForSeconds(3f);
        rb.gravityScale = 0f;
        hasPlayed = false;
        yellow.transform.position = respawnPoint.transform.position;

    }
}
