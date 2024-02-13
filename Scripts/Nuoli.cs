using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nuoli : MonoBehaviour
{
    private SpriteRenderer sprite;
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (PlayerPrefs.HasKey("NinetyNine"))
        {
            sprite.enabled = false;
        }
    }
}
