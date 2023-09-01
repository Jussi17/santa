using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lv51Deact : MonoBehaviour
{
    public GameObject boxes;
    public GameObject activePoint;
    public bool boxesOff = false;
    public CapsuleCollider2D cap;

    private void Start()
    {
        cap.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            boxesOff = true;
            cap.enabled = true;
            boxes.SetActive(false);
            activePoint.SetActive(false);
        }
    }
}
