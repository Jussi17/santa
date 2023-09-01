using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speedy : MonoBehaviour
{
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            anim.SetTrigger("move");
        }
    }

}
