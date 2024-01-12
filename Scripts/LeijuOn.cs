using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeijuOn : MonoBehaviour
{
    public SpriteRenderer leijuSprite;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Goblin")
        {
            leijuSprite.enabled = true;
        }
    }

}
