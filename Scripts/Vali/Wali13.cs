using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wali13 : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.LoadScene("Level1 2", LoadSceneMode.Single);
    }
}
