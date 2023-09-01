using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cut4new : MonoBehaviour
{
    private void Awake()
    {
        string activeScene = SceneManager.GetActiveScene().name;
        PlayerPrefs.SetString("LevelComplete15", "LevelComplete15");
    }

    private void OnEnable()
    {
        PlayerPrefs.SetString("LevelComplete15", "LevelComplete15");
        PlayerPrefs.SetString("Acut4", "Acut4");
        if (PlayerPrefs.HasKey("Cutti"))
        {
            SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
        }
        if (!PlayerPrefs.HasKey("Cutti"))
        {
            SceneManager.LoadScene("OverLevel1", LoadSceneMode.Single);
        }
    }
}