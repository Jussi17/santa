using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedOff : MonoBehaviour
{
    public Text speedText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Sleigh")
        {
            speedText.enabled = false;
        }
    }
}
