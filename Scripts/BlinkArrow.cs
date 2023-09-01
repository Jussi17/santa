using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkArrow : MonoBehaviour
{
    public GameObject arrow;
    void Start()
    {
        arrow.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            arrow.SetActive(true);
        }
    }
}
