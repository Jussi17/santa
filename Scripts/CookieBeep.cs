using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookieBeep : MonoBehaviour
{
    private AudioSource audio;
    public BoxCollider2D bx;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (bx.isActiveAndEnabled == false)
        {
            audio.Stop();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Reindeer" || collision.gameObject.tag == "Sleigh")
        {
            if (PlayerPrefs.HasKey("Note"))
            {
                audio.Play();
            }         
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Reindeer" || collision.gameObject.tag == "Sleigh")
        {
            audio.Stop();
        }
    }
}
