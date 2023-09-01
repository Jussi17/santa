using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPlayer : MonoBehaviour
{
    public Animator anim;
    void Start()
    {
        anim.enabled = false;
    }

    private void Update()
    {
        if (Time.timeSinceLevelLoad > 2.5f)
        {
            anim.enabled = true;
        }
    }
}
