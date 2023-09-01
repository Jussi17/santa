using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pre7 : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.LoadScene("Level6", LoadSceneMode.Single);
    }
}
