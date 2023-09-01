using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;

public class Intro2222 : MonoBehaviour
{
    private void OnEnable()
    {
        PlayerPrefs.SetString("Aintro2", "Aintro2");
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
