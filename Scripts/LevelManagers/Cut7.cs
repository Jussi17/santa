using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cut7 : MonoBehaviour
{
    private void OnEnable()
    {
        PlayerPrefs.SetString("Acut8", "Acut8");
        if (PlayerPrefs.HasKey("Upgraded"))
        {
            if (PlayerPrefs.HasKey("Cutti"))
            {
                SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
            }
            if (!PlayerPrefs.HasKey("Cutti"))
            {
                SceneManager.LoadScene("Cut8Post", LoadSceneMode.Single);
            }      
        }
        if (!PlayerPrefs.HasKey("Upgraded"))
        {
            if (PlayerPrefs.HasKey("Cutti"))
            {
                SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
            }
            if (!PlayerPrefs.HasKey("Cutti"))
            {
                SceneManager.LoadScene("Vali8-85", LoadSceneMode.Single);
            }          
        }
    }
}