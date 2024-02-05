using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrows90 : MonoBehaviour
{
    public GameObject arrow;
    public GameObject arrow1;
    public GameObject arrow2;
    void Start()
    {
        arrow.SetActive(false);
        arrow1.SetActive(false);
        arrow2.SetActive(false);
    }

    void Update()
    {
        if (Time.timeSinceLevelLoad > 1f)
        {
            arrow.SetActive(true);
        }
        if (Time.timeSinceLevelLoad > 1.5f)
        {
            arrow1.SetActive(true);
        }
        if (Time.timeSinceLevelLoad > 2f)
        {
            arrow2.SetActive(true);
        }
    }
}
