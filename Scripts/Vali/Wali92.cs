using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wali92 : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.LoadScene("Level9.1", LoadSceneMode.Single);
    }
}
