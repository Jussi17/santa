using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutBrutal : MonoBehaviour
{
    private void Awake()
    {
        string activeScene = SceneManager.GetActiveScene().name;
        PlayerPrefs.SetString("CutCompleteBrutal", "CutCompleteBrutal");
    }

    private void OnEnable()
    {
        PlayerPrefs.SetString("CutCompleteBrutal", "CutCompleteBrutal");
        PlayerPrefs.SetString("Acut100Brutal", "Acut100Brutal");
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
