using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PanelCut : MonoBehaviour
{
    public GameObject intro;
    public GameObject intro2;
    public GameObject cut1;
    public GameObject cut2;
    public GameObject cut3;
    public GameObject cutPre4;
    public GameObject cut4;
    public GameObject cut5;
    public GameObject cut6;
    public GameObject cutPre7;
    public GameObject cut7;
    public GameObject cutChase;
    public GameObject cut8;
    public GameObject cutPost8;
    public GameObject cut9;
    public GameObject cut10;
    public GameObject cutSpecial;
    public GameObject cutSpecialBrutal;
    public GameObject cut100;
    public GameObject cut100Brutal;

    public GameObject introImage;
    public GameObject intro2Image;
    public GameObject cut1Image;
    public GameObject cut2Image;
    public GameObject cut3Image;
    public GameObject cutPre4Image;
    public GameObject cut4Image;
    public GameObject cut5Image;
    public GameObject cut6Image;
    public GameObject cutPre7Image;
    public GameObject cut7Image;
    public GameObject cutChaseImage;
    public GameObject cut8Image;
    public GameObject cutPost8Image;
    public GameObject cut9Image;
    public GameObject cut10Image;
    public GameObject cutSpecialImage;
    public GameObject cutSpecialBrutalImage;
    public GameObject cut100Image;
    public GameObject cut100BrutalImage;

    public Text introText;
    public Text intro2Text;
    public Text cut1Text;
    public Text cut2Text;
    public Text cut3Text;
    public Text cutPre4Text;
    public Text cut4Text;
    public Text cut5Text;
    public Text cut6Text;
    public Text cutPre7Text;
    public Text cut7Text;
    public Text cutChaseText;
    public Text cut8Text;
    public Text cutPost8Text;
    public Text cut9Text;
    public Text cut10Text;
    public Text cutSpecialText;
    public Text cutSpecialBrutalText;
    public Text cut100Text;
    public Text cut100BrutalText;


    private void Start()
    {
        intro.SetActive(false);
        intro2.SetActive(false);
        cut1.SetActive(false);
        cut2.SetActive(false);
        cut3.SetActive(false);
        cutPre4.SetActive(false);
        cut4.SetActive(false);
        cut5.SetActive(false);
        cut6.SetActive(false);
        cutPre7.SetActive(false);
        cut7.SetActive(false);
        cutChase.SetActive(false);
        cut8.SetActive(false);
        cutPost8.SetActive(false);
        cut9.SetActive(false);
        cut10.SetActive(false);
        cutSpecial.SetActive(false);
        cutSpecialBrutal.SetActive(false);
        cut100.SetActive(false);
        cut100Brutal.SetActive(false);

        introImage.SetActive(true);
        intro2Image.SetActive(true);
        cut1Image.SetActive(true);
        cut2Image.SetActive(true);
        cut3Image.SetActive(true);
        cutPre4Image.SetActive(true);
        cut4Image.SetActive(true);
        cut5Image.SetActive(true);
        cut6Image.SetActive(true);
        cutPre7Image.SetActive(true);
        cut7Image.SetActive(true);
        cutChaseImage.SetActive(true);
        cut8Image.SetActive(true);
        cutPost8Image.SetActive(true);
        cut9Image.SetActive(true);
        cut10Image.SetActive(true);
        cutSpecialImage.SetActive(true);
        cutSpecialBrutalImage.SetActive(true);
        cut100Image.SetActive(true);
        cut100BrutalImage.SetActive(true);

        if (PlayerPrefs.HasKey("SantaRed"))
        {
            introText.color = Color.red;
            intro2Text.color = Color.red;
            cut1Text.color = Color.red;
            cut2Text.color = Color.red;
            cut3Text.color = Color.red;
            cutPre4Text.color = Color.red;
            cut4Text.color = Color.red;
            cut5Text.color = Color.red;
            cut6Text.color = Color.red;
            cutPre7Text.color = Color.red;
            cut7Text.color = Color.red;
            cutChaseText.color = Color.red;
            cut8Text.color = Color.red;
            cutPost8Text.color = Color.red;
            cut9Text.color = Color.red;
            cut10Text.color = Color.red;
            cutSpecialText.color = Color.red;
            cutSpecialBrutalText.color = Color.red;
            cut100Text.color = Color.red;
            cut100BrutalText.color = Color.red;
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            introText.color = new Color(1, 0.5226f, 0.5226f, 1);
            intro2Text.color = new Color(1, 0.5226f, 0.5226f, 1);
            cut1Text.color = new Color(1, 0.5226f, 0.5226f, 1);
            cut2Text.color = new Color(1, 0.5226f, 0.5226f, 1);
            cut3Text.color = new Color(1, 0.5226f, 0.5226f, 1);
            cutPre4Text.color = new Color(1, 0.5226f, 0.5226f, 1);
            cut4Text.color = new Color(1, 0.5226f, 0.5226f, 1);
            cut5Text.color = new Color(1, 0.5226f, 0.5226f, 1);
            cut6Text.color = new Color(1, 0.5226f, 0.5226f, 1);
            cutPre7Text.color = new Color(1, 0.5226f, 0.5226f, 1);
            cut7Text.color = new Color(1, 0.5226f, 0.5226f, 1);
            cutChaseText.color = new Color(1, 0.5226f, 0.5226f, 1);
            cut8Text.color = new Color(1, 0.5226f, 0.5226f, 1);
            cutPost8Text.color = new Color(1, 0.5226f, 0.5226f, 1);
            cut9Text.color = new Color(1, 0.5226f, 0.5226f, 1);
            cut10Text.color = new Color(1, 0.5226f, 0.5226f, 1);
            cutSpecialText.color = new Color(1, 0.5226f, 0.5226f, 1);
            cutSpecialBrutalText.color = new Color(1, 0.5226f, 0.5226f, 1);
            cut100Text.color = new Color(1, 0.5226f, 0.5226f, 1);
            cut100BrutalText.color = new Color(1, 0.5226f, 0.5226f, 1);
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            introText.color = Color.blue;
            intro2Text.color = Color.blue;
            cut1Text.color = Color.blue;
            cut2Text.color = Color.blue;
            cut3Text.color = Color.blue;
            cutPre4Text.color = Color.blue;
            cut4Text.color = Color.blue;
            cut5Text.color = Color.blue;
            cut6Text.color = Color.blue;
            cutPre7Text.color = Color.blue;
            cut7Text.color = Color.blue;
            cutChaseText.color = Color.blue;
            cut8Text.color = Color.blue;
            cutPost8Text.color = Color.blue;
            cut9Text.color = Color.blue;
            cut10Text.color = Color.blue;
            cutSpecialText.color = Color.blue;
            cutSpecialBrutalText.color = Color.blue;
            cut100Text.color = Color.blue;
            cut100BrutalText.color = Color.blue;
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            introText.color = new Color(1, 0.4721608f, 0, 1);
            intro2Text.color = new Color(1, 0.4721608f, 0, 1);
            cut1Text.color = new Color(1, 0.4721608f, 0, 1);
            cut2Text.color = new Color(1, 0.4721608f, 0, 1);
            cut3Text.color = new Color(1, 0.4721608f, 0, 1);
            cutPre4Text.color = new Color(1, 0.4721608f, 0, 1);
            cut4Text.color = new Color(1, 0.4721608f, 0, 1);
            cut5Text.color = new Color(1, 0.4721608f, 0, 1);
            cut6Text.color = new Color(1, 0.4721608f, 0, 1);
            cutPre7Text.color = new Color(1, 0.4721608f, 0, 1);
            cut7Text.color = new Color(1, 0.4721608f, 0, 1);
            cutChaseText.color = new Color(1, 0.4721608f, 0, 1);
            cut8Text.color = new Color(1, 0.4721608f, 0, 1);
            cutPost8Text.color = new Color(1, 0.4721608f, 0, 1);
            cut9Text.color = new Color(1, 0.4721608f, 0, 1);
            cut10Text.color = new Color(1, 0.4721608f, 0, 1);
            cutSpecialText.color = new Color(1, 0.4721608f, 0, 1);
            cutSpecialBrutalText.color = new Color(1, 0.4721608f, 0, 1);
            cut100Text.color = new Color(1, 0.4721608f, 0, 1);
            cut100BrutalText.color = new Color(1, 0.4721608f, 0, 1);
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            introText.color = new Color(0.2814712f, 0.5471698f, 0, 1);
            intro2Text.color = new Color(0.2814712f, 0.5471698f, 0, 1);
            cut1Text.color = new Color(0.2814712f, 0.5471698f, 0, 1);
            cut2Text.color = new Color(0.2814712f, 0.5471698f, 0, 1);
            cut3Text.color = new Color(0.2814712f, 0.5471698f, 0, 1);
            cutPre4Text.color = new Color(0.2814712f, 0.5471698f, 0, 1);
            cut4Text.color = new Color(0.2814712f, 0.5471698f, 0, 1);
            cut5Text.color = new Color(0.2814712f, 0.5471698f, 0, 1);
            cut6Text.color = new Color(0.2814712f, 0.5471698f, 0, 1);
            cutPre7Text.color = new Color(0.2814712f, 0.5471698f, 0, 1);
            cut7Text.color = new Color(0.2814712f, 0.5471698f, 0, 1);
            cutChaseText.color = new Color(0.2814712f, 0.5471698f, 0, 1);
            cut8Text.color = new Color(0.2814712f, 0.5471698f, 0, 1);
            cutPost8Text.color = new Color(0.2814712f, 0.5471698f, 0, 1);
            cut9Text.color = new Color(0.2814712f, 0.5471698f, 0, 1);
            cut10Text.color = new Color(0.2814712f, 0.5471698f, 0, 1);
            cutSpecialText.color = new Color(0.2814712f, 0.5471698f, 0, 1);
            cutSpecialBrutalText.color = new Color(0.2814712f, 0.5471698f, 0, 1);
            cut100Text.color = new Color(0.2814712f, 0.5471698f, 0, 1);
            cut100BrutalText.color = new Color(0.2814712f, 0.5471698f, 0, 1);
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            introText.color = new Color(0.6792453f, 0, 0.516282f, 1);
            intro2Text.color = new Color(0.6792453f, 0, 0.516282f, 1);
            cut1Text.color = new Color(0.6792453f, 0, 0.516282f, 1);
            cut2Text.color = new Color(0.6792453f, 0, 0.516282f, 1);
            cut3Text.color = new Color(0.6792453f, 0, 0.516282f, 1);
            cutPre4Text.color = new Color(0.6792453f, 0, 0.516282f, 1);
            cut4Text.color = new Color(0.6792453f, 0, 0.516282f, 1);
            cut5Text.color = new Color(0.6792453f, 0, 0.516282f, 1);
            cut6Text.color = new Color(0.6792453f, 0, 0.516282f, 1);
            cutPre7Text.color = new Color(0.6792453f, 0, 0.516282f, 1);
            cut7Text.color = new Color(0.6792453f, 0, 0.516282f, 1);
            cutChaseText.color = new Color(0.6792453f, 0, 0.516282f, 1);
            cut8Text.color = new Color(0.6792453f, 0, 0.516282f, 1);
            cutPost8Text.color = new Color(0.6792453f, 0, 0.516282f, 1);
            cut9Text.color = new Color(0.6792453f, 0, 0.516282f, 1);
            cut10Text.color = new Color(0.6792453f, 0, 0.516282f, 1);
            cutSpecialText.color = new Color(0.6792453f, 0, 0.516282f, 1);
            cutSpecialBrutalText.color = new Color(0.6792453f, 0, 0.516282f, 1);
            cut100Text.color = new Color(0.6792453f, 0, 0.516282f, 1);
            cut100BrutalText.color = new Color(0.6792453f, 0, 0.516282f, 1);
        }
    }

    void Update()
    {
        if (PlayerPrefs.HasKey("Aintro") || PlayerPrefs.HasKey("LevelComplete"))
        {
            intro.SetActive(true);
            introImage.SetActive(false);
        }
        if (PlayerPrefs.HasKey("Aintro2") || PlayerPrefs.HasKey("LevelComplete"))
        {
            intro2.SetActive(true);
            intro2Image.SetActive(false);
        }
        if (PlayerPrefs.HasKey("Acut1") || PlayerPrefs.HasKey("LevelComplete3"))
        {
            cut1.SetActive(true);
            cut1Image.SetActive(false);
        }
        if (PlayerPrefs.HasKey("Acut2") || PlayerPrefs.HasKey("LevelComplete7"))
        {
            cut2.SetActive(true);
            cut2Image.SetActive(false);
        }
        if (PlayerPrefs.HasKey("Acut3") || PlayerPrefs.HasKey("LevelComplete11"))
        {
            cut3.SetActive(true);
            cut3Image.SetActive(false);
        }
        if (PlayerPrefs.HasKey("AcutPre4") || PlayerPrefs.HasKey("LevelComplete15"))
        {
            cutPre4.SetActive(true);
            cutPre4Image.SetActive(false);
        }
        if (PlayerPrefs.HasKey("Acut4") || PlayerPrefs.HasKey("LevelComplete15"))
        {
            cut4.SetActive(true);
            cut4Image.SetActive(false);
        }
        if (PlayerPrefs.HasKey("Acut5") || PlayerPrefs.HasKey("LevelComplete19"))
        {
            cut5.SetActive(true);
            cut5Image.SetActive(false);
        }
        if (PlayerPrefs.HasKey("Acut6") || PlayerPrefs.HasKey("LevelComplete23"))
        {
            cut6.SetActive(true);
            cut6Image.SetActive(false);
        }
        if (PlayerPrefs.HasKey("AcutPre7") || PlayerPrefs.HasKey("LevelComplete27"))
        {
            cutPre7.SetActive(true);
            cutPre7Image.SetActive(false);
        }
        if (PlayerPrefs.HasKey("Acut7") || PlayerPrefs.HasKey("LevelComplete27"))
        {
            cut7.SetActive(true);
            cut7Image.SetActive(false);
        }
        if (PlayerPrefs.HasKey("AcutChase") || PlayerPrefs.HasKey("LevelComplete31"))
        {
            cutChase.SetActive(true);
            cutChaseImage.SetActive(false);
        }
        if (PlayerPrefs.HasKey("Acut8")|| PlayerPrefs.HasKey("LevelComplete31"))
        {
            cut8.SetActive(true);
            cut8Image.SetActive(false);
        }
        if (PlayerPrefs.HasKey("AcutPost8") || PlayerPrefs.HasKey("LevelComplete31"))
        {
            cutPost8.SetActive(true);
            cutPost8Image.SetActive(false);
        }
        if (PlayerPrefs.HasKey("Acut9"))
        {
            cut9.SetActive(true);
            cut9Image.SetActive(false);
        }
        if (PlayerPrefs.HasKey("Acut10"))
        {
            cut10.SetActive(true);
            cut10Image.SetActive(false);
        }
        if (PlayerPrefs.HasKey("AcutSpecial"))
        {
            cutSpecial.SetActive(true);
            cutSpecialImage.SetActive(false);
        }
        if (PlayerPrefs.HasKey("AcutSpecialBrutal"))
        {
            cutSpecialBrutal.SetActive(true);
            cutSpecialBrutalImage.SetActive(false);
        }
        if (PlayerPrefs.HasKey("Acut100"))
        {
            cut100.SetActive(true);
            cut100Image.SetActive(false);
        }
        if (PlayerPrefs.HasKey("Acut100Brutal"))
        {
            cut100Brutal.SetActive(true);
            cut100BrutalImage.SetActive(false);
        }
    }

    public void OnIntroClick()
    {
        introText.color = Color.green;
        PlayerPrefs.SetString("Cutti", "Cutti");
        SceneManager.LoadScene("Intro", LoadSceneMode.Single);
    }

    public void OnIntro2Click()
    {
        intro2Text.color = Color.green;
        PlayerPrefs.SetString("Cutti", "Cutti");
        SceneManager.LoadScene("Intro2", LoadSceneMode.Single);
    }

    public void OnCut1Click()
    {
        cut1Text.color = Color.green;
        PlayerPrefs.SetString("Cutti", "Cutti");
        SceneManager.LoadScene("Cut1-2", LoadSceneMode.Single);
    }

    public void OnCut2Click()
    {
        cut2Text.color = Color.green;
        PlayerPrefs.SetString("Cutti", "Cutti");
        SceneManager.LoadScene("Cut2-3", LoadSceneMode.Single);
    }

    public void OnCut3Click()
    {
        cut3Text.color = Color.green;
        PlayerPrefs.SetString("Cutti", "Cutti");
        SceneManager.LoadScene("Cut3-4", LoadSceneMode.Single);
    }
    public void OnCutPre4Click()
    {
        cutPre4Text.color = Color.green;
        PlayerPrefs.SetString("Cutti", "Cutti");
        SceneManager.LoadScene("CutPre4-5", LoadSceneMode.Single);
    }
    public void OnCut4Click()
    {
        cut4Text.color = Color.green;
        PlayerPrefs.SetString("Cutti", "Cutti");
        SceneManager.LoadScene("Cut4-5", LoadSceneMode.Single);
    }
    public void OnCut5Click()
    {
        cut5Text.color = Color.green;
        PlayerPrefs.SetString("Cutti", "Cutti");
        SceneManager.LoadScene("Cut5-6", LoadSceneMode.Single);
    }
    public void OnCut6Click()
    {
        cut6Text.color = Color.green;
        PlayerPrefs.SetString("Cutti", "Cutti");
        SceneManager.LoadScene("Cut6-7", LoadSceneMode.Single);
    }
    public void OnCutPre7Click()
    {
        cutPre7Text.color = Color.green;
        PlayerPrefs.SetString("Cutti", "Cutti");
        SceneManager.LoadScene("CutPre7-8", LoadSceneMode.Single);
    }
    public void OnCut7Click()
    {
        cut7Text.color = Color.green;
        PlayerPrefs.SetString("Cutti", "Cutti");
        SceneManager.LoadScene("Cut7-8", LoadSceneMode.Single);
    }

    public void OnCutChaseClick()
    {
        cutChaseText.color = Color.green;
        PlayerPrefs.SetString("Cutti", "Cutti");
        SceneManager.LoadScene("Level8.3", LoadSceneMode.Single);
    }

    public void OnCut8Click()
    {
        cut8Text.color = Color.green;
        PlayerPrefs.SetString("Cutti", "Cutti");
        SceneManager.LoadScene("Cut8", LoadSceneMode.Single);
    }
    public void OnCutPost8Click()
    {
        cutPost8Text.color = Color.green;
        PlayerPrefs.SetString("Cutti", "Cutti");
        SceneManager.LoadScene("Cut8Post", LoadSceneMode.Single);
    }
    public void OnCut9Click()
    {
        cut9Text.color = Color.green;
        PlayerPrefs.SetString("Cutti", "Cutti");
        SceneManager.LoadScene("Cut9", LoadSceneMode.Single);
    }
    public void OnCut10Click()
    {
        cut10Text.color = Color.green;
        PlayerPrefs.SetString("Cutti", "Cutti");
        SceneManager.LoadScene("Cut10", LoadSceneMode.Single);
    }

    public void OnCutSpecialClick()
    {
        cutSpecialText.color = Color.green;
        PlayerPrefs.SetString("Cutti", "Cutti");
        SceneManager.LoadScene("Special", LoadSceneMode.Single);
    }
    public void OnCutSpecialBrutalClick()
    {
        cutSpecialBrutalText.color = Color.green;
        PlayerPrefs.SetString("Cutti", "Cutti");
        SceneManager.LoadScene("SpecialBrutal", LoadSceneMode.Single);
    }
    public void OnCutHundredClick()
    {
        cut100Text.color = Color.green;
        PlayerPrefs.SetString("Cutti", "Cutti");
        SceneManager.LoadScene("HundredPercent", LoadSceneMode.Single);
    }
    public void OnCutHundredBrutalClick()
    {
        cut100BrutalText.color = Color.green;
        PlayerPrefs.SetString("Cutti", "Cutti");
        SceneManager.LoadScene("HundredBrutal", LoadSceneMode.Single);
    }
}
