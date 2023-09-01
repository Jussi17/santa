using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutSpecialBrutal : MonoBehaviour
{
    private void OnEnable()
    {
        PlayerPrefs.SetString("AcutSpecialBrutal", "AcutSpecialBrutal");
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
