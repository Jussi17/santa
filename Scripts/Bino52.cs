using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bino52 : MonoBehaviour
{
    public GameObject goblin;
    public Animator anim;
    void Start()
    {
        anim.enabled = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            anim.enabled = true;
            StartCoroutine(PoisPeikko());
        }
    }
    IEnumerator PoisPeikko()
    {
        yield return new WaitForSeconds(1.2f);
        goblin.SetActive(false);
    }
}
