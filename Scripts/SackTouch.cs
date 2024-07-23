using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SackTouch : MonoBehaviour
{
    public GameObject players;
    public GameObject players2;   
    void Start()
    {
        players2.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

        }
    }
}
