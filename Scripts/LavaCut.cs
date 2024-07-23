using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaCut : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint1;
    [SerializeField] private Transform respawnPoint2;
    public bool posStart = true;
    public bool posEnd = false;
    public AudioSource lavaSound;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Lava")
        {
            lavaSound.Play();
            if (posStart == true)
            {
                player.transform.position = respawnPoint1.transform.position;
                rb.velocity = new Vector2(0, 0);
            }
            else if (posEnd == true)
            {
                player.transform.position = respawnPoint2.transform.position;
                rb.velocity = new Vector2(0, 0);
            }
            else
            {
                player.transform.position = respawnPoint1.transform.position;
                rb.velocity = new Vector2(0, 0);
            }
        }
        if (collision.gameObject.tag == "HangLeft")
        {
            posStart = false;
            posEnd = true;
        }
    }
}
