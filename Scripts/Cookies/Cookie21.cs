using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cookie21 : MonoBehaviour
{
    public GameObject cookie;
    [SerializeField] private AudioSource hohoSound;
    public Image cookieImage;
    public bool hasCookie = false;
    private BoxCollider2D bx;
    private SpriteRenderer sprite;

    private void Start()
    {
        cookieImage.enabled = false;
        bx = GetComponent<BoxCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (hasCookie)
        {
            cookieImage.enabled = true;
        }
        if (PlayerPrefs.HasKey("Gift7"))
        {
            cookie.SetActive(false);
            cookieImage.enabled = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            hasCookie = true;
            bx.enabled = false;
            sprite.enabled = false;
            hohoSound.Play();
            StartCoroutine(OffCookie());
        }
    }
    IEnumerator OffCookie()
    {
        yield return new WaitForSeconds(2.2f);
        cookie.SetActive(false);
    }
}
