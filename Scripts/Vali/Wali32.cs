using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wali32 : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.LoadScene("Level3 1", LoadSceneMode.Single);
    }
}
