using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateDoor : MonoBehaviour
{
    public BoxCollider2D bx;
    public Renderer renderer;
    public Renderer nappi;
    [SerializeField] private AudioSource warnSound;
    private bool hasPlayed = false;


    private void Start()
    {
        bx.enabled = true;
        renderer.enabled = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (!hasPlayed)
            {
                nappi.GetComponent<SpriteRenderer>().color = Color.green;
                warnSound.Play();
                bx.enabled = false;
                renderer.enabled = false;
                hasPlayed = true;
            }
        }
    }
}
