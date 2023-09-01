using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearDisappear : MonoBehaviour
{
    public Renderer renderer;
    public BoxCollider2D bx;

    private void Start()
    {
        renderer.enabled = true;
        bx.enabled = true;
        StartCoroutine(Disappear());
    }
    IEnumerator Disappear()
    {
        yield return new WaitForSeconds(0.9f);
        renderer.enabled = false;
        bx.enabled = false;
        StartCoroutine(Appear());
    }

    IEnumerator Appear()
    {
        yield return new WaitForSeconds(2f);
        renderer.enabled = true;
        bx.enabled = true;
        StartCoroutine(Disappear());
    }
}
