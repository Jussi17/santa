using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonOpener91 : MonoBehaviour
{
    public GameObject Panel;
    LevelController21 lc;
    public Renderer renderer;
    public GameObject Player;
    public GameObject unlockedText;
    public Image cleared;
    public Text blueOutfit;
    public Text greenOutfit;
    public Text updradeText;
    public Text blue;
    public Text green;
    public Text updrade;

    private void Start()
    {
        lc = GetComponent<LevelController21>();
        unlockedText.SetActive(false);
        cleared.enabled = false;
        blueOutfit.enabled = false;
        greenOutfit.enabled = false;
        updradeText.enabled = false;
        blue.enabled = false;
        green.enabled = false;
        updrade.enabled = false;
    }

    private void Update()
    {

        if (PlayerPrefs.HasKey("LevelComplete33"))
        {
            renderer.GetComponent<SpriteRenderer>().color = Color.yellow;

            if (PlayerPrefs.HasKey("LevelComplete33") && PlayerPrefs.HasKey("Finaali2"))
            {
                renderer.GetComponent<SpriteRenderer>().color = Color.green;
            }
        }
        if (PlayerPrefs.GetString("Difficulty") == "Easy" && !PlayerPrefs.HasKey("UnlockedBlue"))
        {
            blueOutfit.enabled = true;
        }
        if (PlayerPrefs.GetString("Difficulty") == "Easy" && PlayerPrefs.HasKey("UnlockedBlue"))
        {
            unlockedText.SetActive(true);
            blue.enabled = true;
            cleared.enabled = true;
        }
        if (PlayerPrefs.GetString("Difficulty") == "Normal" && !PlayerPrefs.HasKey("UnlockedBlue"))
        {
            blueOutfit.enabled = true;
        }
        if (PlayerPrefs.GetString("Difficulty") == "Normal" && PlayerPrefs.HasKey("UnlockedBlue"))
        {
            unlockedText.SetActive(true);
            blue.enabled = true;
            cleared.enabled = true;
        }
        if (PlayerPrefs.GetString("Difficulty") == "Hard" && !PlayerPrefs.HasKey("UnlockedGreen"))
        {
            greenOutfit.enabled = true;
        }
        if (PlayerPrefs.GetString("Difficulty") == "Hard" && PlayerPrefs.HasKey("UnlockedGreen"))
        {
            unlockedText.SetActive(true);
            green.enabled = true;
            cleared.enabled = true;
        }
        if (PlayerPrefs.GetString("Difficulty") == "Brutal" && !PlayerPrefs.HasKey("Upgraded"))
        {
            updradeText.enabled = true;
        }
        if (PlayerPrefs.GetString("Difficulty") == "Brutal" && PlayerPrefs.HasKey("Upgraded"))
        {
            unlockedText.SetActive(true);
            updrade.enabled = true;
            cleared.enabled = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Panel != null && Time.timeSinceLevelLoad > 0.3f)
        {
            Panel.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Panel.SetActive(false);
    }
}