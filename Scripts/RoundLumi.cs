using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets;

public class RoundLumi : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private SpriteRenderer rend;
    [SerializeField] private Transform round;
    [SerializeField] private Transform respawnPoint;
    [SerializeField] private AudioSource fireSound;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Lava")
        {
            fireSound.Play();
            rend.color = new Color(1, 0, 0, 1);
            StartCoroutine(Tuhoudu());
        }
    }
    IEnumerator Tuhoudu()
    {
        yield return new WaitForSeconds(2f);
        rend.color = new Color(1, 1, 1);
        round.transform.position = respawnPoint.transform.position;
        rb.velocity = new Vector2(0, 0);
    }

}
