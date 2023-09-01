using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallActive : MonoBehaviour
{
    public Rigidbody2D rb1;
    public Rigidbody2D rb2;
    Life life;
    public GameObject lifeCanvas;

    void Start()
    {
        life = lifeCanvas.GetComponent<Life>();
        rb1.gravityScale = 0;
        rb2.gravityScale = 0;
    }
    private void Update()
    {
        if (life.lives == 0)
        {
            rb1.isKinematic = true;
            rb2.isKinematic = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            rb1.gravityScale = 0.8f;
            rb2.gravityScale = 0.8f;
        }
    }
}
