using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelHardi : MonoBehaviour
{
    public GameObject Panel;
    public GameObject PanelEasy;

    public void ClosePanel()
    {
        PlayerPrefs.SetString("Hardi", "Hardi");
        Panel.SetActive(false);
    }
    public void ClosePanelEasy()
    {
        PlayerPrefs.SetString("Easi", "Easi");
        PanelEasy.SetActive(false);
    }
}
