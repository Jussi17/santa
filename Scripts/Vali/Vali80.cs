using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vali80 : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.LoadScene("Cut8Post", LoadSceneMode.Single);
    }
}
