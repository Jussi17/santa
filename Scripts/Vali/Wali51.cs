using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wali51 : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.LoadScene("Level5", LoadSceneMode.Single);
    }
}
