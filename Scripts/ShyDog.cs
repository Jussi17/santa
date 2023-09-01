using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShyDog : MonoBehaviour
{
    [SerializeField] private AudioSource dogSound;
    public Animator anim;
    public GameObject dog;
    private bool hasHit = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Reindeer" && !hasHit)
        {
            anim.SetBool("run", true);
            hasHit = true;
            dogSound.Play();
            StartCoroutine(DoggOff());
        }
    }
    IEnumerator DoggOff()
    {
        yield return new WaitForSeconds(3.15f);
        dog.SetActive(false);
    }
}
