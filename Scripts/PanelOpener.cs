using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{
    public GameObject Panel;
    [SerializeField] private AudioSource clickSound;

    public void OpenPanel()
    {
        if (Panel != null)
        {
            clickSound.Play();
            Panel.SetActive(true);
        }
    }

    public void ClosePanel()
    {
        Panel.SetActive(false);
    }

}
