using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LahjaSakki78 : MonoBehaviour
{
    public GameObject controlCanvas;
    public GameObject timeline;
    private BoxCollider2D bx;
    public AudioSource ekaMusa;
    public AudioSource tokaMusa;


    void Start()
    {
        timeline.SetActive(false);
        bx = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            timeline.SetActive(true);
            ekaMusa.Stop();
            tokaMusa.Play();
            controlCanvas.SetActive(false);
            bx.enabled = false;
        }
    }
}
