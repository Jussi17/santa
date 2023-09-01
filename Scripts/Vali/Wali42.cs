using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wali42 : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.LoadScene("Level4 1", LoadSceneMode.Single);
    }
}
