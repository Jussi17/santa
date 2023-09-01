using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnKasa : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D bx;
    [SerializeField] private Transform kasa;
    [SerializeField] private Transform respawnPoint;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bx = GetComponent<BoxCollider2D>();
        bx.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Lava")
        {
            bx.enabled = true;
            kasa.transform.position = respawnPoint.transform.position;
            rb.velocity = new Vector3(0, 0, 0);
            StartCoroutine(BxOff());
        }
    }
    IEnumerator BxOff()
    {
        yield return new WaitForSeconds(1.6f);
        bx.enabled = false;
    }
}
