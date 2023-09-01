using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepBirdAwake : MonoBehaviour
{
    public Animator anim;
    [SerializeField] private AudioSource birdSound;
    private bool hasPlayed = false;

    private void Start()
    {
        anim.enabled = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            anim.enabled = true;
            if (!hasPlayed)
            {
                birdSound.Play();
                hasPlayed = true;
            }
        }
    }
}
