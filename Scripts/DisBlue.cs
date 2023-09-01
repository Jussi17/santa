using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisBlue : MonoBehaviour
{
    [SerializeField] private AudioSource warnSound;
    private bool hasPlayed = false;
    public Renderer renderer;
    public Renderer death;
    public BoxCollider2D bx;
    public BoxCollider2D deathBx;
    public Renderer renderer1;
    public Renderer death1;
    public BoxCollider2D bx1;
    public BoxCollider2D deathBx1;
    public Renderer renderer2;
    public Renderer death2;
    public BoxCollider2D bx2;
    public BoxCollider2D deathBx2;
    public Renderer renderer3;
    public Renderer death3;
    public BoxCollider2D bx3;
    public BoxCollider2D deathBx3;
    public GameObject dashBlock1;
    public GameObject dashBlock2;
    public GameObject dashBlock3;
    public GameObject dashBlock4;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && !hasPlayed)
        {
            warnSound.Play();
            hasPlayed = true;
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
        death.enabled = false;
        deathBx.enabled = false;
        renderer1.enabled = false;     
        bx1.enabled = false;
        death1.enabled = false;
        deathBx1.enabled = false;
        renderer2.enabled = false;
        bx2.enabled = false;
        death2.enabled = false;
        deathBx2.enabled = false;
        renderer3.enabled = false;
        bx3.enabled = false;
        death3.enabled = false;
        deathBx3.enabled = false;
        dashBlock1.SetActive(false);
        dashBlock2.SetActive(false);
        dashBlock3.SetActive(false);
        dashBlock4.SetActive(false);
    }

    IEnumerator Reappear()
    {
        yield return new WaitForSeconds(2.5f);
        hasPlayed = false;
        renderer.enabled = true;
        bx.enabled = true;
        death.enabled = true;
        deathBx.enabled = true;
        renderer1.enabled = true;
        bx1.enabled = true;
        death1.enabled = true;
        deathBx1.enabled = true;
        renderer2.enabled = true;
        bx2.enabled = true;
        death2.enabled = true;
        deathBx2.enabled = true;
        renderer3.enabled = true;
        bx3.enabled = true;
        death3.enabled = true;
        deathBx3.enabled = true;
        dashBlock1.SetActive(true);
        dashBlock2.SetActive(true);
        dashBlock3.SetActive(true);
        dashBlock4.SetActive(true);
    }

}
