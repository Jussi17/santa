using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCutit : MonoBehaviour
{
    public GameObject OptionsPanel;

    void Update()
    {
        if (PlayerPrefs.HasKey("Cutti"))
        {
            OptionsPanel.SetActive(true);
        }
    }

    public void onBackClick()
    {
        PlayerPrefs.DeleteKey("Cutti");
    }
}
