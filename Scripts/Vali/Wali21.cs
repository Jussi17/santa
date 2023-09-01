using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wali21 : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.LoadScene("Level2", LoadSceneMode.Single);
    }
}
