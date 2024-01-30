using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringCollect : MonoBehaviour
{
    public AudioSource successSound;
    public GameObject Panel;
    private SpriteRenderer sprite;
    private BoxCollider2D bx;
    public GameObject shine;
    public SpriteRenderer kaytava;
    public GameObject kaytavaObject;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        bx = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        if (PlayerPrefs.HasKey("JumpBoots"))
        {
            sprite.enabled = false;
            bx.enabled = false;
            kaytava.sortingLayerName = "Player";
            shine.SetActive(false);
            kaytavaObject.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerPrefs.SetString("JumpBoots", "JumpBoots");
            PlayerPrefs.SetString("JumpYes", "JumpYes");
            successSound.Play();
            Panel.SetActive(true);
        }
    }
}
