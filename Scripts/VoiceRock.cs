using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceRock : MonoBehaviour
{
    public AudioSource pulseSound;
    void Start()
    {
        pulseSound.volume = 0;    
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            pulseSound.volume = 1;
        }
    }
}
