using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageReki : MonoBehaviour
{
    [SerializeField] protected float damage;

    protected void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" || collision.tag == "Reindeer" || collision.tag == "Sleigh")
        {
            collision.GetComponent<HealthReki>().TakeDamage(damage);
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
