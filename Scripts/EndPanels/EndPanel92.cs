using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndPanel92 : MonoBehaviour
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
        if (collision.tag == "Player")
        {
            if (Time.timeSinceLevelLoad < 120 && candyCane.foundCandy)
            {
                if (PlayerPrefs.GetString("Difficulty") == "Normal")
                {
                    PlayerPrefs.SetString("UnlockedBlue", "UnlockedBlue");
                }
                if (PlayerPrefs.GetString("Difficulty") == "Hard")
                {
                    PlayerPrefs.SetString("UnlockedGreen", "UnlockedGreen");
                }
                if (PlayerPrefs.GetString("Difficulty") == "Brutal")
                {
                    PlayerPrefs.SetString("Upgraded", "Upgraded");
                }
                PlayerPrefs.SetString("Finaali2", "Finaali2");
                StartCoroutine(PanelShowGood());
            }
            if (Time.timeSinceLevelLoad < 120 && candyCane.foundCandy == false)
            {
                StartCoroutine(PanelCandyShow());
            }
            if (Time.timeSinceLevelLoad >= 120)
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
