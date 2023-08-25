using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate2 : MonoBehaviour
{
    public Rigidbody2D rb;
    public Renderer renderer;
    [SerializeField] private AudioSource warnSound;
    private bool hasPlayed;

    void Start()
    {
        rb.gravityScale = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Sleigh" || collision.gameObject.tag == "Reindeer")
        {
            if (!hasPlayed)
            {
                renderer.GetComponent<SpriteRenderer>().color = Color.green;
                warnSound.Play();
                hasPlayed = true;
            }
            StartCoroutine(Droppaa());
        }
    }

    IEnumerator Droppaa()
    {
        yield return new WaitForSeconds(0.1f);
        rb.gravityScale = 7;
    }
}
