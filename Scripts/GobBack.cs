using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GobBack : MonoBehaviour
{
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetTrigger("runn");
    }

}
