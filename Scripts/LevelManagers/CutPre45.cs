using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutPre45 : MonoBehaviour
{
    private void OnEnable()
    {
        PlayerPrefs.SetString("AcutPre4", "AcutPre4");
        if (PlayerPrefs.HasKey("Upgraded"))
        {
            if (PlayerPrefs.HasKey("Cutti"))
            {
                SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
            }
            if (!PlayerPrefs.HasKey("Cutti"))
            {
                SceneManager.LoadScene("Cut4-5", LoadSceneMode.Single);
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
                SceneManager.LoadScene("Vali4-5", LoadSceneMode.Single);
            }        
        }
    }
}