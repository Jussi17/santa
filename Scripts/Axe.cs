using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : MonoBehaviour
{
    public Transform point1;
    public Transform point2;
    public float speed = 2f;
    public float pauseTime = 2f;
    public float pauseTimeUp = 0.5f;
    private Vector3 currentTarget;
    public bool isPaused = false;
    private Animator anim;
    public bool isDown;

    void Start()
    {
        currentTarget = point2.position;
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (!isPaused)
        {
            transform.position = Vector3.MoveTowards(transform.position, currentTarget, speed * Time.deltaTime);

            if (transform.position == point1.position)
            {
                isPaused = true;
                Invoke("ResumeMovement", pauseTimeUp);
            }
            else if (transform.position == point2.position)
            {
                isPaused = true;
                Invoke("ResumeMovement", pauseTime);
            }
            if (transform.position == point2.position)
            {
                anim.SetBool("flip", false);
                isDown = true;
            }
            else
            {
                anim.SetBool("flip", true);
                isDown = false;
            }
        }
    }

    void ResumeMovement()
    {
        if (currentTarget == point1.position)
        {
            currentTarget = point2.position;
        }
        else
        {
            currentTarget = point1.position;
        }

        isPaused = false;
    }
}
