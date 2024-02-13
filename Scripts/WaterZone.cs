using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterZone : MonoBehaviour
{
    public bool onWaterZone = false;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            onWaterZone = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        onWaterZone = false;
    }
}
