using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfRb : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator anim;
    public GameObject wolf;
    public GameObject spikeball;
    public GameObject spikeball1;
    private AudioSource audio;
    void Start()
    {
        rb.gravityScale = 0;
        audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Reindeer")
        {
            spikeball.SetActive(false);
            spikeball1.SetActive(false);
            audio.Play();
            anim.SetTrigger("die");
            wolf.transform.parent = null;
            StartCoroutine(BackRb());
        }
    }
    IEnumerator BackRb()
    {
        yield return new WaitForSeconds(0.8f);
        rb.gravityScale = 2.7f;
    }
}
