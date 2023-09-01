using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBall : MonoBehaviour
{
    private float bounce = 20f;
    float minTimeDiff = 0.05f;
    float lastTimecalled;
    private Animator anim;

    [SerializeField] private AudioSource boingSound;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (lastTimecalled + minTimeDiff < Time.time)
            {
                anim.SetTrigger("ball");
                boingSound.Play();
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bounce, ForceMode2D.Impulse);
            }
            lastTimecalled = Time.time;
        }
    }

}
