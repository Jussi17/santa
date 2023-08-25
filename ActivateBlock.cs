using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateBlock : MonoBehaviour
{
    public Renderer renderer;
    public Renderer shadow;
    public BoxCollider2D bx;
    public Rigidbody2D rb;
    [SerializeField] private AudioSource warnSound;
    private bool hasPlayed;
    public SpriteRenderer lens;

    void Start()
    {
        renderer.enabled = false;
        shadow.enabled = false;
        bx.enabled = false;
        rb.gravityScale = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Reindeer")
        {
            if (!hasPlayed)
            {
                lens.color = Color.red;
                warnSound.Play();
                hasPlayed = true;
                shadow.enabled = true;
            }         
            StartCoroutine(Droppaa());
            StartCoroutine(DeleteShadow());
        }
    }

    IEnumerator Droppaa()
    {
        yield return new WaitForSeconds(0.5f);
        renderer.enabled = true;
        bx.enabled = true;
        rb.gravityScale = 5;
    }

    IEnumerator DeleteShadow()
    {
        yield return new WaitForSeconds(1.4f);
        shadow.enabled = false;
        yield return new WaitForSeconds(0.5f);
        lens.color = Color.white;
    }
}
