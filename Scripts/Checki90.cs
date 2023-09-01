using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checki90 : MonoBehaviour
{
    public BoxCollider2D bx1;
    public BoxCollider2D bx2;
    public BoxCollider2D bx3;
    public BoxCollider2D bx4;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            bx1.enabled = false;
            bx2.enabled = false;
            bx3.enabled = false;
            bx4.enabled = false;
        }
    }
}
