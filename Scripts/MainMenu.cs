using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;


public class MainMenu : MonoBehaviour
{
    public GameObject contButton;
    public GameObject panelVeri;
    public GameObject panelOutfit;
    public GameObject panelUpgrade;
    public GameObject upgradeButton;
    public GameObject panelPink;
    public GameObject panelBlue;
    public GameObject panelOrange;
    public GameObject panelGreen;
    public GameObject panelPurple;
    public GameObject panelBrutal;
    public GameObject panelHard;
    public GameObject panelEasy;
    [SerializeField] private AudioSource selectSound;
    public Coins kolikot;
    public GameObject hynat;
    public GameObject coinPanel;
    public DeadCounter deadCounter;
    public GameObject delaukset;
    [SerializeField] private AudioSource clickSound;
    public Text PlayText;
    public Text ContinueText;
    public Text OptionsText;
    public Text QuitText;
    public Text sataText;
    public Text sataHardText;
    public Text sataBrutalText;
    public GameObject playButton;
    public GameObject optButton;
    public GameObject quitButton;
    public Image crownEasy;
    public Image crownNormal;
    public Image crownHard;
    public Image crownBrutal;
    private bool onContClick = false;
    public Image coinImage;


    private void Start()
    {
        kolikot = hynat.GetComponent<Coins>();
        deadCounter = delaukset.GetComponent<DeadCounter>();
        sataText.enabled = false;
        sataHardText.enabled = false;
        sataBrutalText.enabled = false;
        crownNormal.enabled = false;
        crownHard.enabled = false;
        crownBrutal.enabled = false;
        crownEasy.enabled = false;
        if (PlayerPrefs.HasKey("SantaRed"))
        {
            coinImage.GetComponent<Image>().color = Color.red;
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            coinImage.GetComponent<Image>().color = new Color(0.9339623f, 0.6643468f, 0.6643468f, 1);
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            coinImage.GetComponent<Image>().color = Color.blue;
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            coinImage.GetComponent<Image>().color = new Color(1, 0.4721608f, 0, 1);
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            coinImage.GetComponent<Image>().color = new Color(0.6713271f, 0.8396226f, 0.2487184f, 1);
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            coinImage.GetComponent<Image>().color = new Color(0.8679245f, 0.02783903f, 0.7530679f, 1);
        }
    }

