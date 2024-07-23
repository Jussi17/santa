using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardEnemies : MonoBehaviour
{
    public GameObject hardEnemies;
    void Update()
    {
        if (PlayerPrefs.GetString("Difficulty") == "Normal" || PlayerPrefs.GetString("Difficulty") == "Hard" || PlayerPrefs.GetString("Difficulty") == "Brutal")
        {
            hardEnemies.SetActive(true);
        }
        else
        {
            hardEnemies.SetActive(false);
        }
    }
}
