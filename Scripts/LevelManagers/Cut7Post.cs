using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cut7Post : MonoBehaviour
{
    private void Awake()
    {
        string activeScene = SceneManager.GetActiveScene().name;
        PlayerPrefs.SetString("LevelComplete31", "LevelComplete31");
    }

    private void OnEnable()
    {
        PlayerPrefs.SetString("LevelComplete31", "LevelComplete31");
        PlayerPrefs.SetString("AcutPost8", "AcutPost8");
        if (PlayerPrefs.GetString("Difficulty") == "Easy")
        {
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
            if (PlayerPrefs.HasKey("Cutti"))
            {
                SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
            }
            if (!PlayerPrefs.HasKey("Cutti"))
            {
                SceneManager.LoadScene("Special", LoadSceneMode.Single);
            }       
        }
        if (PlayerPrefs.GetString("Difficulty") == "Brutal")
        {
            if (PlayerPrefs.HasKey("Cutti"))
            {
                SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
            }
            if (!PlayerPrefs.HasKey("Cutti"))
            {
                SceneManager.LoadScene("SpecialBrutal", LoadSceneMode.Single);
            }        
        }
    }
}
