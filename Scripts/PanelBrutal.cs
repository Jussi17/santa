using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelBrutal : MonoBehaviour
{
    public GameObject Panel;

    public void ClosePanel()
    {
        PlayerPrefs.SetString("Brutal", "Brutal");
        Panel.SetActive(false);
    }

}
