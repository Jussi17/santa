using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LavaLast : MonoBehaviour
{
    [SerializeField] protected float damage;

    protected void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" || collision.tag == "Reindeer" || collision.tag == "Sleigh")
        {
            StartCoroutine(Fenaus());
        }
    }

    IEnumerator Fenaus()
    {
        yield return new WaitForSeconds(0.7f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}

