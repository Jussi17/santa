using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wali41 : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.LoadScene("Level4", LoadSceneMode.Single);
    }
}
