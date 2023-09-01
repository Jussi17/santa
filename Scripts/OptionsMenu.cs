using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

public class OptionsMenu : MonoBehaviour
{
    public void OnBackClick()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
}
