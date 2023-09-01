using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paces : MonoBehaviour
{
    public SpriteRenderer pace;
    private BoxCollider2D bx;

    private void Start()
    {
        bx = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Sleigh")
        {
            pace.enabled = false;
            bx.enabled = false;
            StartCoroutine(ReAppear());
        }
    }

    IEnumerator ReAppear()
    {
        yield return new WaitForSeconds(6f);
        pace.enabled = true;
        bx.enabled = true;
    }

}
