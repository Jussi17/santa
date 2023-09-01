using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroManager : MonoBehaviour
{
    public Animator anim;
    public MovingPlatform mp;
    public MovingPlatform mount;
    public MovingPlatform cloud;
    public Animator red;
    public Animator pink;
    public Animator blue;
    public Animator orange;
    public Animator green;
    public Animator purple;


    private void Start()
    {
        anim.enabled = false;
    }

    void Update()
    {
        if (Time.timeSinceLevelLoad > 10)
        {
            anim.enabled = true;
            red.enabled = false;
            pink.enabled = false;
            blue.enabled = false;
            orange.enabled = false;
            green.enabled = false;
            purple.enabled = false;
            mp.moveSpeed = 0.39f;
            mount.moveSpeed = 0.8f;
            cloud.moveSpeed = 1.4f;
        }
        if (Time.timeSinceLevelLoad > 18)
        {
            mp.moveSpeed = 0.3f;
            mount.moveSpeed = 0.66f;
            cloud.moveSpeed = 1.17f;
        }
        if (Time.timeSinceLevelLoad > 24)
        {
            mp.moveSpeed = 0.23f;
            mount.moveSpeed = 0.52f;
            cloud.moveSpeed = 0.93f;
        }
        if (Time.timeSinceLevelLoad > 26)
        {
            mp.moveSpeed = 0.17f;
            mount.moveSpeed = 0.4f;
            cloud.moveSpeed = 0.71f;
        }
    }
}
