using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseCoin : MonoBehaviour
{
    public GameObject panelCoin;
    public GameObject panelOutfit;
    public GameObject buttonCoin;

    void Update()
    {
        if (panelOutfit.activeInHierarchy)
        {        
            if (PlayerPrefs.HasKey("SantaRed"))
            {
                buttonCoin.GetComponent<Image>().color = Color.red;
            }
            if (PlayerPrefs.HasKey("SantaPink"))
            {
                buttonCoin.GetComponent<Image>().color = new Color(0.9339623f, 0.6643468f, 0.6643468f, 1);
            }
            if (PlayerPrefs.HasKey("SantaBlue"))
            {
                buttonCoin.GetComponent<Image>().color = Color.blue;
            }
            if (PlayerPrefs.HasKey("SantaOrange"))
            {
                buttonCoin.GetComponent<Image>().color = new Color(1, 0.4721608f, 0, 1);
            }
            if (PlayerPrefs.HasKey("SantaGreen"))
            {
                buttonCoin.GetComponent<Image>().color = new Color(0.6713271f, 0.8396226f, 0.2487184f, 1);
            }
            if (PlayerPrefs.HasKey("SantaPurple"))
            {
                buttonCoin.GetComponent<Image>().color = new Color(0.8679245f, 0.02783903f, 0.7530679f, 1);
            }
        }
        if (!panelOutfit.activeInHierarchy)
        {
            buttonCoin.GetComponent<Image>().color = Color.black;
        }
    }

    public void OnCoinClick()
    {
        panelCoin.SetActive(true);
    }
}
