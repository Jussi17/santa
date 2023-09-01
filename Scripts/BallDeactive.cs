using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDeactive : MonoBehaviour
{
    public GameObject rb1;
    public GameObject rb2;
    public GameObject shadow1;
    public GameObject shadow2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            rb1.SetActive(false);
            rb2.SetActive(false);
            shadow1.SetActive(false);
            shadow2.SetActive(false);
        }
    }
}