    private void Update()
    {
        if (!PlayerPrefs.HasKey("LevelSaved"))
        {
            contButton.GetComponent<Image>().color = Color.gray;
        }
        if (PlayerPrefs.HasKey("Upgraded"))
        {
            upgradeButton.SetActive(false);
        }
        if (PlayerPrefs.HasKey("SataEasy"))
        {
            crownEasy.enabled = true;
            if (!PlayerPrefs.HasKey("Easi"))
            {
                panelEasy.SetActive(true);
            }
        }
        if (PlayerPrefs.HasKey("Sata") && !PlayerPrefs.HasKey("SataHard"))
        {
            if (!PlayerPrefs.HasKey("Hardi"))
            {
                panelHard.SetActive(true);
            }
            sataText.enabled = true;
            crownNormal.enabled = true;
            crownEasy.enabled = true;
            sataText.color = Color.yellow;
            playButton.GetComponent<Image>().color = Color.white;
            optButton.GetComponent<Image>().color = Color.white;
            quitButton.GetComponent<Image>().color = Color.white;
            if (PlayerPrefs.HasKey("LevelSaved"))
            {
                contButton.GetComponent<Image>().color = Color.white;
            }          
        }
        if (PlayerPrefs.HasKey("SataHard") && !PlayerPrefs.HasKey("Sata"))
        {
            if (!PlayerPrefs.HasKey("Brutal"))
            {
                panelBrutal.SetActive(true);
            }
            sataHardText.enabled = true;
            crownHard.enabled = true;
            sataHardText.color = new Color(0,0.5f,1,1);
            playButton.GetComponent<Image>().color = Color.white;
            optButton.GetComponent<Image>().color = Color.white;
            quitButton.GetComponent<Image>().color = Color.white;
            if (PlayerPrefs.HasKey("LevelSaved"))
            {
                contButton.GetComponent<Image>().color = Color.white;
            }
        }
        if (PlayerPrefs.HasKey("SataHard") && PlayerPrefs.HasKey("Sata"))
        {
            if (!PlayerPrefs.HasKey("Brutal"))
            {
                panelBrutal.SetActive(true);
            }         
            sataHardText.enabled = true;
            sataText.enabled = true;
            crownHard.enabled = true;
            crownNormal.enabled = true;
            playButton.GetComponent<Image>().color = Color.white;
            optButton.GetComponent<Image>().color = Color.white;
            quitButton.GetComponent<Image>().color = Color.white;
            if (PlayerPrefs.HasKey("LevelSaved"))
            {
                contButton.GetComponent<Image>().color = Color.white;
            }
        }
        if (PlayerPrefs.HasKey("SataHard") && PlayerPrefs.HasKey("Sata") && PlayerPrefs.HasKey("SataBrutal"))
        {
            sataHardText.enabled = true;
            sataText.enabled = true;
            sataBrutalText.enabled = true;
            crownHard.enabled = true;
            crownNormal.enabled = true;
            crownBrutal.enabled = true;
            playButton.GetComponent<Image>().color = Color.black;
            optButton.GetComponent<Image>().color = Color.black;
            quitButton.GetComponent<Image>().color = Color.black;
            if (PlayerPrefs.HasKey("LevelSaved"))
            {
                contButton.GetComponent<Image>().color = Color.black;
            }
        }

        PlayerPrefs.SetInt("coins", kolikot.coins);
        kolikot.coinText.text = "" + PlayerPrefs.GetInt("coins", kolikot.coins);

        if (onContClick == true)
        {
            ContinueText.color = Color.green;
        }
        if (PlayerPrefs.HasKey("SantaRed"))
        {
            coinImage.GetComponent<Image>().color = Color.red;
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            coinImage.GetComponent<Image>().color = new Color(0.9339623f, 0.6643468f, 0.6643468f, 1);
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            coinImage.GetComponent<Image>().color = Color.blue;
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            coinImage.GetComponent<Image>().color = new Color(1, 0.4721608f, 0, 1);
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            coinImage.GetComponent<Image>().color = new Color(0.6713271f, 0.8396226f, 0.2487184f, 1);
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            coinImage.GetComponent<Image>().color = new Color(0.8679245f, 0.02783903f, 0.7530679f, 1);
        }
    }

    public void OnPlayClick()
    {
        PlayerPrefs.DeleteKey("Cutti");
        if (PlayerPrefs.HasKey("LevelSaved"))
        {
            panelVeri.SetActive(true);
        }
        else if(!PlayerPrefs.HasKey("LevelSaved"))
        {
            panelOutfit.SetActive(true);
        }
    }

