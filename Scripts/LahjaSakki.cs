using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LahjaSakki : MonoBehaviour
{
    public GameObject selitysCanvas;
    public GameObject controlCanvas;
    public AudioSource happySound;
    public GameObject players;
    public GameObject players2;
    private BoxCollider2D bx;
    void Start()
    {
        selitysCanvas.SetActive(false);
        players2.SetActive(false);
        bx = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player") 
        {
            controlCanvas.SetActive(false);
            selitysCanvas.SetActive(true);
            happySound.Play();
            players2.SetActive(true);
            players.SetActive(false);
            bx.enabled = false;
        }
    }
}
