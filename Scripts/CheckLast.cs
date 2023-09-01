using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckLast : MonoBehaviour
{
    public EdgeCollider2D cp;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            cp.enabled = false;
        }
    }

}
