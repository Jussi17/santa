using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wali81 : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.LoadScene("Level8", LoadSceneMode.Single);
    }
}
