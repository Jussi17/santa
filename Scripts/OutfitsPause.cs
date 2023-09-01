using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OutfitsPause : MonoBehaviour
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

    public GameObject outfitPanel;
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

    public GameObject starRed;
    public GameObject starPink;
    public GameObject starBlue;
    public GameObject starOrange;
    public GameObject starGreen;
    public GameObject starPurple;

    private Color redStartColor = Color.red;
    private Color pinkStartColor = new Color(1, 0.5226f, 0.5226f, 1);
    private Color blueStartColor = Color.blue;
    private Color orangeStartColor = new Color(1, 0.4721608f, 0, 1);
    private Color greenStartColor = new Color(0.2814712f, 0.5471698f, 0, 1);
    private Color purpleStartColor = new Color(0.6792453f, 0, 0.516282f, 1);

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
        if (PlayerPrefs.HasKey("SantaRed"))
        {
            redText.color = Color.green;
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
            starRed.SetActive(true);
            starPink.SetActive(false);
            starBlue.SetActive(false);
            starOrange.SetActive(false);
            starGreen.SetActive(false);
            starPurple.SetActive(false);
        }

        if (PlayerPrefs.HasKey("SantaPink"))
        {
            pinkText.color = Color.green;
            redText.color = pinkStartColor;
            blueText.color = pinkStartColor;
            orangeText.color = pinkStartColor;
            greenText.color = pinkStartColor;
            purpleText.color = pinkStartColor;

            blueTextUnlock.color = pinkStartColor;
            orangeTextUnlock.color = pinkStartColor;
            greenTextUnlock.color = pinkStartColor;
            purpleTextUnlock.color = pinkStartColor;
            starRed.SetActive(false);
            starPink.SetActive(true);
            starBlue.SetActive(false);
            starOrange.SetActive(false);
            starGreen.SetActive(false);
            starPurple.SetActive(false);
        }

        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            blueText.color = Color.green;
            redText.color = blueStartColor;
            pinkText.color = blueStartColor;
            orangeText.color = blueStartColor;
            greenText.color = blueStartColor;
            purpleText.color = blueStartColor;

            pinkTextUnlock.color = blueStartColor;
            orangeTextUnlock.color = blueStartColor;
            greenTextUnlock.color = blueStartColor;
            purpleTextUnlock.color = blueStartColor;
            starRed.SetActive(false);
            starPink.SetActive(false);
            starBlue.SetActive(true);
            starOrange.SetActive(false);
            starGreen.SetActive(false);
            starPurple.SetActive(false);
        }

        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            orangeText.color = Color.green;
            redText.color = orangeStartColor;
            pinkText.color = orangeStartColor;
            blueText.color = orangeStartColor;
            greenText.color = orangeStartColor;
            purpleText.color = orangeStartColor;

            pinkTextUnlock.color = orangeStartColor;
            blueTextUnlock.color = orangeStartColor;
            greenTextUnlock.color = orangeStartColor;
            purpleTextUnlock.color = orangeStartColor;
            starRed.SetActive(false);
            starPink.SetActive(false);
            starBlue.SetActive(false);
            starOrange.SetActive(true);
            starGreen.SetActive(false);
            starPurple.SetActive(false);
        }

        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            greenText.color = Color.green;
            redText.color = greenStartColor;
            pinkText.color = greenStartColor;
            blueText.color = greenStartColor;
            orangeText.color = greenStartColor;
            purpleText.color = greenStartColor;

            pinkTextUnlock.color = greenStartColor;
            blueTextUnlock.color = greenStartColor;
            orangeTextUnlock.color = greenStartColor;
            purpleTextUnlock.color = greenStartColor;
            starRed.SetActive(false);
            starPink.SetActive(false);
            starBlue.SetActive(false);
            starOrange.SetActive(false);
            starGreen.SetActive(true);
            starPurple.SetActive(false);
        }

        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            purpleText.color = Color.green;
            redText.color = purpleStartColor;
            pinkText.color = purpleStartColor;
            blueText.color = purpleStartColor;
            orangeText.color = purpleStartColor;
            greenText.color = purpleStartColor;

            pinkTextUnlock.color = purpleStartColor;
            blueTextUnlock.color = purpleStartColor;
            orangeTextUnlock.color = purpleStartColor;
            greenTextUnlock.color = purpleStartColor;
            starRed.SetActive(false);
            starPink.SetActive(false);
            starBlue.SetActive(false);
            starOrange.SetActive(false);
            starGreen.SetActive(false);
            starPurple.SetActive(true);
        }
    }

    public void OnRedClick()
    {
        PlayerPrefs.SetString("SantaRed", "SantaRed");
        if (PlayerPrefs.HasKey("SantaPink") || PlayerPrefs.HasKey("SantaBlue") || PlayerPrefs.HasKey("SantaOrange") || PlayerPrefs.HasKey("SantaGreen") || PlayerPrefs.HasKey("SantaPurple"))
        {
            PlayerPrefs.DeleteKey("SantaPink");
            PlayerPrefs.DeleteKey("SantaBlue");
            PlayerPrefs.DeleteKey("SantaOrange");
            PlayerPrefs.DeleteKey("SantaGreen");
            PlayerPrefs.DeleteKey("SantaPurple");
        }
        StartCoroutine(SantaSelected());
    }

    public void OnPinkCLick()
    {
        PlayerPrefs.SetString("SantaPink", "SantaPink");
        if (PlayerPrefs.HasKey("SantaRed") || PlayerPrefs.HasKey("SantaBlue") || PlayerPrefs.HasKey("SantaOrange") || PlayerPrefs.HasKey("SantaGreen") || PlayerPrefs.HasKey("SantaPurple"))
        {
            PlayerPrefs.DeleteKey("SantaRed");
            PlayerPrefs.DeleteKey("SantaBlue");
            PlayerPrefs.DeleteKey("SantaOrange");
            PlayerPrefs.DeleteKey("SantaGreen");
            PlayerPrefs.DeleteKey("SantaPurple");
        }
        StartCoroutine(SantaSelected());
    }

    public void OnPinkUpgradeClick()
    {
        panelPink.SetActive(true);
    }

    public void OnBlueClick()
    {
        PlayerPrefs.SetString("SantaBlue", "SantaBlue");
        if (PlayerPrefs.HasKey("SantaRed") || PlayerPrefs.HasKey("SantaPink") || PlayerPrefs.HasKey("SantaOrange") || PlayerPrefs.HasKey("SantaGreen") || PlayerPrefs.HasKey("SantaPurple"))
        {
            PlayerPrefs.DeleteKey("SantaRed");
            PlayerPrefs.DeleteKey("SantaPink");
            PlayerPrefs.DeleteKey("SantaOrange");
            PlayerPrefs.DeleteKey("SantaGreen");
            PlayerPrefs.DeleteKey("SantaPurple");
        }
        StartCoroutine(SantaSelected());
    }

    public void OnBlueUpgradeClick()
    {
        panelBlue.SetActive(true);
    }

    public void OnOrangeClick()
    {
        PlayerPrefs.SetString("SantaOrange", "SantaOrange");
        if (PlayerPrefs.HasKey("SantaRed") || PlayerPrefs.HasKey("SantaPink") || PlayerPrefs.HasKey("SantaBlue") || PlayerPrefs.HasKey("SantaGreen") || PlayerPrefs.HasKey("SantaPurple"))
        {
            PlayerPrefs.DeleteKey("SantaRed");
            PlayerPrefs.DeleteKey("SantaPink");
            PlayerPrefs.DeleteKey("SantaBlue");
            PlayerPrefs.DeleteKey("SantaGreen");
            PlayerPrefs.DeleteKey("SantaPurple");
        }
        StartCoroutine(SantaSelected());
    }

    public void OnOrangeUpgradeClick()
    {
        panelOrange.SetActive(true);
    }

    public void OnGreenClick()
    {
        PlayerPrefs.SetString("SantaGreen", "SantaGreen");
        if (PlayerPrefs.HasKey("SantaRed") || PlayerPrefs.HasKey("SantaPink") || PlayerPrefs.HasKey("SantaBlue") || PlayerPrefs.HasKey("SantaOrange") || PlayerPrefs.HasKey("SantaPurple"))
        {
            PlayerPrefs.DeleteKey("SantaRed");
            PlayerPrefs.DeleteKey("SantaPink");
            PlayerPrefs.DeleteKey("SantaBlue");
            PlayerPrefs.DeleteKey("SantaOrange");
            PlayerPrefs.DeleteKey("SantaPurple");
        }
        StartCoroutine(SantaSelected());
    }

    public void OnGreenUpgradeClick()
    {
        panelGreen.SetActive(true);
    }

    public void OnPurpleClick()
    {
        PlayerPrefs.SetString("SantaPurple", "SantaPurple");
        if (PlayerPrefs.HasKey("SantaRed") || PlayerPrefs.HasKey("SantaPink") || PlayerPrefs.HasKey("SantaBlue") || PlayerPrefs.HasKey("SantaOrange") || PlayerPrefs.HasKey("SantaGreen"))
        {
            PlayerPrefs.DeleteKey("SantaRed");
            PlayerPrefs.DeleteKey("SantaPink");
            PlayerPrefs.DeleteKey("SantaBlue");
            PlayerPrefs.DeleteKey("SantaOrange");
            PlayerPrefs.DeleteKey("SantaGreen");
        }
        StartCoroutine(SantaSelected());
    }

    public void OnPurpleUpgradeClick()
    {
        panelPurple.SetActive(true);
    }

    public void OnBackClick()
    {
        outfitPanel.SetActive(false);
    }

    IEnumerator SantaSelected()
    {
        selectSound.Play();
        yield return new WaitForSeconds(1.2f);
        outfitPanel.SetActive(false);
    }
}
