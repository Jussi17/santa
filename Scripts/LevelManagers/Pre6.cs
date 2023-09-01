using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pre6 : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.LoadScene("Level7", LoadSceneMode.Single);
    }
}

