using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EkaCutLevelManager : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.LoadScene("Level2", LoadSceneMode.Single);
    }
}
