using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checki : MonoBehaviour
{
    private BoxCollider2D bx;
    private bool hasPlayed = false;
    private Animator anim;
    public GameObject tama;
    public GameObject previous;
    [SerializeField] private AudioSource checkSound;


    private void Start()
    {
        bx = GetComponent<BoxCollider2D>();
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && !hasPlayed || collision.gameObject.tag == "Reindeer" || collision.gameObject.tag == "Sleigh")
        {
            checkSound.Play();
            bx.enabled = false;
            hasPlayed = true;
            anim.SetTrigger("on");
            Destroy(previous);
        }
    }
}
