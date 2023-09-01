using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Helppi : MonoBehaviour
{
    public GameObject panel;
    public Text tooHardText;
    public Text yesText;
    public Text noText;
    public Button yesButton;
    public Button noButton;
    public AudioSource clickSound;

    private void Update()
    {
        if (PlayerPrefs.HasKey("ExtraHelp"))
        {
            yesText.color = Color.white;
            noText.color = Color.white;
            yesButton.GetComponent<Image>().color = Color.green;
            noButton.GetComponent<Image>().color = Color.red;
        }
        if (!PlayerPrefs.HasKey("ExtraHelp"))
        {
            yesText.color = Color.white;
            noText.color = Color.white;
            yesButton.GetComponent<Image>().color = Color.red;
            noButton.GetComponent<Image>().color = Color.green;
        }
        if (panel.activeInHierarchy)
        {
            PlayerPrefs.SetString("Avattu", "Avattu");
        }
        if (PlayerPrefs.HasKey("Avattu"))
        {
            tooHardText.text = "";
        }
    }
    public void OnAddExtraHelp()
    {
        PlayerPrefs.SetString("ExtraHelp", "ExtraHelp");
        Debug.Log("Painat nappia");
        clickSound.Play(); 
        StartCoroutine(ClosePanel());
    }
    public void OnRemoveHelpClick()
    {
        PlayerPrefs.DeleteKey("ExtraHelp");
    }

    IEnumerator ClosePanel()
    {
        yield return new WaitForSeconds(0.6f);
        panel.SetActive(false);
    }
}
