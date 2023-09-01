using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saw23 : MonoBehaviour
{
    private SpriteRenderer sprite;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Grab")
        {
            sprite.sortingLayerName = "Foreground";
            sprite.sortingOrder = 4;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Grab")
        {
            sprite.sortingLayerName = "Default";
            sprite.sortingOrder = 0;
        }
    }
}
