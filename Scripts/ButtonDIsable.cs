using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonDIsable : MonoBehaviour
{
    private Button button;
    void Start()
    {
        button = GetComponent<Button>();
    }

    void Update()
    {
        if (PlayerPrefs.HasKey("Upgraded"))
        {
            button.enabled = false;
        }
    }
}
