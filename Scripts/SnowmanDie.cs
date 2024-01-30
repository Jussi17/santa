using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowmanDie : MonoBehaviour
{
    public GameObject offSaw;
    private SpriteRenderer sprite;
    private BoxCollider2D bx;
    public GameObject particles;
    JumpingSnowman jumpMan;
    private Rigidbody2D rb;
    public GameObject shadow;
    private AudioSource sound;
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        bx = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();
        jumpMan = GetComponent<JumpingSnowman>();
        particles.SetActive(false);
        sound = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "HangLeft")
        {
            jumpMan.enabled = false;
            sound.Play();
            rb.isKinematic = true;
            offSaw.SetActive(false);
            sprite.enabled = false;
            bx.enabled = false;
            particles.SetActive(true);
            shadow.SetActive(false);
        }
    }
}
