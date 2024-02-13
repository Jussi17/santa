using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenTrap : MonoBehaviour
{
    private SpriteRenderer thisSprite;
    public SpriteRenderer oldGround;
    public GameObject shine;
    private BoxCollider2D bx;
    void Start()
    {
        thisSprite = GetComponent<SpriteRenderer>();
        bx = GetComponent<BoxCollider2D>();
        thisSprite.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            thisSprite.enabled = true;
            oldGround.sortingLayerName = "Background";
            oldGround.sortingOrder = 150;
            bx.enabled = false;
            shine.SetActive(false);
        }
    }

}
