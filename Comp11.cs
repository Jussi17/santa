using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Comp11 : MonoBehaviour
{
    public Text notComp;
    public Text comp;

    void Update()
    {
        if (PlayerPrefs.HasKey("LevelComplete"))
        {
            comp.enabled = true;
            notComp.enabled = false;
        }
        if (!PlayerPrefs.HasKey("LevelComplete"))
        {
            comp.enabled = false;
            notComp.enabled = true;
        }
    }
}
