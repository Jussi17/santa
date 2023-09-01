using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chain : MonoBehaviour
{
    public CapsuleCollider2D cp;
    public CapsuleCollider2D cp2;
    public CapsuleCollider2D cp3;

    void Start()
    {
        cp.enabled = false;
        cp2.enabled = false;
        cp3.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            cp.enabled = true;
            cp2.enabled = true;
            cp3.enabled = true;
        }
        if (collision.gameObject.tag == "Nelja")
        {
            cp.enabled = false;
            cp2.enabled = false;
            cp3.enabled = false;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            cp.enabled = false;
            cp2.enabled = false;
            cp3.enabled = false;
        }
    }
}
