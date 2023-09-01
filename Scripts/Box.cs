using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    [SerializeField] private AudioSource BoxSound;
    private bool hasPlayed = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Lava")
        {
            if (!hasPlayed)
            {
                BoxSound.Play();
                hasPlayed = true;
                StartCoroutine(VolaBak());
            }         
        }
    }
    IEnumerator VolaBak()
    {
        yield return new WaitForSeconds(13f);
        hasPlayed = false;
    }
}
