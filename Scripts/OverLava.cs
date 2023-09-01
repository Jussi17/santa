using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverLava : MonoBehaviour
{
    [SerializeField] private AudioSource lavaSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Reindeer")
        {
            lavaSound.Play();
        }
    }
}
