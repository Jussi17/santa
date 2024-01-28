using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BootsTree : MonoBehaviour
{
    public BoxCollider2D bx;
    public SpriteRenderer sprite;

    void Update()
    {
        if (PlayerPrefs.HasKey("SpeedBoots"))
        {
            bx.enabled = false;
            sprite.enabled = false;
        }
    }
}
