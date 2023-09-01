using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdgeFootball : MonoBehaviour
{
    private EdgeCollider2D ed;
    void Start()
    {
        ed = GetComponent<EdgeCollider2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Football" || collision.gameObject.tag == "Player")
        {
            ed.enabled = false;
        }
    }
}
