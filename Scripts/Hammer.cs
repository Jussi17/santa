using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour
{
    [SerializeField] private AudioSource hammerSound;
    [SerializeField] ParticleSystem snowEff;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            hammerSound.Play();
            snowEff.Play();
        }
    }

}
