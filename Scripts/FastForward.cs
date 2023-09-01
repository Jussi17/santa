using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class FastForward : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 1;
    }
    void Update()
    {
        if (CrossPlatformInputManager.GetButtonDown("Ff"))
        {
            Time.timeScale = 2.3f;
        }
        if (CrossPlatformInputManager.GetButtonUp("Ff"))
        {
            Time.timeScale = 1;
        }
    }
}
