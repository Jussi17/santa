using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTrail : MonoBehaviour
{
    public TrailRenderer boxTrail;
    void Start()
    {
        boxTrail.emitting = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Blackbox")
        {
            boxTrail.emitting = true;
            StartCoroutine(PoisBox());
        }
    }
    IEnumerator PoisBox()
    {
        yield return new WaitForSeconds(0.41f);
        boxTrail.emitting = false;
    }
}
