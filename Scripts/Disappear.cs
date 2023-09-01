using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear : MonoBehaviour
{
    [SerializeField] private AudioSource warnSound;
    public Renderer renderer;
    public BoxCollider2D bx;
    private bool hasPlayed = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Puu"|| collision.gameObject.tag == "Rounded" || collision.gameObject.tag == "Sleigh")
        {
            if (!hasPlayed)
            {
                warnSound.Play();
                hasPlayed = true;
            }          
            StartCoroutine(Wait());
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        StartCoroutine(Reappear());
    }


    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.5f);
        renderer.enabled = false;
        bx.enabled = false;
    }

    IEnumerator Reappear()
    {
        yield return new WaitForSeconds(3f);
        hasPlayed = false;
        renderer.enabled = true;
        bx.enabled = true;
    }
}

