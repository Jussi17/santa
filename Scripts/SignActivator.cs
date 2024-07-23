using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignActivator : MonoBehaviour
{
    public Animator anim;

    void Update()
    {
        anim.enabled = true;
    }
}
