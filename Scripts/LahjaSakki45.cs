using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LahjaSakki45 : MonoBehaviour
{
    public GameObject selitysCanvas;
    public GameObject controlCanvas;
    public AudioSource happySound;
    private BoxCollider2D bx;
    public GameObject slideButton;
    private bool lisaaSlide = false;

    void Start()
    {
        selitysCanvas.SetActive(false);
        bx = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        if (lisaaSlide == true)
        {
            slideButton.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            lisaaSlide = true;
            controlCanvas.SetActive(false);
            selitysCanvas.SetActive(true);
            happySound.Play();
            bx.enabled = false;
        }
    }
}
