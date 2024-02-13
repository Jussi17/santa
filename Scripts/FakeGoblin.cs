using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeGoblin : MonoBehaviour
{
    public GameObject laser;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        anim.enabled = false;
    }

    void Update()
    {
        if (laser.activeInHierarchy)
        {
            anim.enabled = true;
        }
    }
}

