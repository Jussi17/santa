using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wali61 : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.LoadScene("Level6", LoadSceneMode.Single);
    }
}
