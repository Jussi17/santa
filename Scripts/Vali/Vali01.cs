using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vali01 : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.LoadScene("Intro2", LoadSceneMode.Single);
    }
}
