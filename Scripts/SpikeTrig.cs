using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeTrig : MonoBehaviour
{
    [SerializeField] private AudioSource spike1Sound;
    [SerializeField] private AudioSource spike2Sound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            spike1Sound.volume = 0.7f;
            spike2Sound.volume = 0.7f;
        }
    }
}
