using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wali22 : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.LoadScene("Level2 1", LoadSceneMode.Single);
    }
}
