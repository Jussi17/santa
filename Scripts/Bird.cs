using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public Animator anim;
    public GameObject bird;

    void Update()
    {
        if (PlayerPrefs.HasKey("Lintu"))
        {
            bird.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (!PlayerPrefs.HasKey("Lintu"))
            {
                anim.SetTrigger("fly");
                StartCoroutine(PoisLintu());
            }
        }
    }
    IEnumerator PoisLintu()
    {
        yield return new WaitForSeconds(7.5f);
        PlayerPrefs.SetString("Lintu","Lintu");
    }
}
