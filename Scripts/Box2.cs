using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box2 : MonoBehaviour
{
    private AudioSource BoxSound;
    private bool hasPlayed = false;

    private void Start()
    {
        BoxSound = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Lava")
        {
            if (!hasPlayed)
            {
                BoxSound.Play();
                hasPlayed = true;
            }
        }
    }
}
