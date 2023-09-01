using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;


public class MenuSceneOut : MonoBehaviour
{
    public GameObject panelOutfit;
    public GameObject panelPink;
    public GameObject panelBlue;
    public GameObject panelOrange;
    public GameObject panelGreen;
    public GameObject panelPurple;
    [SerializeField] private AudioSource selectSound;
    public Coins kolikot;
    public GameObject hynat;
    public GameObject coinPanel;
    public GameObject upgradeButton;
    public GameObject panelUpgrade;

    private void Start()
    {
        kolikot = hynat.GetComponent<Coins>();
    }

    private void Update()
    {
        PlayerPrefs.SetInt("coins", kolikot.coins);
        kolikot.coinText.text = "" + PlayerPrefs.GetInt("coins", kolikot.coins);

        if (PlayerPrefs.HasKey("Upgraded"))
        {
            upgradeButton.SetActive(false);
        }
    }

    public void OnUpgradeClick()
    {
        panelUpgrade.SetActive(true);
    }

    public void OnConfirmClick()
    {
        if (kolikot.coins >= 5)
        {
            PlayerPrefs.SetString("Upgraded", "Upgraded");
            selectSound.Play();
            kolikot.coins = kolikot.coins - 5;
            PlayerPrefs.SetInt("coins", kolikot.coins);
            kolikot.coinText.text = "" + PlayerPrefs.GetInt("coins", kolikot.coins);
            StartCoroutine(ClosePaneeli());
        }
        else
        {
            coinPanel.SetActive(true);
        }
    }

        IEnumerator ClosePaneeli()
    {
        yield return new WaitForSeconds(1.2f);
        panelUpgrade.SetActive(false);
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
            panelPink.SetActive(false);
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
            kolikot.coins = kolikot.coins - 1;
            PlayerPrefs.SetInt("coins", kolikot.coins);
            kolikot.coinText.text = "" + PlayerPrefs.GetInt("coins", kolikot.coins);
            panelBlue.SetActive(false);
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
            panelOrange.SetActive(false);
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
            panelGreen.SetActive(false);
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
            panelPurple.SetActive(false);
        }
        else
        {
            coinPanel.SetActive(true);
        }
    }
}
