using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hatty : MonoBehaviour
{
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            anim.enabled = true;
            StartCoroutine(OffHat());
        }
    }
    IEnumerator OffHat()
    {
        yield return new WaitForSeconds(2.4f);
        PlayerPrefs.SetString("Hat", "Hat");
    }
}
