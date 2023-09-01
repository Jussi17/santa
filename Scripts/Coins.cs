using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    public int coins = 0;
    [SerializeField] public Text coinText;
    public GameObject coinPanel;
    [SerializeField] private AudioSource coinSound;

    private void Awake()
    {
        coins = PlayerPrefs.GetInt("coins");
        coinText.text = "" + PlayerPrefs.GetInt("coins", coins);
    }
    void Start()
    {
      
    }

    private void Update()
    {
        PlayerPrefs.SetInt("coins", coins);
        coinText.text = "" + PlayerPrefs.GetInt("coins", coins);
    }

    public void OnOneClick()
    {
        coinSound.Play();
        coins++;
        PlayerPrefs.SetInt("coins", coins);
        coinText.text = "" + PlayerPrefs.GetInt("coins", coins);
    }
    public void OnFiveClick()
    {
        coinSound.Play();
        coins = coins +5;
        PlayerPrefs.SetInt("coins", coins);
        coinText.text = "" + PlayerPrefs.GetInt("coins", coins);
    }
}
