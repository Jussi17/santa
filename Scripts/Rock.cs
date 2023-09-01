using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private Transform rock;
    [SerializeField] private Transform respawnPoint;
    [SerializeField] private AudioSource rockSound;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "SuperLava")
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            rock.transform.position = respawnPoint.transform.position;
            rb.velocity = new Vector3(-4.5f, 0, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Lava")
        {
            rockSound.Play();
        }
        
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Lava")
        {
            rockSound.Stop();
        }
    }

}
