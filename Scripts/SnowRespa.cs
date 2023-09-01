using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowRespa : MonoBehaviour
{
    public GameObject snowBall;
    [SerializeField] private Transform ball;
    [SerializeField] private Transform respawnPoint;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        snowBall.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Lava")
        {
            ball.transform.position = respawnPoint.transform.position;
            rb.velocity = new Vector2(0, 0);
            StartCoroutine(Respaus());
        }
    }
    IEnumerator Respaus()
    {
        yield return new WaitForSeconds(0.05f);
        snowBall.SetActive(false);
    }
}
