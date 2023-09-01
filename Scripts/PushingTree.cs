using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushingTree : MonoBehaviour
{
    private Animator anim;
    private bool isActive = false;

    void Start()
    {
        anim = GetComponent<Animator>();
        anim.enabled = false;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && !isActive)
        {
            anim.enabled = true;
            isActive = true;
            StartCoroutine(TreeChill());
        }
    }
    IEnumerator TreeChill()
    {
        yield return new WaitForSeconds(13.02f);
        isActive = false;
        anim.enabled = false;
    }
}
