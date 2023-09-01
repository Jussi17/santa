using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisGreen : MonoBehaviour
{
    [SerializeField] private AudioSource warnSound;
    public Renderer renderer;
    public BoxCollider2D bx;
    public Renderer gooRend;
    public BoxCollider2D gooBx;
    private bool hasPlayed = false;
    public GameObject dashBlock;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
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
        yield return new WaitForSeconds(0.7f);
        renderer.enabled = false;
        bx.enabled = false;
        gooRend.enabled = false;
        gooBx.enabled = false;
        dashBlock.SetActive(false);
    }

    IEnumerator Reappear()
    {
        yield return new WaitForSeconds(1f);
        hasPlayed = false;
        renderer.enabled = true;
        bx.enabled = true;
        gooRend.enabled = true;
        gooBx.enabled = true;
        dashBlock.SetActive(true);
    }

}
