using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeActivateSpikehead : MonoBehaviour
{
    public GameObject spikeHead;
    public GameObject spikeHead2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            spikeHead.SetActive(false);
            spikeHead2.SetActive(false);
        }
    }

}
