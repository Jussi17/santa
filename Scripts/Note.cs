using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public AudioSource happySound;
    private BoxCollider2D bx;
    private SpriteRenderer sprite;
    public GameObject panelNote;

    void Start()
    {
        bx = GetComponent<BoxCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (PlayerPrefs.HasKey("Note"))
        {
            bx.enabled = false;
            sprite.enabled = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            happySound.Play();
            PlayerPrefs.SetString("Note", "Note");
            panelNote.SetActive(true);
        }
    }
    public void OnCloseClick()
    {
        panelNote.SetActive(false);
    }
}
