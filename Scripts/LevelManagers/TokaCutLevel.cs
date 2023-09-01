using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TokaCutLevel : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.LoadScene("Level3", LoadSceneMode.Single);
    }
}

