using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stool : MonoBehaviour
{
    private Animator anim;
    private float bounce = 20f;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(Activointi());
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(Activointi());
        }
    }

    IEnumerator Activointi()
    {
        yield return new WaitForSeconds(0.24f);
        anim.SetTrigger("stool");
    }
}
