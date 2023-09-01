using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutHundred : MonoBehaviour
{
    private void Awake()
    {
        string activeScene = SceneManager.GetActiveScene().name;
        if (PlayerPrefs.GetString("Difficulty") == "Easy")
        {
            PlayerPrefs.SetString("SataEasy", "SataEasy");
        }
        if (PlayerPrefs.GetString("Difficulty") == "Normal")
        {
            PlayerPrefs.SetString("Sata", "Sata");
        }
        if (PlayerPrefs.GetString("Difficulty") == "Hard")
        {
            PlayerPrefs.SetString("SataHard", "SataHard");
        }
        if (PlayerPrefs.GetString("Difficulty") == "Brutal")
        {
            PlayerPrefs.SetString("SataBrutal", "SataBrutal");
        }
    }

    private void OnEnable()
    {
        PlayerPrefs.SetString("Acut100", "Acut100");
        if (PlayerPrefs.GetString("Difficulty") == "Easy")
        {
            PlayerPrefs.SetString("SataEasy", "SataEasy");
            if (PlayerPrefs.HasKey("Cutti"))
            {
                SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
            }
            if (!PlayerPrefs.HasKey("Cutti"))
            {
                SceneManager.LoadScene("OverLevel1", LoadSceneMode.Single);
            }       
        }
        if (PlayerPrefs.GetString("Difficulty") == "Normal")
        {
            PlayerPrefs.SetString("Sata", "Sata");
            if (PlayerPrefs.HasKey("Cutti"))
            {
                SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
            }
            if (!PlayerPrefs.HasKey("Cutti"))
            {
                SceneManager.LoadScene("OverLevel1", LoadSceneMode.Single);
            }
        }
        if (PlayerPrefs.GetString("Difficulty") == "Hard")
        {
            PlayerPrefs.SetString("SataHard", "SataHard");
            if (PlayerPrefs.HasKey("Cutti"))
            {
                SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
            }
            if (!PlayerPrefs.HasKey("Cutti"))
            {
                SceneManager.LoadScene("OverLevel1", LoadSceneMode.Single);
            }
        }
        if (PlayerPrefs.GetString("Difficulty") == "Brutal")
        {
            PlayerPrefs.SetString("SataBrutal", "SataBrutal");
            if (PlayerPrefs.HasKey("Cutti"))
            {
                SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
            }
            if (!PlayerPrefs.HasKey("Cutti"))
            {
                SceneManager.LoadScene("HundredBrutal", LoadSceneMode.Single);
            }         
        }       
    }
}
