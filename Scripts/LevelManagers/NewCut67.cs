using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewCut67 : MonoBehaviour
{
    private void Awake()
    {
        string activeScene = SceneManager.GetActiveScene().name;
        PlayerPrefs.SetString("LevelComplete19", "LevelComplete19");
    }

    private void OnEnable()
    {
        PlayerPrefs.SetString("LevelComplete19", "LevelComplete19");
        PlayerPrefs.SetString("Acut5", "Acut5");
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
