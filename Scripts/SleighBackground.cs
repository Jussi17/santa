using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleighBackground : MonoBehaviour
{
    public GameObject Layer1;
    public GameObject Mukana;
    void Start()
    {
        Mukana.transform.parent = null;
        Mukana.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Sleigh")
        {
            Mukana.transform.parent = Layer1.transform; ;
            Mukana.SetActive(true);
        }
    }
}
