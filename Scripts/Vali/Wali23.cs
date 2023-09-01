using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wali23 : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.LoadScene("Level2 2", LoadSceneMode.Single);
    }
}
