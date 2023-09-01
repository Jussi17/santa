using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vali90 : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.LoadScene("Cut9", LoadSceneMode.Single);
    }
}
