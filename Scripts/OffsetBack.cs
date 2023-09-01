using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffsetBack : MonoBehaviour
{
    public NewCamera cam;
    public GameObject g;

    void Start()
    {
        cam = g.GetComponent<NewCamera>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Sleigh")
        {
            cam.offset = 12f;
        }
    }

}
