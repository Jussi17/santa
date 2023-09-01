using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashSky : MonoBehaviour
{
    public Animator anim;
    private bool hasFlashed = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Reindeer" && !hasFlashed)
        {
            anim.SetTrigger("flash");
            hasFlashed = true;
            StartCoroutine(SkyAgain());
        }
    }
    IEnumerator SkyAgain()
    {
        yield return new WaitForSeconds(1.1f);
        hasFlashed = false;
        yield return new WaitForSeconds(0.6f);
    }
}
