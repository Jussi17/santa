using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonTele : MonoBehaviour
{
    public GameObject platCannon;
    private Rigidbody2D rb;
    void Start()
    {
        platCannon.SetActive(false);
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Teleport")
        {
            rb.drag = 1000;
            platCannon.SetActive(true);
            StartCoroutine(OffAnim());
        }
    }
    IEnumerator OffAnim()
    {
        yield return new WaitForSeconds(1.2f);
        platCannon.SetActive(false);
        rb.drag = 0;
    }
}
