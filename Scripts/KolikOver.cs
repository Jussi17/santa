using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KolikOver : MonoBehaviour
{
    public Image imageCoin;
    public Button buttonCoin;
    public Image imagePause;
    public Button buttonPause;
    public GameObject pauseCanvas;
    public Image imageCoin2;
    public Text textCoin;
    void Start()
    {
        imageCoin.enabled = false;
        buttonCoin.enabled = false;
        imageCoin2.enabled = false;
        textCoin.enabled = false;
    }

    void Update()
    {
        if (pauseCanvas.activeInHierarchy)
        {
            imageCoin.enabled = true;
            buttonCoin.enabled = true;
            imagePause.enabled = false;
            buttonPause.enabled = false;
            imageCoin2.enabled = true;
            textCoin.enabled = true;
        }
        if (!pauseCanvas.activeInHierarchy)
        {
            imageCoin.enabled = false;
            buttonCoin.enabled = false;
            imagePause.enabled = true;
            buttonPause.enabled = true;
            imageCoin2.enabled = false;
            textCoin.enabled = false;
        }
    }
}
