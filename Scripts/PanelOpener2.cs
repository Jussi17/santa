using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener2 : MonoBehaviour
{
    public GameObject Panel;

    public void OpenPanel()
    {
        if (Panel != null)
        {
            Panel.SetActive(true);
        }
    }

    public void ClosePanel()
    {
        Panel.SetActive(false);
    }

}
