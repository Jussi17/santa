using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisOver : MonoBehaviour
{
    public GameObject closeButton;
    public GameObject normalButton;
    public GameObject farButton;

    private void Update()
    {
        if (PlayerPrefs.HasKey("Close"))
        {
            closeButton.GetComponent<Image>().color = Color.green;
            normalButton.GetComponent<Image>().color = Color.red;
            farButton.GetComponent<Image>().color = Color.red;
        }
        if (PlayerPrefs.HasKey("Far"))
        {
            closeButton.GetComponent<Image>().color = Color.red;
            normalButton.GetComponent<Image>().color = Color.red;
            farButton.GetComponent<Image>().color = Color.green;
        }
        if (!PlayerPrefs.HasKey("Close") && !PlayerPrefs.HasKey("Far"))
        {
            closeButton.GetComponent<Image>().color = Color.red;
            normalButton.GetComponent<Image>().color = Color.green;
            farButton.GetComponent<Image>().color = Color.red;
        }
    }

    public void OnCloseClick()
    {
        PlayerPrefs.SetString("Close", "Close");
        PlayerPrefs.DeleteKey("Far");
    }
    public void OnNormalClick()
    {
        PlayerPrefs.DeleteKey("Far");
        PlayerPrefs.DeleteKey("Close");
    }
    public void OnFarClick()
    {
        PlayerPrefs.SetString("Far", "Far");
        PlayerPrefs.DeleteKey("Close");
    }
}
