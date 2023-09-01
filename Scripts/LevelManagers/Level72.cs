using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level72 : MonoBehaviour
{
    private void OnEnable()
    {
        PlayerPrefs.SetString("AcutChase", "AcutChase");
        if (PlayerPrefs.HasKey("Cutti"))
        {
            SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
        }
        if (!PlayerPrefs.HasKey("Cutti"))
        {
            SceneManager.LoadScene("Cut8", LoadSceneMode.Single);
        }
    }
}