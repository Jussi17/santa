using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GobTurn : MonoBehaviour
{
    public GameObject goblin;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(Turnaa());
        }                      
    }
    IEnumerator Turnaa()
    {
        yield return new WaitForSeconds(0.3f);
        goblin.transform.Rotate(0f, 180f, 0f);
    }

}
