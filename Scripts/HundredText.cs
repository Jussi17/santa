using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HundredText : MonoBehaviour
{
    public Text easyText;
    public Text normalText;
    public Text hardText;
    public Text brutalText;

    void Start()
    {
        easyText.enabled = false;
        normalText.enabled = false;
        hardText.enabled = false;
        brutalText.enabled = false;
    }

    void Update()
    {
        if (PlayerPrefs.GetString("Difficulty") == "Easy")
        {
            easyText.enabled = true;
        }
        if (PlayerPrefs.GetString("Difficulty") == "Normal")
        {
            normalText.enabled = true;
        }
        if (PlayerPrefs.GetString("Difficulty") == "Hard")
        {
            hardText.enabled = true;
        }
        if (PlayerPrefs.GetString("Difficulty") == "Brutal")
        {
            brutalText.enabled = true;
        }
    }
}
