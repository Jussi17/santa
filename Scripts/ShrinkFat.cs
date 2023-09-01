using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkFat : MonoBehaviour
{
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (PlayerPrefs.HasKey("ExtraHelp"))
        {
            anim.SetBool("fat", true);
        }
    }
}
