using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro2Script : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.LoadScene("Level1", LoadSceneMode.Single);
    }
}
