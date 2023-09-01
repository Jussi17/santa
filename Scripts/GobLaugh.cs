using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GobLaugh : MonoBehaviour
{
    [SerializeField] private AudioSource laughSound;
    private BoxCollider2D bx;
    public GameObject Sky;
    public GameObject Moon;
    public Animator anim;
    public Animator animMoon;

    private void Start()
    {
        bx = GetComponent<BoxCollider2D>();
        anim = Sky.GetComponent<Animator>();
        animMoon = Moon.GetComponent<Animator>();
        //newSky.SetActive(false);
    }
    private void Update()
    {
        if (PlayerPrefs.HasKey("LevelComplete31"))
        {
            bx.enabled = false;
            anim.SetBool("skyred", false);
            animMoon.SetBool("moonred", false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && !PlayerPrefs.HasKey("LaughHah"))
        {
            laughSound.Play();
            PlayerPrefs.SetString("LaughHah", "LaughHah");
        }
        if (collision.gameObject.tag == "Player")
        {
            anim.SetBool("skyred", true);
            animMoon.SetBool("moonred", true);
        }
    }
}
