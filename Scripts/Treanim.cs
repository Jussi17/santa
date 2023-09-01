using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treanim : MonoBehaviour
{
    private Animator anim;
    PuuRb puuRb;
    public GameObject tree;
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.enabled = false;
        puuRb = tree.GetComponent<PuuRb>();
    }

    void Update()
    {
        if (puuRb.hasHit == true)
        {
            anim.enabled = true;
        }
    }
}
