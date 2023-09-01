using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wali52 : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.LoadScene("Level5.1", LoadSceneMode.Single);
    }
}