    public void OnDeleteClick()
    {
        PlayerPrefs.DeleteKey("LevelComplete");
        PlayerPrefs.DeleteKey("LevelComplete1");
        PlayerPrefs.DeleteKey("LevelComplete2");
        PlayerPrefs.DeleteKey("LevelComplete3");
        PlayerPrefs.DeleteKey("LevelComplete4");
        PlayerPrefs.DeleteKey("LevelComplete5");
        PlayerPrefs.DeleteKey("LevelComplete6");
        PlayerPrefs.DeleteKey("LevelComplete7");
        PlayerPrefs.DeleteKey("LevelComplete8");
        PlayerPrefs.DeleteKey("LevelComplete9");
        PlayerPrefs.DeleteKey("LevelComplete10");
        PlayerPrefs.DeleteKey("LevelComplete11");
        PlayerPrefs.DeleteKey("LevelComplete12");
        PlayerPrefs.DeleteKey("LevelComplete13");
        PlayerPrefs.DeleteKey("LevelComplete14");
        PlayerPrefs.DeleteKey("LevelComplete15");
        PlayerPrefs.DeleteKey("LevelComplete16");
        PlayerPrefs.DeleteKey("LevelComplete17");
        PlayerPrefs.DeleteKey("LevelComplete18");
        PlayerPrefs.DeleteKey("LevelComplete19");
        PlayerPrefs.DeleteKey("LevelComplete20");
        PlayerPrefs.DeleteKey("LevelComplete21");
        PlayerPrefs.DeleteKey("LevelComplete22");
        PlayerPrefs.DeleteKey("LevelComplete23");
        PlayerPrefs.DeleteKey("LevelComplete24");
        PlayerPrefs.DeleteKey("LevelComplete25");
        PlayerPrefs.DeleteKey("LevelComplete26");
        PlayerPrefs.DeleteKey("LevelComplete27");
        PlayerPrefs.DeleteKey("LevelComplete28");
        PlayerPrefs.DeleteKey("LevelComplete29");
        PlayerPrefs.DeleteKey("LevelComplete30");
        PlayerPrefs.DeleteKey("LevelComplete31");
        PlayerPrefs.DeleteKey("LevelComplete32");
        PlayerPrefs.DeleteKey("LevelComplete33");
        PlayerPrefs.DeleteKey("Gift1");
        PlayerPrefs.DeleteKey("Gift2");
        PlayerPrefs.DeleteKey("Gift3");
        PlayerPrefs.DeleteKey("Gift4");
        PlayerPrefs.DeleteKey("Gift5");
        PlayerPrefs.DeleteKey("Gift6");
        PlayerPrefs.DeleteKey("Gift7");
        PlayerPrefs.DeleteKey("Gift8");
        PlayerPrefs.DeleteKey("Gift9");
        PlayerPrefs.DeleteKey("Gift10");
        PlayerPrefs.DeleteKey("Gift11");
        PlayerPrefs.DeleteKey("Gift12");
        PlayerPrefs.DeleteKey("Gift13");
        PlayerPrefs.DeleteKey("Gift14");
        PlayerPrefs.DeleteKey("Gift15");
        PlayerPrefs.DeleteKey("Gift16");
        PlayerPrefs.DeleteKey("Gift17");
        PlayerPrefs.DeleteKey("Gift18");
        PlayerPrefs.DeleteKey("Gift19");
        PlayerPrefs.DeleteKey("Gift20");
        PlayerPrefs.DeleteKey("Gift21");
        PlayerPrefs.DeleteKey("Gift22");
        PlayerPrefs.DeleteKey("Gift23");
        PlayerPrefs.DeleteKey("Gift24");
        PlayerPrefs.DeleteKey("Gift25");
        PlayerPrefs.DeleteKey("Gift26");
        PlayerPrefs.DeleteKey("Gift27");
        PlayerPrefs.DeleteKey("Gift28");
        PlayerPrefs.DeleteKey("Gift29");
        PlayerPrefs.DeleteKey("Gift30");
        PlayerPrefs.DeleteKey("Gift31");
        PlayerPrefs.DeleteKey("Gift32");
        PlayerPrefs.DeleteKey("Gift33");
        PlayerPrefs.DeleteKey("Gift34");
        PlayerPrefs.DeleteKey("Gift35");
        PlayerPrefs.DeleteKey("Gift36");
        PlayerPrefs.DeleteKey("Gift37");
        PlayerPrefs.DeleteKey("Gift38");
        PlayerPrefs.DeleteKey("Gift39");
        PlayerPrefs.DeleteKey("Gift40");
        PlayerPrefs.DeleteKey("Gift41");
        PlayerPrefs.DeleteKey("Gift42");
        PlayerPrefs.DeleteKey("Gift43");
        PlayerPrefs.DeleteKey("Gift44");
        PlayerPrefs.DeleteKey("Gift45");
        PlayerPrefs.DeleteKey("Gift46");
        PlayerPrefs.DeleteKey("Gift47");
        PlayerPrefs.DeleteKey("Gift48");
        PlayerPrefs.DeleteKey("gifts");
        PlayerPrefs.DeleteKey("LevelSaved");
        PlayerPrefs.DeleteKey("Finaali");
        PlayerPrefs.DeleteKey("Finaali2");
        PlayerPrefs.DeleteKey("HasPlayed1");
        PlayerPrefs.DeleteKey("HasPlayed2");
        PlayerPrefs.DeleteKey("HasPlayed3");
        PlayerPrefs.DeleteKey("HasPlayed4");
        PlayerPrefs.DeleteKey("HasPlayed5");
        PlayerPrefs.DeleteKey("HasPlayed6");
        PlayerPrefs.DeleteKey("HasPlayed7");
        PlayerPrefs.DeleteKey("HasPlayed8");
        PlayerPrefs.DeleteKey("HasPlayed9");
        PlayerPrefs.DeleteKey("HasPlayed10");
        PlayerPrefs.DeleteKey("HasPlayed11");
        PlayerPrefs.DeleteKey("HasPlayed12");
        PlayerPrefs.DeleteKey("HasPlayed13");
        PlayerPrefs.DeleteKey("HasPlayed13");
        PlayerPrefs.DeleteKey("HasPlayed14");
        PlayerPrefs.DeleteKey("HasPlayed15");
        PlayerPrefs.DeleteKey("HasPlayed16");
        PlayerPrefs.DeleteKey("HasPlayed17");
        PlayerPrefs.DeleteKey("HasPlayed18");
        PlayerPrefs.DeleteKey("HasPlayed19");
        PlayerPrefs.DeleteKey("HasPlayed20");
        PlayerPrefs.DeleteKey("HasPlayed21");
        PlayerPrefs.DeleteKey("HasPlayed22");
        PlayerPrefs.DeleteKey("HasPlayed23");
        PlayerPrefs.DeleteKey("HasPlayed24");
        PlayerPrefs.DeleteKey("HasPlayed25");
        PlayerPrefs.DeleteKey("HasPlayed26");
        PlayerPrefs.DeleteKey("HasPlayed27");
        PlayerPrefs.DeleteKey("HasPlayed28");
        PlayerPrefs.DeleteKey("HasPlayed29");
        PlayerPrefs.DeleteKey("HasPlayed30");
        PlayerPrefs.DeleteKey("HasPlayed31");
        PlayerPrefs.DeleteKey("HasPlayed32");
        PlayerPrefs.DeleteKey("HasPlayed33");
        PlayerPrefs.DeleteKey("HasPlayed34");
        PlayerPrefs.DeleteKey("HasPlayed35");
        PlayerPrefs.DeleteKey("HasPlayed36");
        PlayerPrefs.DeleteKey("HasPlayed37");
        PlayerPrefs.DeleteKey("HasPlayed38");
        PlayerPrefs.DeleteKey("HasPlayed39");
        PlayerPrefs.DeleteKey("HasPlayed40");
        PlayerPrefs.DeleteKey("HasPlayed41");
        PlayerPrefs.DeleteKey("HasPlayed42");
        PlayerPrefs.DeleteKey("HasPlayed43");
        PlayerPrefs.DeleteKey("HasPlayed44");
        PlayerPrefs.DeleteKey("HasPlayed45");
        PlayerPrefs.DeleteKey("HasPlayed46");
        PlayerPrefs.DeleteKey("HasPlayed47");
        PlayerPrefs.DeleteKey("HasPlayed48");
        PlayerPrefs.DeleteKey("Difficulty");
        PlayerPrefs.DeleteKey("CutComplete9");
        PlayerPrefs.DeleteKey("CutCompleteBrutal");
        PlayerPrefs.DeleteKey("CutLast10");
        PlayerPrefs.DeleteKey("1");
        PlayerPrefs.DeleteKey("2");
        PlayerPrefs.DeleteKey("3");
        PlayerPrefs.DeleteKey("4");
        PlayerPrefs.DeleteKey("5");
        PlayerPrefs.DeleteKey("6");
        PlayerPrefs.DeleteKey("7");
        PlayerPrefs.DeleteKey("8");
        PlayerPrefs.DeleteKey("9");
        PlayerPrefs.DeleteKey("10");
        PlayerPrefs.DeleteKey("11");
        PlayerPrefs.DeleteKey("12");
        PlayerPrefs.DeleteKey("13");
        PlayerPrefs.DeleteKey("14");
        PlayerPrefs.DeleteKey("15");
        PlayerPrefs.DeleteKey("16");
        PlayerPrefs.DeleteKey("17");
        PlayerPrefs.DeleteKey("18");
        PlayerPrefs.DeleteKey("19");
        PlayerPrefs.DeleteKey("20");
        PlayerPrefs.DeleteKey("21");
        PlayerPrefs.DeleteKey("22");
        PlayerPrefs.DeleteKey("23");
        PlayerPrefs.DeleteKey("24");
        PlayerPrefs.DeleteKey("25");
        PlayerPrefs.DeleteKey("26");
        PlayerPrefs.DeleteKey("27");
        PlayerPrefs.DeleteKey("28");
        PlayerPrefs.DeleteKey("29");
        PlayerPrefs.DeleteKey("30");
        PlayerPrefs.DeleteKey("31");
        PlayerPrefs.DeleteKey("32");
        PlayerPrefs.DeleteKey("33");
        PlayerPrefs.DeleteKey("34");
        PlayerPrefs.DeleteKey("35");
        PlayerPrefs.DeleteKey("Burned");
        PlayerPrefs.DeleteKey("Laugh");
        PlayerPrefs.DeleteKey("LaughHah");
        PlayerPrefs.DeleteKey("Lintu");
        PlayerPrefs.DeleteKey("Salama");
        PlayerPrefs.DeleteKey("Salama1");
        PlayerPrefs.DeleteKey("ScaryOff");
        PlayerPrefs.DeleteKey("KuusiOff");
        PlayerPrefs.DeleteKey("CandyOff");
        PlayerPrefs.DeleteKey("Boxing");
        PlayerPrefs.DeleteKey("UfoGone");
        PlayerPrefs.DeleteKey("EndFireworks");
        PlayerPrefs.DeleteKey("KuusiChange");
        PlayerPrefs.DeleteKey("UfoVeks");
        PlayerPrefs.DeleteKey("Club");
        PlayerPrefs.DeleteKey("UfoRise");
        PlayerPrefs.DeleteKey("JokeOver");
        PlayerPrefs.DeleteKey("SnowDrop");
        PlayerPrefs.DeleteKey("BallOff");
        PlayerPrefs.DeleteKey("BeatGame");
        PlayerPrefs.DeleteKey("TreeFall");
        PlayerPrefs.DeleteKey("Soinut");
        PlayerPrefs.DeleteKey("Hat");
        PlayerPrefs.DeleteKey("BoxPois");
        PlayerPrefs.DeleteKey("ExtraHelp");
        PlayerPrefs.DeleteKey("Far");
        PlayerPrefs.DeleteKey("Close");
    }

