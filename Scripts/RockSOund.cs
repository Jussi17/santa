using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSOund : MonoBehaviour
{
    [SerializeField] private AudioSource rockSound;
    private bool hasPlayed = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Rounded" && !hasPlayed)
        {
            rockSound.Play();
            hasPlayed = true;
            StartCoroutine(Volat());
        }
    }
    IEnumerator Volat()
    {
        yield return new WaitForSeconds(6.4f);
        hasPlayed = false;
    }

}
