using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puu : MonoBehaviour
{
    [SerializeField] private AudioSource cheerSound;
    private bool hasPlayed = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Football")
        {
            if (!hasPlayed)
            {
                cheerSound.Play();
                hasPlayed = true;
            }
            
        }
    }

}
