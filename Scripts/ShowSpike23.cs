using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowSpike23 : MonoBehaviour
{
    public SpriteRenderer sawSprite;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            sawSprite.sortingLayerName = "Foreground";
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            sawSprite.sortingLayerName = "Default";
        }
    }
}
