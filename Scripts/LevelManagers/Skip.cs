using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Skip : MonoBehaviour
{
    public GameObject levelManager;

    public void onSkipClick()
    {
        levelManager.SetActive(true);
    }
}
