using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowOnNormal : MonoBehaviour
{
    public GameObject infoButton;
    void Start()
    {
        if (PlayerPrefs.GetString("Difficulty") == "Hard")
        {
            infoButton.SetActive(false);
        }
        if (PlayerPrefs.GetString("Difficulty") == "Brutal")
        {
            infoButton.SetActive(false);
        }
        if (PlayerPrefs.GetString("Difficulty") == "Easy")
        {
            infoButton.SetActive(false);
        }
    }

    void Update()
    {
        if (PlayerPrefs.GetString("Difficulty") == "Hard")
        {
            infoButton.SetActive(false);
        }
        if (PlayerPrefs.GetString("Difficulty") == "Brutal")
        {
            infoButton.SetActive(false);
        }
        if (PlayerPrefs.GetString("Difficulty") == "Easy")
        {
            infoButton.SetActive(false);
        }
    }

}
