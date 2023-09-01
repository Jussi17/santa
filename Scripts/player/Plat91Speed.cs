using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plat91Speed : MonoBehaviour
{
    Movement6 mov;
    public GameObject player;

    private void Start()
    {
        mov = player.GetComponent<Movement6>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Shadow")
        {
            mov.moveSpeed = 10f;
            mov.jumpPower = 22f;
            StartCoroutine(OffFast());
        }
    }
    IEnumerator OffFast()
    {
        yield return new WaitForSeconds(1.1f);
        mov.moveSpeed = 5f;
        mov.jumpPower = 13.3f;
    }
}
