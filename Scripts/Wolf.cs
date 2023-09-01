using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wolf : MonoBehaviour
{
    private Animator anim;
    public float attackRate = 2f;
    float nextAttackTime = 0f;

    void Start()
    {
        anim = GetComponent<Animator>();       
    }


    void Update()
    {
        if (Time.time >= nextAttackTime)
        {
             anim.SetTrigger("attack");
             nextAttackTime = Time.time + 8f / attackRate;          
        }
    }
}
