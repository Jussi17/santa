using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBrutal : MonoBehaviour
{
    private BoxCollider2D bx;
    private SpriteRenderer sprite;
    private Animator anim;

    private void Start()
    {
        bx = GetComponent<BoxCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (PlayerPrefs.GetString("Difficulty") == "Brutal")
        {
            bx.enabled = false;
            sprite.enabled = false;
            anim.enabled = false;
        }
    }
}
