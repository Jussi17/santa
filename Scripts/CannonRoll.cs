using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonRoll : MonoBehaviour
{
    [SerializeField] private AudioSource rollSound;
    [SerializeField] LayerMask groundLayer;
    public Transform groundCheck;
    private Rigidbody2D rb;
    public bool grounded;
    public GameObject canvasPause;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rollSound.enabled = false;
    }

    void Update()
    {
        if (rb.velocity.x > 1)
        {
            rollSound.Play();
        }
        if (rb.velocity.x < -1)
        {
            rollSound.Play();
        }
        if (rb.velocity.x < 1 && rb.velocity.x > -1)
        {
            rollSound.Stop();
        }
        if (!grounded)
        {
            rollSound.Stop();
        }
        if (canvasPause.activeInHierarchy)
        {
            rollSound.enabled = false;
        }
        if (!canvasPause.activeInHierarchy && grounded && Time.timeSinceLevelLoad > 5)
        {
            rollSound.enabled = true;
        }
        grounded = Physics2D.OverlapCircle(groundCheck.position, 0.15f, groundLayer);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && rb.velocity.x != 0)
        {
            rollSound.Play();
        }
    }
}
