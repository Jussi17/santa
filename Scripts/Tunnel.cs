using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tunnel : MonoBehaviour
{
    public GameObject cave;
    public SpriteRenderer cookie;
    public GameObject shine;
    public GameObject shine1;

    void Start()
    {
        cave.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Reindeer")
        {
            cave.SetActive(true);
            cookie.sortingLayerName = "Player";
            shine.SetActive(false);
            shine1.SetActive(false);
        }
    }
}
