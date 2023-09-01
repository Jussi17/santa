using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackDiffi : MonoBehaviour
{
    public GameObject normalButton;
    public GameObject hardButton;
    public Text normalText;
    public Text hardText;
    public Text brutalText;

    public void OnBackClick()
    {
        PlayerPrefs.DeleteKey("Difficulty");
        normalButton.GetComponent<Image>().color = Color.white;
        hardButton.GetComponent<Image>().color = Color.white;
        normalText.color = Color.red;
        hardText.color = Color.red;
        brutalText.color = Color.red;
    }
}
