using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingSnowman : MonoBehaviour
{
    public float jumpForce = 5f; 
    public float jumpDelay = 2f; 
    public float moveSpeed = 3f; 
    public bool isInAir = false; 
    private Rigidbody2D rb;
    private bool movingRight = true;
    private SpriteRenderer sprite;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        InvokeRepeating("Jump", jumpDelay, jumpDelay);
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float direction = movingRight ? 1f : -1f;
        transform.position += new Vector3(direction * moveSpeed * Time.deltaTime, 0f, 0f);
    }

    void Jump()
    {
        sprite.transform.Rotate(0, 180, 0);
        rb.AddForce(new Vector2(moveSpeed * (movingRight ? -1f : 1f), jumpForce), ForceMode2D.Impulse);
        movingRight = !movingRight;
        isInAir = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isInAir = false;
        }
    }
}
