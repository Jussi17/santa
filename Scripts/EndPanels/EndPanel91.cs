using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndPanel91 : MonoBehaviour
{
    public GameObject panel;
    public GameObject goodText;
    public GameObject badText;
    public GameObject candyText;
    CandyCane candyCane;
    public GameObject candy;

    private void Start()
    {
        candyCane = candy.GetComponent<CandyCane>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" || collision.tag == "Reindeer" || collision.tag == "Sleigh")
        {
            if (Time.timeSinceLevelLoad < 189 && candyCane.foundCandy)
            {
                if (PlayerPrefs.GetString("Difficulty") == "Normal")
                {
                    PlayerPrefs.SetString("UnlockedPink", "UnlockedPink");
                }
                if (PlayerPrefs.GetString("Difficulty") == "Hard")
                {
                    PlayerPrefs.SetString("UnlockedOrange", "UnlockedOrange");
                }
                if (PlayerPrefs.GetString("Difficulty") == "Brutal")
                {
                    PlayerPrefs.SetString("UnlockedPurple", "UnlockedPurple");
                }
                PlayerPrefs.SetString("Finaali", "Finaali");
                StartCoroutine(PanelShowGood());
            }
            if (Time.timeSinceLevelLoad < 189 && candyCane.foundCandy == false)
            {
                StartCoroutine(PanelCandyShow());
            }
            if (Time.timeSinceLevelLoad >= 189)
            {
                StartCoroutine(PanelShowBad());
            }
            
        }
    }
    IEnumerator PanelShowGood()
    {
        yield return new WaitForSeconds(1.5f);
        panel.SetActive(true);
        goodText.SetActive(true);
        badText.SetActive(false);
        candyText.SetActive(false);
    }
    IEnumerator PanelShowBad()
    {
        yield return new WaitForSeconds(1.5f);
        panel.SetActive(true);
        goodText.SetActive(false);
        badText.SetActive(true);
        candyText.SetActive(false);
    }
    IEnumerator PanelCandyShow()
    {
        yield return new WaitForSeconds(1.5f);
        panel.SetActive(true);
        goodText.SetActive(false);
        badText.SetActive(false);
        candyText.SetActive(true);
    }
}
