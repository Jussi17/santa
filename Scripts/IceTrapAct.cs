using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceTrapAct : MonoBehaviour
{
    public GameObject iceTrap;
    public Rigidbody2D rb;
    public SpriteRenderer sprite;
    private BoxCollider2D bx;
    void Start()
    {
        rb.gravityScale = 0;
        bx = GetComponent<BoxCollider2D>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Rounded" || collision.gameObject.tag == "Player")
        {
            sprite.color = Color.blue;
            bx.enabled = false;
            StartCoroutine(CanDrop());
        }
    }
    IEnumerator CanDrop()
    {
        yield return new WaitForSeconds(0.4f);
        rb.gravityScale = 0.95f;
        yield return new WaitForSeconds(9.6f);
        bx.enabled = true;
    }
}
