using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wali12 : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.LoadScene("Level1 1", LoadSceneMode.Single);
    }
}
