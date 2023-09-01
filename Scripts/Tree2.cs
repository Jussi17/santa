using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree2 : MonoBehaviour
{
    public Animator anim;
    private bool canTrigger = true;
    [SerializeField] private AudioSource TreeJumpSound;
    void Start()
    {
        anim.enabled = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && canTrigger)
        {
            anim.enabled = true;
            TreeJumpSound.Play();
            canTrigger = false;
            StartCoroutine(BackAgain());
        }
    }
    IEnumerator BackAgain()
    {
        yield return new WaitForSeconds(1f);
        anim.enabled = false;
    }
}
