using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PikeTwo : MonoBehaviour
{
    private Rigidbody2D rb;
    private EdgeCollider2D edge;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        edge = GetComponent<EdgeCollider2D>();
        rb.mass = 9999;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Rounded")
        {
            rb.mass = 7;
            edge.enabled = false;
        }
    }
}
