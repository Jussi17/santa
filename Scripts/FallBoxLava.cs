using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallBoxLava : MonoBehaviour
{
    public GameObject lavaSplash;
    void Start()
    {
        lavaSplash.SetActive(false);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Lava"))
        {
            lavaSplash.SetActive(true);
        }
    }
}