    public void OnQuitClick()
    {
        //UnityEditor.EditorApplication.isPlaying = false;
        QuitText.color = Color.green;
        Application.Quit();
    }

    public void OnOptionsClick()
    {
        PlayerPrefs.DeleteKey("Cutti");
        PlayText.color = Color.red;
        ContinueText.color = Color.red;
        OptionsText.color = Color.green;
        QuitText.color = Color.red;
    }

    public void OnContinueClick()
    {
        PlayerPrefs.DeleteKey("Cutti");
        if (PlayerPrefs.HasKey("LevelSaved"))
        {
            onContClick = true;
            ContinueText.color = Color.green;
            clickSound.Play();
            string levelToLoad = PlayerPrefs.GetString("LevelSaved");
            SceneManager.LoadScene(levelToLoad);
            Time.timeScale = 1f;
        }
        else
        {
            ChangeColor();
        }
    }

    public void OnUpgradeClick()
    {
        panelUpgrade.SetActive(true);
    }

    public void ChangeColor()
    {
        contButton.GetComponent<Image>().color = Color.gray;
    }

    public void OnConfirmClick()
    {
        if (kolikot.coins >= 5)
        {
            PlayerPrefs.SetString("Upgraded", "Upgraded");
            selectSound.Play();
            kolikot.coins = kolikot.coins -5;
            PlayerPrefs.SetInt("coins", kolikot.coins);
            kolikot.coinText.text = "" + PlayerPrefs.GetInt("coins", kolikot.coins);
            StartCoroutine(ClosePaneeli());
        }
        else
        {
            coinPanel.SetActive(true);
        }
    }

