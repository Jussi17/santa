using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotAgain : MonoBehaviour
{
    public GameObject buttonTooHard;
    public GameObject buttonTooHard2;

    private void Update()
    {
        if (PlayerPrefs.HasKey("TooHard"))
        {
            buttonTooHard.SetActive(false);
            buttonTooHard2.SetActive(false);
        }
    }

    public void OnTooHardClick()
    {
        PlayerPrefs.SetString("TooHard","TooHard");
    }
}
