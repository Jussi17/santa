using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveHelp : MonoBehaviour
{
    void Start()
    {
        if (PlayerPrefs.GetString("Difficulty") == "Hard")
        {
            PlayerPrefs.DeleteKey("ExtraHelp");
        }
        if (PlayerPrefs.GetString("Difficulty") == "Brutal")
        {
            PlayerPrefs.DeleteKey("ExtraHelp");
        }
    }

}
