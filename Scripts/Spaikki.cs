using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaikki : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private AudioSource rollSound;
    private bool hasPlayed = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (rb.velocity.x > 0)
        {
            if (!hasPlayed)
            {
                rollSound.Play();
                hasPlayed = true;
            }
        }
    }
}
