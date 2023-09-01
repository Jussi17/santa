using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftAudio : MonoBehaviour
{
    [SerializeField] private AudioSource rollSound;
    [SerializeField] private Transform ball;
    [SerializeField] private Transform respawnPoint;
    private Rigidbody2D rb;
    public GameObject craft;
    private bool hasPlayed = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground" && !hasPlayed)
        {
            hasPlayed = true;
            StartCoroutine(hoverSoundi());
        }
        if (col.gameObject.tag == "Lava")
        {
            ball.transform.position = respawnPoint.transform.position;
            rb.velocity = new Vector2(0, 0);
            hasPlayed = false;
            craft.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Lava")
        {
            ball.transform.position = respawnPoint.transform.position;
            rb.velocity = new Vector2(0, 0);
            hasPlayed = false;
            craft.SetActive(false);
        }
    }
    IEnumerator hoverSoundi()
    {
        yield return new WaitForSeconds(3.5f);
        rollSound.Play();
        yield return new WaitForSeconds(7f);
        rollSound.Stop();
    }
}
