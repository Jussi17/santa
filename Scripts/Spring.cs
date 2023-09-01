using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : MonoBehaviour
{
    [SerializeField] private Transform spring;
    [SerializeField] private Transform respawnPoint;
    private Vector3 vc;
    public Rigidbody2D rb;

    private void Start()
    {
        vc = new Vector3(0, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "SuperLava")
        {
            StartCoroutine(rbTakas());
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "SuperLava")
        {  
            StartCoroutine(rbTakas());
        }
    }

    IEnumerator rbTakas()
    {
        yield return new WaitForSeconds(1.5f);
        transform.rotation = Quaternion.Euler(0, 0, 90);
        rb.gravityScale = 3.2f;
        rb.mass = 1;
        spring.transform.position = respawnPoint.transform.position;
        rb.velocity = new Vector3(0, 0, 0);
        yield return new WaitForSeconds(2);
        rb.mass = 25;
        rb.gravityScale = 1;
    }
}
