using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moon : MonoBehaviour
{
    private SpriteRenderer sprite;
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (PlayerPrefs.HasKey("LevelComplete31"))
        {
            sprite.color = Color.white;
        }
    }
}
