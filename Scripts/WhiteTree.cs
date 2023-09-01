using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteTree : MonoBehaviour
{
    [SerializeField] private AudioSource stompSound;
    private bool hasPlayed = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Reindeer")
        {
            if (!hasPlayed)
            {
                stompSound.Play();
                hasPlayed = true;
                StartCoroutine(StompBack());
            }
        }
    }
    IEnumerator StompBack()
    {
        yield return new WaitForSeconds(1.6f);
        hasPlayed = false;
    }

}
