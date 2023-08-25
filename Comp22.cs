using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Comp22 : MonoBehaviour
{
    public Text notComp;
    public Text comp;

    void Update()
    {
        if (PlayerPrefs.HasKey("LevelComplete5"))
        {
            comp.enabled = true;
            notComp.enabled = false;
        }
        if (!PlayerPrefs.HasKey("LevelComplete5"))
        {
            comp.enabled = false;
            notComp.enabled = true;
        }
    }
}