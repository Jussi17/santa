using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBall : MonoBehaviour
{
    [SerializeField] AudioSource ballSound;
    [SerializeField] AudioSource ballSound2;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            ballSound.Play();
        }
        if (collision.gameObject.tag == "Ground")
        {
            ballSound2.Play();
        }
    }
}
