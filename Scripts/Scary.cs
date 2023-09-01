using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scary : MonoBehaviour
{
    public BoxCollider2D bx;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            bx.enabled = false;
        }
    }

}
