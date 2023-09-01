using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCave : MonoBehaviour
{
    public GameObject sprite1;
    public SpriteRenderer cookie;
    public GameObject shine;

    void Start()
    {
        sprite1.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Reindeer")
        {
            sprite1.SetActive(true);
            cookie.sortingLayerName = "Player";
            shine.SetActive(false);
        }
    }
}
