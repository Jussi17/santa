using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wali82 : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.LoadScene("Level8.1", LoadSceneMode.Single);
    }
}
