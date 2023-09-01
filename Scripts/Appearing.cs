using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Appearing : MonoBehaviour
{
    [SerializeField] AudioSource audio;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Sleigh")
        {
            audio.Play();
        }
    }
}
