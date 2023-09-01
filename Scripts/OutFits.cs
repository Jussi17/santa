using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OutFits : MonoBehaviour
{
    public GameObject santaButtonRed;
    public GameObject santaButtonPink;
    public GameObject santaButtonPinkUnlock;
    public GameObject santaButtonBlue;
    public GameObject santaButtonBlueUnlock;
    public GameObject santaButtonOrange;
    public GameObject santaButtonOrangeUnlock;
    public GameObject santaButtonGreen;
    public GameObject santaButtonGreenUnlock;
    public GameObject santaButtonPurple;
    public GameObject santaButtonPurpleUnlock;
    public GameObject outfitPanel;
    public GameObject panelDiff;
    public GameObject panelPink;
    public GameObject panelBlue;
    public GameObject panelOrange;
    public GameObject panelGreen;
    public GameObject panelPurple;
    [SerializeField] private AudioSource selectSound;

    public GameObject imagePink;
    public GameObject imageBlue;
    public GameObject imageOrange;
    public GameObject imageGreen;
    public GameObject imagePurple;

    public Text redText;
    public Text pinkText;
    public Text blueText;
    public Text orangeText;
    public Text greenText;
    public Text purpleText;

    public Text pinkTextUnlock;
    public Text blueTextUnlock;
    public Text orangeTextUnlock;
    public Text greenTextUnlock;
    public Text purpleTextUnlock;

    Coins coins;
    public GameObject kolikot;
    public bool isSelected = false;

    private Color redStartColor = Color.red;
    private Color pinkStartColor = new Color(1, 0.5226f, 0.5226f, 1);
    private Color blueStartColor = Color.blue;
    private Color orangeStartColor = new Color(1, 0.4721608f, 0, 1);
    private Color greenStartColor = new Color(0.2814712f, 0.5471698f, 0, 1);
    private Color purpleStartColor = new Color(0.6792453f, 0, 0.516282f, 1);

    private void Start()
    {
        coins = kolikot.GetComponent<Coins>();
        redText.color = redStartColor;
        pinkText.color = redStartColor;
        blueText.color = redStartColor;
        orangeText.color = redStartColor;
        greenText.color = redStartColor;
        purpleText.color = redStartColor;

        pinkTextUnlock.color = redStartColor;
        blueTextUnlock.color = redStartColor;
        orangeTextUnlock.color = redStartColor;
        greenTextUnlock.color = redStartColor;
        purpleTextUnlock.color = redStartColor;


        if (PlayerPrefs.HasKey("SantaRed"))
        {
            santaButtonRed.GetComponent<Image>().color = Color.green;
            redText.color = Color.white;
            pinkText.color = redStartColor;
            blueText.color = redStartColor;
            orangeText.color = redStartColor;
            greenText.color = redStartColor;
            purpleText.color = redStartColor;

            pinkTextUnlock.color = redStartColor;
            blueTextUnlock.color = redStartColor;
            orangeTextUnlock.color = redStartColor;
            greenTextUnlock.color = redStartColor;
            purpleTextUnlock.color = redStartColor;
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            santaButtonPink.GetComponent<Image>().color = Color.green;
            redText.color = pinkStartColor;
            pinkText.color = Color.white;
            blueText.color = pinkStartColor;
            orangeText.color = pinkStartColor;
            greenText.color = pinkStartColor;
            purpleText.color = pinkStartColor;

            blueTextUnlock.color = pinkStartColor;
            orangeTextUnlock.color = pinkStartColor;
            greenTextUnlock.color = pinkStartColor;
            purpleTextUnlock.color = pinkStartColor;
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            santaButtonBlue.GetComponent<Image>().color = Color.green;
            redText.color = blueStartColor;
            pinkText.color = blueStartColor;
            blueText.color = Color.white;
            orangeText.color = blueStartColor;
            greenText.color = blueStartColor;
            purpleText.color = blueStartColor;

            pinkTextUnlock.color = blueStartColor;
            orangeTextUnlock.color = blueStartColor;
            greenTextUnlock.color = blueStartColor;
            purpleTextUnlock.color = blueStartColor;
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            santaButtonOrange.GetComponent<Image>().color = Color.green;
            redText.color = orangeStartColor;
            pinkText.color = orangeStartColor;
            blueText.color = orangeStartColor;
            orangeText.color = Color.white;
            greenText.color = orangeStartColor;
            purpleText.color = orangeStartColor;

            pinkTextUnlock.color = orangeStartColor;
            blueTextUnlock.color = orangeStartColor;
            greenTextUnlock.color = orangeStartColor;
            purpleTextUnlock.color = orangeStartColor;
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            santaButtonGreen.GetComponent<Image>().color = Color.green;
            redText.color = greenStartColor;
            pinkText.color = greenStartColor;
            blueText.color = greenStartColor;
            orangeText.color = greenStartColor;
            greenText.color = Color.white;
            purpleText.color = greenStartColor;

            pinkTextUnlock.color = greenStartColor;
            blueTextUnlock.color = greenStartColor;
            orangeTextUnlock.color = greenStartColor;
            purpleTextUnlock.color = greenStartColor;
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            santaButtonPurple.GetComponent<Image>().color = Color.green;
            redText.color = purpleStartColor;
            pinkText.color = purpleStartColor;
            blueText.color = purpleStartColor;
            orangeText.color = purpleStartColor;
            greenText.color = purpleStartColor;
            purpleText.color = Color.white;

            pinkTextUnlock.color = purpleStartColor;
            blueTextUnlock.color = purpleStartColor;
            orangeTextUnlock.color = purpleStartColor;
            greenTextUnlock.color = purpleStartColor;
        }
    }

    private void Update()
    {
        if (!PlayerPrefs.HasKey("UnlockedPink"))
        {
            santaButtonPink.SetActive(false);
            santaButtonPinkUnlock.SetActive(true);
        }
        if (PlayerPrefs.HasKey("UnlockedPink"))
        {
            santaButtonPink.SetActive(true);
            santaButtonPinkUnlock.SetActive(false);
            imagePink.SetActive(false);
        }
        if (!PlayerPrefs.HasKey("UnlockedBlue"))
        {
            santaButtonBlue.SetActive(false);
            santaButtonBlueUnlock.SetActive(true);
        }
        if (PlayerPrefs.HasKey("UnlockedBlue"))
        {
            santaButtonBlue.SetActive(true);
            santaButtonBlueUnlock.SetActive(false);
            imageBlue.SetActive(false);
        }
        if (!PlayerPrefs.HasKey("UnlockedOrange"))
        {
            santaButtonOrange.SetActive(false);
            santaButtonOrangeUnlock.SetActive(true);
        }
        if (PlayerPrefs.HasKey("UnlockedOrange"))
        {
            santaButtonOrange.SetActive(true);
            santaButtonOrangeUnlock.SetActive(false);
            imageOrange.SetActive(false);
        }
        if (!PlayerPrefs.HasKey("UnlockedGreen"))
        {
            santaButtonGreen.SetActive(false);
            santaButtonGreenUnlock.SetActive(true);
        }
        if (PlayerPrefs.HasKey("UnlockedGreen"))
        {
            santaButtonGreen.SetActive(true);
            santaButtonGreenUnlock.SetActive(false);
            imageGreen.SetActive(false);
        }
        if (!PlayerPrefs.HasKey("UnlockedPurple"))
        {
            santaButtonPurple.SetActive(false);
            santaButtonPurpleUnlock.SetActive(true);
        }
        if (PlayerPrefs.HasKey("UnlockedPurple"))
        {
            santaButtonPurple.SetActive(true);
            santaButtonPurpleUnlock.SetActive(false);
            imagePurple.SetActive(false);
        }
        if (PlayerPrefs.HasKey("SantaRed") || PlayerPrefs.HasKey("SantaPink") || PlayerPrefs.HasKey("SantaBlue") || PlayerPrefs.HasKey("SantaOrange") || PlayerPrefs.HasKey("SantaGreen") || PlayerPrefs.HasKey("SantaPurple"))
        {
            if (isSelected)
            {
                StartCoroutine(Proceedi());
            }        
        }
    }

    IEnumerator Proceedi()
    {
        yield return new WaitForSeconds(3);
    }

    public void OnProceedClick()
    {
        panelDiff.SetActive(true);
        outfitPanel.SetActive(false);
    }

    public void OnRedClick()
    {
        isSelected = true;
        PlayerPrefs.SetString("SantaRed", "SantaRed");
        if (PlayerPrefs.HasKey("SantaPink") || PlayerPrefs.HasKey("SantaBlue") || PlayerPrefs.HasKey("SantaOrange") || PlayerPrefs.HasKey("SantaGreen") || PlayerPrefs.HasKey("SantaPurple"))
        {
            PlayerPrefs.DeleteKey("SantaPink");
            PlayerPrefs.DeleteKey("SantaBlue");
            PlayerPrefs.DeleteKey("SantaOrange");
            PlayerPrefs.DeleteKey("SantaGreen");
            PlayerPrefs.DeleteKey("SantaPurple");
        }
        if (PlayerPrefs.HasKey("SantaRed"))
        {
            santaButtonRed.GetComponent<Image>().color = Color.green;
            santaButtonPink.GetComponent<Image>().color = Color.white;
            santaButtonBlue.GetComponent<Image>().color = Color.white;
            santaButtonOrange.GetComponent<Image>().color = Color.white;
            santaButtonGreen.GetComponent<Image>().color = Color.white;
            santaButtonPurple.GetComponent<Image>().color = Color.white;
            redText.color = Color.white;
            pinkText.color = Color.red;
            blueText.color = Color.red;
            orangeText.color = Color.red;
            greenText.color = Color.red;
            purpleText.color = Color.red;
        }
        StartCoroutine(SantaSelected());
    }

    public void OnPinkCLick()
    {
        isSelected = true;
        PlayerPrefs.SetString("SantaPink", "SantaPink");
        if (PlayerPrefs.HasKey("SantaRed") || PlayerPrefs.HasKey("SantaBlue") || PlayerPrefs.HasKey("SantaOrange") || PlayerPrefs.HasKey("SantaGreen") || PlayerPrefs.HasKey("SantaPurple"))
        {
            PlayerPrefs.DeleteKey("SantaRed");
            PlayerPrefs.DeleteKey("SantaBlue");
            PlayerPrefs.DeleteKey("SantaOrange");
            PlayerPrefs.DeleteKey("SantaGreen");
            PlayerPrefs.DeleteKey("SantaPurple");
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            santaButtonPink.GetComponent<Image>().color = Color.green;
            santaButtonRed.GetComponent<Image>().color = Color.white;
            santaButtonBlue.GetComponent<Image>().color = Color.white;
            santaButtonOrange.GetComponent<Image>().color = Color.white;
            santaButtonGreen.GetComponent<Image>().color = Color.white;
            santaButtonPurple.GetComponent<Image>().color = Color.white;
            redText.color = pinkStartColor;
            pinkText.color = Color.white;
            blueText.color = pinkStartColor;
            orangeText.color = pinkStartColor;
            greenText.color = pinkStartColor;
            purpleText.color = pinkStartColor;

            blueTextUnlock.color = pinkStartColor;
            orangeTextUnlock.color = pinkStartColor;
            greenTextUnlock.color = pinkStartColor;
            purpleTextUnlock.color = pinkStartColor;
        }
        StartCoroutine(SantaSelected());
    }

    public void OnPinkUpgradeClick()
    {
        panelPink.SetActive(true);
    }

    public void OnBlueClick()
    {
        isSelected = true;
        PlayerPrefs.SetString("SantaBlue", "SantaBlue");
        if (PlayerPrefs.HasKey("SantaRed") || PlayerPrefs.HasKey("SantaPink") || PlayerPrefs.HasKey("SantaOrange") || PlayerPrefs.HasKey("SantaGreen") || PlayerPrefs.HasKey("SantaPurple"))
        {
            PlayerPrefs.DeleteKey("SantaRed");
            PlayerPrefs.DeleteKey("SantaPink");
            PlayerPrefs.DeleteKey("SantaOrange");
            PlayerPrefs.DeleteKey("SantaGreen");
            PlayerPrefs.DeleteKey("SantaPurple");
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            santaButtonBlue.GetComponent<Image>().color = Color.green;
            santaButtonRed.GetComponent<Image>().color = Color.white;
            santaButtonPink.GetComponent<Image>().color = Color.white;
            santaButtonOrange.GetComponent<Image>().color = Color.white;
            santaButtonGreen.GetComponent<Image>().color = Color.white;
            santaButtonPurple.GetComponent<Image>().color = Color.white;
            redText.color = blueStartColor;
            pinkText.color = blueStartColor;
            blueText.color = Color.white;
            orangeText.color = blueStartColor;
            greenText.color = blueStartColor;
            purpleText.color = blueStartColor;

            pinkTextUnlock.color = blueStartColor;
            orangeTextUnlock.color = blueStartColor;
            greenTextUnlock.color = blueStartColor;
            purpleTextUnlock.color = blueStartColor;
        }
        StartCoroutine(SantaSelected());
    }

    public void OnBlueUpgradeClick()
    {
        panelBlue.SetActive(true);
    }

    public void OnOrangeClick()
    {
        isSelected = true;
        PlayerPrefs.SetString("SantaOrange", "SantaOrange");
        if (PlayerPrefs.HasKey("SantaRed") || PlayerPrefs.HasKey("SantaPink") || PlayerPrefs.HasKey("SantaBlue") || PlayerPrefs.HasKey("SantaGreen") || PlayerPrefs.HasKey("SantaPurple"))
        {
            PlayerPrefs.DeleteKey("SantaRed");
            PlayerPrefs.DeleteKey("SantaPink");
            PlayerPrefs.DeleteKey("SantaBlue");
            PlayerPrefs.DeleteKey("SantaGreen");
            PlayerPrefs.DeleteKey("SantaPurple");
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            santaButtonOrange.GetComponent<Image>().color = Color.green;
            santaButtonRed.GetComponent<Image>().color = Color.white;
            santaButtonPink.GetComponent<Image>().color = Color.white;
            santaButtonBlue.GetComponent<Image>().color = Color.white;
            santaButtonGreen.GetComponent<Image>().color = Color.white;
            santaButtonPurple.GetComponent<Image>().color = Color.white;
            redText.color = orangeStartColor;
            pinkText.color = orangeStartColor;
            blueText.color = orangeStartColor;
            orangeText.color = Color.white;
            greenText.color = orangeStartColor;
            purpleText.color = orangeStartColor;

            pinkTextUnlock.color = orangeStartColor;
            blueTextUnlock.color = orangeStartColor;
            greenTextUnlock.color = orangeStartColor;
            purpleTextUnlock.color = orangeStartColor;
        }
        StartCoroutine(SantaSelected());
    }

    public void OnOrangeUpgradeClick()
    {
        panelOrange.SetActive(true);
    }

    public void OnGreenClick()
    {
        isSelected = true;
        PlayerPrefs.SetString("SantaGreen", "SantaGreen");
        if (PlayerPrefs.HasKey("SantaRed") || PlayerPrefs.HasKey("SantaPink") || PlayerPrefs.HasKey("SantaBlue") || PlayerPrefs.HasKey("SantaOrange") || PlayerPrefs.HasKey("SantaPurple"))
        {
            PlayerPrefs.DeleteKey("SantaRed");
            PlayerPrefs.DeleteKey("SantaPink");
            PlayerPrefs.DeleteKey("SantaBlue");
            PlayerPrefs.DeleteKey("SantaOrange");
            PlayerPrefs.DeleteKey("SantaPurple");
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            santaButtonGreen.GetComponent<Image>().color = Color.green;
            santaButtonRed.GetComponent<Image>().color = Color.white;
            santaButtonPink.GetComponent<Image>().color = Color.white;
            santaButtonBlue.GetComponent<Image>().color = Color.white;
            santaButtonOrange.GetComponent<Image>().color = Color.white;
            santaButtonPurple.GetComponent<Image>().color = Color.white;
            redText.color = greenStartColor;
            pinkText.color = greenStartColor;
            blueText.color = greenStartColor;
            orangeText.color = greenStartColor;
            greenText.color = Color.white;
            purpleText.color = greenStartColor;

            pinkTextUnlock.color = greenStartColor;
            blueTextUnlock.color = greenStartColor;
            orangeTextUnlock.color = greenStartColor;
            purpleTextUnlock.color = greenStartColor;
        }
        StartCoroutine(SantaSelected());
    }

    public void OnGreenUpgradeClick()
    {
        panelGreen.SetActive(true);
    }

    public void OnPurpleClick()
    {
        isSelected = true;
        PlayerPrefs.SetString("SantaPurple", "SantaPurple");
        if (PlayerPrefs.HasKey("SantaRed") || PlayerPrefs.HasKey("SantaPink") || PlayerPrefs.HasKey("SantaBlue") || PlayerPrefs.HasKey("SantaOrange") || PlayerPrefs.HasKey("SantaGreen"))
        {
            PlayerPrefs.DeleteKey("SantaRed");
            PlayerPrefs.DeleteKey("SantaPink");
            PlayerPrefs.DeleteKey("SantaBlue");
            PlayerPrefs.DeleteKey("SantaOrange");
            PlayerPrefs.DeleteKey("SantaGreen");
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            santaButtonPurple.GetComponent<Image>().color = Color.green;
            santaButtonRed.GetComponent<Image>().color = Color.white;
            santaButtonPink.GetComponent<Image>().color = Color.white;
            santaButtonBlue.GetComponent<Image>().color = Color.white;
            santaButtonOrange.GetComponent<Image>().color = Color.white;
            santaButtonGreen.GetComponent<Image>().color = Color.white;
            redText.color = purpleStartColor;
            pinkText.color = purpleStartColor;
            blueText.color = purpleStartColor;
            orangeText.color = purpleStartColor;
            greenText.color = purpleStartColor;
            purpleText.color = Color.white;

            pinkTextUnlock.color = purpleStartColor;
            blueTextUnlock.color = purpleStartColor;
            orangeTextUnlock.color = purpleStartColor;
            greenTextUnlock.color = purpleStartColor;
        }
        StartCoroutine(SantaSelected());
    }

    public void OnPurpleUpgradeClick()
    {
        panelPurple.SetActive(true);
    }

    public void OnBackClick()
    {
        panelDiff.SetActive(false);
        outfitPanel.SetActive(false);
    }

    IEnumerator SantaSelected()
    {
        selectSound.Play();
        yield return new WaitForSeconds(1.2f);
        panelDiff.SetActive(true);
        outfitPanel.SetActive(false);
    }

    public void OnNollaaClick()
    {
        PlayerPrefs.DeleteKey("coins");
        PlayerPrefs.DeleteKey("UnlockedPink");
        PlayerPrefs.DeleteKey("UnlockedBlue");
        PlayerPrefs.DeleteKey("UnlockedOrange");
        PlayerPrefs.DeleteKey("UnlockedGreen");
        PlayerPrefs.DeleteKey("UnlockedPurple");
        PlayerPrefs.DeleteKey("Upgraded");
        PlayerPrefs.DeleteKey("Sata");
        PlayerPrefs.DeleteKey("SataHard");
        PlayerPrefs.DeleteKey("SataBrutal");
        PlayerPrefs.DeleteKey("Finnish");
        PlayerPrefs.DeleteKey("English");
        coins.coins = 0;
        imagePink.SetActive(true);
        imageBlue.SetActive(true);
        imageOrange.SetActive(true);
        imageGreen.SetActive(true);
        imagePurple.SetActive(true);
    }
    public void OnDeleteLv17Click()
    {
        PlayerPrefs.DeleteKey("LevelComplete17");
        PlayerPrefs.DeleteKey("Salama");
        PlayerPrefs.DeleteKey("Salama1");
        PlayerPrefs.DeleteKey("ScaryOff");
        PlayerPrefs.DeleteKey("KuusiOff");
        PlayerPrefs.DeleteKey("CandyOff");
        PlayerPrefs.DeleteKey("Boxing");
        PlayerPrefs.DeleteKey("UfoGone");
        PlayerPrefs.DeleteKey("Finaali2");
        PlayerPrefs.DeleteKey("EndFireworks");
        PlayerPrefs.DeleteKey("KuusiChange");
        PlayerPrefs.DeleteKey("UfoVeks");
        PlayerPrefs.DeleteKey("Club");
        PlayerPrefs.DeleteKey("UfoRise");
        PlayerPrefs.DeleteKey("JokeOver");
        PlayerPrefs.DeleteKey("SnowDrop");
        PlayerPrefs.DeleteKey("BallOff");
        PlayerPrefs.DeleteKey("TreeFall");
        PlayerPrefs.DeleteKey("TooHard");
    }

}
