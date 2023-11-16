using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Offset8Pause : MonoBehaviour
{
    public GameObject canvasSetting;
    void Update()
    {
        if (canvasSetting.activeInHierarchy)
        {
            Time.timeScale = 0.03f;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
}
