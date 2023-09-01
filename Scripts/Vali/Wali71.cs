using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wali71 : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.LoadScene("Level7", LoadSceneMode.Single);
    }
}
