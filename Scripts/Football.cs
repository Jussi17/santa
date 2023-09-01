using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Football : MonoBehaviour
{
    public Movement41 movement;
    private Rigidbody2D rb;
    [SerializeField] private Transform ball;
    [SerializeField] private Transform respawnPoint;
    [SerializeField] private AudioSource kickSound;
    public GameObject red;
    public GameObject pink;
    public GameObject blue;
    public GameObject orange;
    public GameObject green;
    public GameObject purple;

    void Awake()
    {        
        rb = GetComponent<Rigidbody2D>();
        if (PlayerPrefs.HasKey("SantaRed"))
        {
            movement = red.GetComponent<Movement41>();
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            movement = pink.GetComponent<Movement41>();
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            movement = blue.GetComponent<Movement41>();
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            movement = orange.GetComponent<Movement41>();
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            movement = green.GetComponent<Movement41>();
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            movement = purple.GetComponent<Movement41>();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && collision.transform.GetComponent<Movement41>().isSliding && CrossPlatformInputManager.GetAxisRaw("Horizontal") > 0)
        {
            kickSound.Play();
            rb.AddForce(Vector2.right * 15000f);
            rb.AddForce(Vector2.up * 2000f);
        }
        if (collision.gameObject.tag == "Player" && collision.transform.GetComponent<Movement41>().isSliding && CrossPlatformInputManager.GetAxisRaw("Horizontal") < 0)
        {
            kickSound.Play();
            rb.AddForce(Vector2.left * 15000f);
            rb.AddForce(Vector2.up * 2000f);
        }
        if (collision.gameObject.tag == "Lava")
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
            rb.velocity = new Vector2(0,0);
        }
    }


}
