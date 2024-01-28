using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBack : MonoBehaviour
{
    private AudioSource boingSound;
    void Start()
    {
        boingSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            boingSound.Play();
        }
    }
}
