using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuuRb : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool hasHit = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Football")
        {
            if (!hasHit)
            {
                rb.AddForce(Vector2.right * 7500f);
                hasHit = true;
            }
            if (hasHit)
            {
                rb.AddForce(Vector2.right * 1500f);
            }
            
        }
    }
}
