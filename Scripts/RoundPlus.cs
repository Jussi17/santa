using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets;

public class RoundPlus : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private Transform round;
    [SerializeField] private SpriteRenderer rend;
    [SerializeField] private Transform respawnPoint;
    [SerializeField] private AudioSource fireSound;
    private bool respawned = false;
    public bool lavaTouch = false;
    private bool grounded = true;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (grounded == true)
        {
            rend.color = Color.white;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Lava")
        {
            grounded = false;
            lavaTouch = true;
            respawned = false;
            fireSound.Play();        
            StartCoroutine(Tuhoudu());
        }
        if (collision.gameObject.tag == "Ground")
        {
            respawned = true;
            grounded = true;
        }
    }
    IEnumerator Tuhoudu()
    {
        yield return new WaitForSeconds(5.1f);
        rend.color = new Color(1, 0, 0, 1);
        yield return new WaitForSeconds(0.9f);
        lavaTouch = false;
        rend.color = Color.white;
        if (!respawned)
        {
            round.transform.position = respawnPoint.transform.position;      
            rb.velocity = new Vector2(0, 0);
            respawned = true;
        }
           
    }
}
