using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaDisCol : MonoBehaviour
{
    public GameObject lavaSplash;
    void Start()
    {
        lavaSplash.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Lava")
        {
            lavaSplash.SetActive(true);
            StartCoroutine("LavaOff");
        }
    }
    IEnumerator LavaOff()
    {
        yield return new WaitForSeconds(2f);
        lavaSplash.SetActive(false);
    }
}
