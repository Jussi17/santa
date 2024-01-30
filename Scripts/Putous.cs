using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Putous : MonoBehaviour
{
    public GameObject activePutous;
    public GameObject falsePutous;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            activePutous.SetActive(true);
            falsePutous.SetActive(false);
        }
    }
}
