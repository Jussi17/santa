using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateScary : MonoBehaviour
{
    private bool hasPlayed = false;
    public AudioSource owlSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && !hasPlayed)
        {
            owlSound.Play();
            hasPlayed = true;
        }
    }

}
