using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IcePick : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private Transform ice;
    [SerializeField] private Transform respawnPoint;
    [SerializeField] private AudioSource iceSound;
    public GameObject icePick;
    private SpriteRenderer sprite;
    private CapsuleCollider2D cap;
    private BoxCollider2D bx;
    private bool hasPlayed = false;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
        sprite = GetComponent<SpriteRenderer>();
        cap = GetComponent<CapsuleCollider2D>();
        bx = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Ground")
        {
            rb.gravityScale = 0;
            sprite.enabled = false;
            cap.enabled = false;
            bx.enabled = false;
            if (!hasPlayed)
            {
                iceSound.Play();
                hasPlayed = true;
            }         
            StartCoroutine(IceOff());
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Ground")
        {
            rb.gravityScale = 0;
            sprite.enabled = false;
            cap.enabled = false;
            bx.enabled = false;
            if (!hasPlayed)
            {
                iceSound.Play();
                hasPlayed = true;
            }
            StartCoroutine(IceOff());
        }
    }
    IEnumerator IceOff()
    {
        yield return new WaitForSeconds(10);
        hasPlayed = false;
        sprite.color = Color.white;
        sprite.enabled = true;
        cap.enabled = true;
        bx.enabled = true;
        rb.gravityScale = 0;
        ice.transform.position = respawnPoint.transform.position;
        rb.velocity = new Vector2(0, 0);
    }
}
