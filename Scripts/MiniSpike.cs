using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class MiniSpike : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private Transform ball;
    [SerializeField] private Transform respawnPoint;
    [SerializeField] private AudioSource waterSound;
    public GameObject spikeBall;
    public GameObject aaltoEffect;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        aaltoEffect.SetActive(false);
    }

    private void Update()
    {
        if (spikeBall != isActiveAndEnabled)
        {
            waterSound.Stop();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Blackbox" || collision.gameObject.tag == "Lava")
        {
            waterSound.Play();
            aaltoEffect.SetActive(true);
            ball.transform.position = respawnPoint.transform.position;
            rb.velocity = new Vector2(0, 0);
            StartCoroutine(AaltoPois());
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Lava" || collision.gameObject.tag == "Blackbox")
        {
            waterSound.Play();
            aaltoEffect.SetActive(true);
            ball.transform.position = respawnPoint.transform.position;
            rb.velocity = new Vector2(0, 0);
            StartCoroutine(AaltoPois());
        }
    }
    IEnumerator AaltoPois()
    {
        yield return new WaitForSeconds(0.5f);
        aaltoEffect.SetActive(false);
    }


}
