using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogoScene : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.LoadScene("FirstScreen", LoadSceneMode.Single);
    }
}