    public void PinkConfirmed()
    {
        if (kolikot.coins >= 1)
        {
            PlayerPrefs.SetString("UnlockedPink", "UnlockedPink");
            selectSound.Play();
            kolikot.coins--;
            PlayerPrefs.SetInt("coins", kolikot.coins);
            kolikot.coinText.text = "" + PlayerPrefs.GetInt("coins", kolikot.coins);
            StartCoroutine(CloseColorPanel());
        }
        else
        {
            coinPanel.SetActive(true);
        }  
    }
    public void BlueConfirmed()
    {
        if (kolikot.coins >= 1)
        {
            PlayerPrefs.SetString("UnlockedBlue", "UnlockedBlue");
            selectSound.Play();
            kolikot.coins = kolikot.coins -1;
            PlayerPrefs.SetInt("coins", kolikot.coins);
            kolikot.coinText.text = "" + PlayerPrefs.GetInt("coins", kolikot.coins);
            StartCoroutine(CloseColorPanel());
        }
        else
        {
            coinPanel.SetActive(true);
        }
    }
    public void OrangeConfirmed()
    {
        if (kolikot.coins >= 1)
        {
            PlayerPrefs.SetString("UnlockedOrange", "UnlockedOrange");
            selectSound.Play();
            kolikot.coins = kolikot.coins - 1;
            PlayerPrefs.SetInt("coins", kolikot.coins);
            kolikot.coinText.text = "" + PlayerPrefs.GetInt("coins", kolikot.coins);
            StartCoroutine(CloseColorPanel());
        }
        else
        {
            coinPanel.SetActive(true);
        }
    }
    public void GreenConfirmed()
    {
        if (kolikot.coins >= 1)
        {
            PlayerPrefs.SetString("UnlockedGreen", "UnlockedGreen");
            selectSound.Play();
            kolikot.coins = kolikot.coins - 1;
            PlayerPrefs.SetInt("coins", kolikot.coins);
            kolikot.coinText.text = "" + PlayerPrefs.GetInt("coins", kolikot.coins);
            StartCoroutine(CloseColorPanel());
        }
        else
        {
            coinPanel.SetActive(true);
        }
    }
    public void PurpleConfirmed()
    {
        if (kolikot.coins >= 1)
        {
            PlayerPrefs.SetString("UnlockedPurple", "UnlockedPurple");
            selectSound.Play();
            kolikot.coins = kolikot.coins - 1;
            PlayerPrefs.SetInt("coins", kolikot.coins);
            kolikot.coinText.text = "" + PlayerPrefs.GetInt("coins", kolikot.coins);
            StartCoroutine(CloseColorPanel());
        }
        else
        {
            coinPanel.SetActive(true);
        }
    }

    public void OnNollaaDeathsClick()
    {
        PlayerPrefs.SetInt("deaths", deadCounter.deaths = 0);
    }

    IEnumerator ClosePaneeli()
    {
        yield return new WaitForSeconds(1.2f);
        panelUpgrade.SetActive(false);
    }
    IEnumerator CloseColorPanel()
    {
        yield return new WaitForSeconds(1.2f);
        panelPink.SetActive(false);
        panelBlue.SetActive(false);
        panelOrange.SetActive(false);
        panelGreen.SetActive(false);
        panelPurple.SetActive(false);
    }
}
