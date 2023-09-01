using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeEnd : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private Transform ball;
    [SerializeField] private Transform respawnPoint;
    public GameObject spikeBall;
    public GameObject red;
    public GameObject pink;
    public GameObject blue;
    public GameObject orange;
    public GameObject green;
    public GameObject purple;
    Health health;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        if (PlayerPrefs.HasKey("SantaRed"))
        {
            health = red.GetComponent<Health>();
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            health = pink.GetComponent<Health>();
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            health = blue.GetComponent<Health>();
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            health = orange.GetComponent<Health>();
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            health = green.GetComponent<Health>();
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            health = purple.GetComponent<Health>();
        }
    }

    private void Update()
    {
        rb.AddForce(Vector2.left * 200f);

        if (health.dead)
        {
            ball.transform.position = respawnPoint.transform.position;
            rb.velocity = new Vector2(0, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Lava")
        {
            ball.transform.position = respawnPoint.transform.position;
            rb.velocity = new Vector2(0, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Lava")
        {
            ball.transform.position = respawnPoint.transform.position;
            rb.velocity = new Vector2(0, 0);
        }
    }

}
