using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage90 : MonoBehaviour
{
    [SerializeField] protected float damage;

    protected void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" || collision.tag == "Reindeer" || collision.tag == "Sleigh")
        {
            collision.GetComponent<Health90>().TakeDamage(damage);
        }
    }

}
