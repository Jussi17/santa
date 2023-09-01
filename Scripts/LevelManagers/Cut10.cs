using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cut10 : MonoBehaviour
{
    private void Awake()
    {
        string activeScene = SceneManager.GetActiveScene().name;
        PlayerPrefs.SetString("CutLast10", "CutLast10");
        PlayerPrefs.SetString("BeatGame", "BeatGame");
    }

    private void OnEnable()
    {
        PlayerPrefs.SetString("CutLast10", "CutLast10");
        PlayerPrefs.SetString("BeatGame", "BeatGame");
        PlayerPrefs.SetString("Acut10", "Acut10");
        if (PlayerPrefs.HasKey("Cutti"))
        {
            SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
        }
        if (!PlayerPrefs.HasKey("Cutti"))
        {
            SceneManager.LoadScene("HundredPercent", LoadSceneMode.Single);
        }     
    }
}

