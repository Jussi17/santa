using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanExtraPlat : MonoBehaviour
{
    public Button yesButton;
    public Button noButton;

    void Update()
    {
        if (PlayerPrefs.HasKey("ExtraHelp"))
        {
            yesButton.GetComponent<Image>().color = Color.green;
            noButton.GetComponent<Image>().color = Color.red;
        }
        if (!PlayerPrefs.HasKey("ExtraHelp"))
        {
            yesButton.GetComponent<Image>().color = Color.red;
            noButton.GetComponent<Image>().color = Color.green;
        }
    }

    public void OnYesClick()
    {
        PlayerPrefs.SetString("ExtraHelp", "ExtraHelp");
    }
    public void OnNoClick()
    {
        PlayerPrefs.DeleteKey("ExtraHelp");
    }
}
