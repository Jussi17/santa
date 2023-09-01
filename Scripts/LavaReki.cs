using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LavaReki : MonoBehaviour
{
    [SerializeField] protected float damage;

    protected void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" || collision.tag == "Reindeer" || collision.tag == "Sleigh")
            collision.GetComponent<HealthReki>().TakeDamage(damage);
    }

}

