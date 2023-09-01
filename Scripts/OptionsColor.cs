using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsColor : MonoBehaviour
{
    public Text creditsText;
    public Text controlsText;
    public Text backText;
    public Text cutText;

    public GameObject redBack;
    public GameObject pinkBack;
    public GameObject blueBack;
    public GameObject orangeBack;
    public GameObject greenBack;
    public GameObject purpleBack;

    public GameObject cutPanel;

    public GameObject cutControls;
    public GameObject cutCredits;

    public AudioSource menuSound;

    private void Awake()
    {
        redBack.SetActive(true);
        pinkBack.SetActive(false);
        blueBack.SetActive(false);
        orangeBack.SetActive(false);
        greenBack.SetActive(false);
        purpleBack.SetActive(false);
        if (PlayerPrefs.HasKey("SantaRed"))
        {
            creditsText.color = Color.red;
            controlsText.color = Color.red;
            backText.color = Color.red;
            cutText.color = Color.red;
            redBack.SetActive(true);
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            creditsText.color = new Color(1, 0.5226f, 0.5226f,1);
            controlsText.color = new Color(1, 0.5226f, 0.5226f, 1);
            backText.color = new Color(1, 0.5226f, 0.5226f, 1);
            cutText.color = new Color(1, 0.5226f, 0.5226f, 1);
            pinkBack.SetActive(true);
            redBack.SetActive(false);
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            creditsText.color = Color.blue;
            controlsText.color = Color.blue;
            backText.color = Color.blue;
            cutText.color = Color.blue;
            blueBack.SetActive(true);
            redBack.SetActive(false);
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            creditsText.color = new Color(1, 0.4721608f, 0, 1);
            controlsText.color = new Color(1, 0.4721608f, 0, 1);
            backText.color = new Color(1, 0.4721608f, 0, 1);
            cutText.color = new Color(1, 0.4721608f, 0, 1);
            orangeBack.SetActive(true);
            redBack.SetActive(false);
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            creditsText.color = new Color(0.2814712f, 0.5471698f, 0, 1);
            controlsText.color = new Color(0.2814712f, 0.5471698f, 0, 1);
            backText.color = new Color(0.2814712f, 0.5471698f, 0, 1);
            cutText.color = new Color(0.2814712f, 0.5471698f, 0, 1);
            greenBack.SetActive(true);
            redBack.SetActive(false);
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            creditsText.color = new Color(0.6792453f, 0, 0.516282f, 1);
            controlsText.color = new Color(0.6792453f, 0, 0.516282f, 1);
            backText.color = new Color(0.6792453f, 0, 0.516282f, 1);
            cutText.color = new Color(0.6792453f, 0, 0.516282f, 1);
            purpleBack.SetActive(true);
            redBack.SetActive(false);
        }
        if (PlayerPrefs.HasKey("Cutti"))
        {
            cutPanel.SetActive(true);
        }
    }

    private void Update()
    {
        if (PlayerPrefs.HasKey("Cutti"))
        {
            if (cutPanel.activeInHierarchy)
            {
                if (PlayerPrefs.HasKey("SantaRed"))
                {
                    creditsText.color = Color.red;
                    cutText.color = Color.green;
                    backText.color = Color.red;
                    controlsText.color = Color.red;
                }
                if (PlayerPrefs.HasKey("SantaPink"))
                {
                    creditsText.color = new Color(1, 0.5226f, 0.5226f, 1);
                    cutText.color = Color.green;
                    backText.color = new Color(1, 0.5226f, 0.5226f, 1);
                    controlsText.color = new Color(1, 0.5226f, 0.5226f, 1);
                }
                if (PlayerPrefs.HasKey("SantaBlue"))
                {
                    creditsText.color = Color.blue;
                    cutText.color = Color.green;
                    backText.color = Color.blue;
                    controlsText.color = Color.blue;
                }
                if (PlayerPrefs.HasKey("SantaOrange"))
                {
                    creditsText.color = new Color(1, 0.4721608f, 0, 1);
                    cutText.color = Color.green;
                    backText.color = new Color(1, 0.4721608f, 0, 1);
                    controlsText.color = new Color(1, 0.4721608f, 0, 1);
                }
                if (PlayerPrefs.HasKey("SantaGreen"))
                {
                    creditsText.color = new Color(0.2814712f, 0.5471698f, 0, 1);
                    cutText.color = Color.green;
                    backText.color = new Color(0.2814712f, 0.5471698f, 0, 1);
                    controlsText.color = new Color(0.2814712f, 0.5471698f, 0, 1);
                }
                if (PlayerPrefs.HasKey("SantaPurple"))
                {
                    creditsText.color = new Color(0.6792453f, 0, 0.516282f, 1);
                    cutText.color = Color.green;
                    backText.color = new Color(0.6792453f, 0, 0.516282f, 1);
                    controlsText.color = new Color(0.6792453f, 0, 0.516282f, 1);
                }
            }
        
        }
    }

    public void OnCreditsClick()
    {
        cutPanel.SetActive(false);
        if (PlayerPrefs.HasKey("SantaRed"))
        {
            creditsText.color = Color.green;
            controlsText.color = Color.red;
            backText.color = Color.red;
            cutText.color = Color.red;
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            creditsText.color = Color.green;
            controlsText.color = new Color(1, 0.5226f, 0.5226f, 1);
            backText.color = new Color(1, 0.5226f, 0.5226f, 1);
            cutText.color = new Color(1, 0.5226f, 0.5226f, 1);
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            creditsText.color = Color.green;
            controlsText.color = Color.blue;
            backText.color = Color.blue;
            cutText.color = Color.blue;
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            creditsText.color = Color.green;
            controlsText.color = new Color(1, 0.4721608f, 0, 1);
            backText.color = new Color(1, 0.4721608f, 0, 1);
            cutText.color = new Color(1, 0.4721608f, 0, 1);
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            creditsText.color = Color.green;
            controlsText.color = new Color(0.2814712f, 0.5471698f, 0, 1);
            backText.color = new Color(0.2814712f, 0.5471698f, 0, 1);
            cutText.color = new Color(0.2814712f, 0.5471698f, 0, 1);
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            creditsText.color = Color.green;
            controlsText.color = new Color(0.6792453f, 0, 0.516282f, 1);
            backText.color = new Color(0.6792453f, 0, 0.516282f, 1);
            cutText.color = new Color(0.6792453f, 0, 0.516282f, 1);
        }
    }
    public void OnControlsClick()
    {
        cutPanel.SetActive(false);
        if (PlayerPrefs.HasKey("SantaRed"))
        {
            creditsText.color = Color.red;
            controlsText.color = Color.green;
            backText.color = Color.red;
            cutText.color = Color.red;
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            creditsText.color = new Color(1, 0.5226f, 0.5226f, 1);
            controlsText.color = Color.green;
            backText.color = new Color(1, 0.5226f, 0.5226f, 1);
            cutText.color = new Color(1, 0.5226f, 0.5226f, 1);
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            creditsText.color = Color.blue;
            controlsText.color = Color.green;
            backText.color = Color.blue;
            cutText.color = Color.blue;
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            creditsText.color = new Color(1, 0.4721608f, 0, 1);
            controlsText.color = Color.green;
            backText.color = new Color(1, 0.4721608f, 0, 1);
            cutText.color = new Color(1, 0.4721608f, 0, 1);
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            creditsText.color = new Color(0.2814712f, 0.5471698f, 0, 1);
            controlsText.color = Color.green;
            backText.color = new Color(0.2814712f, 0.5471698f, 0, 1);
            cutText.color = new Color(0.2814712f, 0.5471698f, 0, 1);
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            creditsText.color = new Color(0.6792453f, 0, 0.516282f, 1);
            controlsText.color = Color.green;
            backText.color = new Color(0.6792453f, 0, 0.516282f, 1);
            cutText.color = new Color(0.6792453f, 0, 0.516282f, 1);
        }
    }

    public void OnCutsceneClick()
    {
        menuSound.Play();
        cutPanel.SetActive(true);
        cutControls.SetActive(false);
        cutCredits.SetActive(false);
        if (PlayerPrefs.HasKey("SantaRed"))
        {
            creditsText.color = Color.red;
            cutText.color = Color.green;
            backText.color = Color.red;
            controlsText.color = Color.red;
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            creditsText.color = new Color(1, 0.5226f, 0.5226f, 1);
            cutText.color = Color.green;
            backText.color = new Color(1, 0.5226f, 0.5226f, 1);
            controlsText.color = new Color(1, 0.5226f, 0.5226f, 1);
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            creditsText.color = Color.blue;
            cutText.color = Color.green;
            backText.color = Color.blue;
            controlsText.color = Color.blue;
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            creditsText.color = new Color(1, 0.4721608f, 0, 1);
            cutText.color = Color.green;
            backText.color = new Color(1, 0.4721608f, 0, 1);
            controlsText.color = new Color(1, 0.4721608f, 0, 1);
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            creditsText.color = new Color(0.2814712f, 0.5471698f, 0, 1);
            cutText.color = Color.green;
            backText.color = new Color(0.2814712f, 0.5471698f, 0, 1);
            controlsText.color = new Color(0.2814712f, 0.5471698f, 0, 1);
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            creditsText.color = new Color(0.6792453f, 0, 0.516282f, 1);
            cutText.color = Color.green;
            backText.color = new Color(0.6792453f, 0, 0.516282f, 1);
            controlsText.color = new Color(0.6792453f, 0, 0.516282f, 1);
        }
    }

    public void OnBackClick()
    {
        cutPanel.SetActive(false);
        if (PlayerPrefs.HasKey("SantaRed"))
        {
            creditsText.color = Color.red;
            controlsText.color = Color.red;
            cutText.color = Color.red;
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            creditsText.color = new Color(1, 0.5226f, 0.5226f, 1);
            controlsText.color = new Color(1, 0.5226f, 0.5226f, 1);
            cutText.color = new Color(1, 0.5226f, 0.5226f, 1);
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            creditsText.color = Color.blue;
            controlsText.color = Color.blue;
            cutText.color = Color.blue;
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            creditsText.color = new Color(1, 0.4721608f, 0, 1);
            controlsText.color = new Color(1, 0.4721608f, 0, 1);
            cutText.color = new Color(1, 0.4721608f, 0, 1);
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            creditsText.color = new Color(0.2814712f, 0.5471698f, 0, 1);
            controlsText.color = new Color(0.2814712f, 0.5471698f, 0, 1);
            cutText.color = new Color(0.2814712f, 0.5471698f, 0, 1);
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            creditsText.color = new Color(0.6792453f, 0, 0.516282f, 1);
            controlsText.color = new Color(0.6792453f, 0, 0.516282f, 1);
            cutText.color = new Color(0.6792453f, 0, 0.516282f, 1);
        }
    }

}
