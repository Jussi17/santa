using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UfoActive : MonoBehaviour
{
    public Renderer ufo;
    public Renderer goblin;
    public Renderer rey;
    public Renderer hair;
    public Animator anim;
    private bool hasPlayed = false;
    public AudioSource ufoSound;


    void Start()
    {
        ufo.enabled = false;
        anim.enabled = false;
        rey.enabled = false;
        hair.enabled = false;
        goblin.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (!hasPlayed)
            {
                ufoSound.Play();
                hasPlayed = true;
            }
            ufo.enabled = true;
            anim.enabled = true;
            goblin.enabled = true;
            rey.enabled = true;
            hair.enabled = true;
            StartCoroutine(Poisto());
        }
    }

    IEnumerator Poisto()
    {
        yield return new WaitForSeconds(7);
        hasPlayed = false;
        ufo.enabled = false;
        anim.enabled = false;
        goblin.enabled = false;
        rey.enabled = false;
        hair.enabled = false;
    }

}
