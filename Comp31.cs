using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Comp31 : MonoBehaviour
{
    public Text notComp;
    public Text comp;

    void Update()
    {
        if (PlayerPrefs.HasKey("LevelComplete8"))
        {
            comp.enabled = true;
            notComp.enabled = false;
        }
        if (!PlayerPrefs.HasKey("LevelComplete8"))
        {
            comp.enabled = false;
            notComp.enabled = true;
        }
    }
}