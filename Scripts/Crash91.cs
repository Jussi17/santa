using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crash91 : MonoBehaviour
{
    [SerializeField] private AudioSource crashSound;
    private bool hasPlayed = false;
    private bool playerOn = false;
    private void Update()
    {
        if (playerOn == true && !hasPlayed)
        {
            StartCoroutine(PlayAgain());
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerOn = true;     
        }
    }
    IEnumerator PlayAgain()
    {
        yield return new WaitForSeconds(1f);
        crashSound.Play();
        hasPlayed = true;
        yield return new WaitForSeconds(3);
        playerOn = false;
        hasPlayed = false;
    }

}
