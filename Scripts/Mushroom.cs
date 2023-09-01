using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : MonoBehaviour
{
    public GameObject eye1;
    public GameObject eye2;
    public Animator anim;
    public int times = 0;
    private bool eyesOpen = false;

    void Start()
    {
        eye1.SetActive(false);
        eye2.SetActive(false);
        anim.enabled = false;
    }

    private void Update()
    {
        if (times > 2)
        {
            anim.enabled = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && !eyesOpen)
        {
            eyesOpen = true;
            times++;
            if (times < 3)
            {
                eye1.SetActive(true);
                eye2.SetActive(true);
            }      
            StartCoroutine(OogatKii());
        }
    }
    IEnumerator OogatKii()
    {
        yield return new WaitForSeconds(2);
        eye1.SetActive(false);
        eye2.SetActive(false);
        yield return new WaitForSeconds(2);
        eyesOpen = false;     
    }
}
