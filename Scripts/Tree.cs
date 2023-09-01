using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    public GameObject stopperi;
    public GameObject puu1;
    public GameObject puu2;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Football")
        {
            stopperi.SetActive(false);
            StartCoroutine(PuutPois());
        }
    }

    IEnumerator PuutPois()
    {
        yield return new WaitForSeconds(2);
        puu1.SetActive(false);
        puu2.SetActive(false);
    }
}
