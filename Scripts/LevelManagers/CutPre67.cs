using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutPre67 : MonoBehaviour
{
    private void OnEnable()
    {
        PlayerPrefs.SetString("AcutPre7", "AcutPre7");
        if (PlayerPrefs.HasKey("Upgraded"))
        {
            if (PlayerPrefs.HasKey("Cutti"))
            {
                SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
            }
            if (!PlayerPrefs.HasKey("Cutti"))
            {
                SceneManager.LoadScene("Cut7-8", LoadSceneMode.Single);
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
                SceneManager.LoadScene("Vali7-8", LoadSceneMode.Single);
            }
        }
    }
}
