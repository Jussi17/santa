using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NemyDamage2 : MonoBehaviour
{
    [SerializeField] protected float damage;

    protected void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<HealthFinale>().TakeDamage(damage);
            StartCoroutine(Venaus());
        }
    }

    IEnumerator Venaus()
    {
        Physics2D.IgnoreLayerCollision(3, 9, true);
        yield return new WaitForSeconds(1);
        Physics2D.IgnoreLayerCollision(3, 9, false);
    }

}
