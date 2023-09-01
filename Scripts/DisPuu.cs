using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisPuu : MonoBehaviour
{
    public BoxCollider2D bx;
    public Renderer renderer;
    public GameObject puu1;
    public GameObject puu2;

    void Start()
    {
        renderer.enabled = true;
        bx.enabled = true;
        puu1.SetActive(false);
        puu2.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Grab")
        {
            renderer.enabled = false;
            bx.enabled = false;
            puu1.SetActive(true);
            puu2.SetActive(true);
        }
    }

}
