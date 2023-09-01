using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfReset : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject kokoWolf;
    [SerializeField] private Transform wolf;
    [SerializeField] private Transform respawnPoint;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Lava")
        {
            wolf.transform.position = respawnPoint.transform.position;
            rb.velocity = new Vector2(0, 0);
            kokoWolf.SetActive(false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Lava")
        {
            wolf.transform.position = respawnPoint.transform.position;
            rb.velocity = new Vector2(0, 0);
            kokoWolf.SetActive(false);
        }
    }
}
