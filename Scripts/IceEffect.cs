using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceEffect : MonoBehaviour
{
    public GameObject efekti;
    void Start()
    {
        efekti.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            efekti.SetActive(true);
            StartCoroutine(PoisEfekti());
        }
    }
    IEnumerator PoisEfekti()
    {
        yield return new WaitForSeconds(1);
        efekti.SetActive(false);
    }
}
