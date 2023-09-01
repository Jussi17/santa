using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonMove : MonoBehaviour
{
    [SerializeField] private AudioSource moveSound;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (rb.velocity.x != 0)
        {
            moveSound.Play();
        }
        else
        {
            moveSound.Stop();
        }
       
    }
}
