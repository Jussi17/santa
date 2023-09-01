using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EightZone : MonoBehaviour
{
    public bool isZone1 = true;
    public bool isZone2 = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isZone1 = false;
            isZone2 = true;
        }
    }
}
