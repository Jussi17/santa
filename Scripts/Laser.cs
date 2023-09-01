using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public Renderer laser1;
    public Renderer laser2;
    public AudioSource gobLaugh;
    public Animator anim;
    public Animator anim2;
    private bool hasPlayed = false;

    private void Start()
    {
        laser1.enabled = false;
        laser2.enabled = false;
        anim.enabled = false;
        anim2.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {           
            laser1.enabled = true;
            laser2.enabled = true;
            anim.enabled = true;
            anim2.enabled = true;

            if (!hasPlayed)
            {
                gobLaugh.Play();
                hasPlayed = true;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            laser1.enabled = true;
            laser2.enabled = true;
            anim.enabled = true;
            anim2.enabled = true;

            if (!hasPlayed)
            {
                gobLaugh.Play();
                hasPlayed = true;
            }
        }
    }

}
