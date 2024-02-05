using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock90 : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private Transform rock;
    [SerializeField] private Transform respawnPoint;
    [SerializeField] private AudioSource rockSound;
    public GameObject red;
    public GameObject pink;
    public GameObject blue;
    public GameObject orange;
    public GameObject green;
    public GameObject purple;
    Health90 health;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            red = pink;
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            red = blue;
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            red = orange;
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            red = green;
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            red = purple;
        }
        health = red.GetComponent<Health90>();

        if (health.dead)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            rock.transform.position = respawnPoint.transform.position;
            rb.velocity = new Vector3(-4.5f, 0, 0);
        }
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
