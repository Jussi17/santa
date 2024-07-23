using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LahjaSakki56 : MonoBehaviour
{
    public GameObject selitysCanvas;
    public GameObject controlCanvas;
    public AudioSource happySound;
    private BoxCollider2D bx;

    void Start()
    {
        selitysCanvas.SetActive(false);
        bx = GetComponent<BoxCollider2D>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            controlCanvas.SetActive(false);
            selitysCanvas.SetActive(true);
            happySound.Play();
            bx.enabled = false;
        }
    }
}
