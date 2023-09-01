using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonOpener90 : MonoBehaviour
{
    public GameObject Panel;
    LevelController21 lc;
    public Renderer renderer;
    public GameObject Player;
    public GameObject unlockedText;
    public Image cleared;
    public Text pinkOutfit;
    public Text orangeOutfit;
    public Text purpleOutfit;
    public Text pink;
    public Text orange;
    public Text purple;

    private void Start()
    {
        lc = GetComponent<LevelController21>();
        unlockedText.SetActive(false);
        cleared.enabled = false;
        pinkOutfit.enabled = false;
        orangeOutfit.enabled = false;
        purpleOutfit.enabled = false;
        pink.enabled = false;
        orange.enabled = false;
        purple.enabled = false;
    }

    private void Update()
    {
        if (PlayerPrefs.HasKey("LevelComplete32"))
        {
            renderer.GetComponent<SpriteRenderer>().color = Color.yellow;

            if (PlayerPrefs.HasKey("LevelComplete32") && PlayerPrefs.HasKey("Finaali"))
            {
                renderer.GetComponent<SpriteRenderer>().color = Color.green;
            }
        }
        if (PlayerPrefs.GetString("Difficulty") == "Easy" && !PlayerPrefs.HasKey("UnlockedPink"))
        {
            pinkOutfit.enabled = true;
        }
        if (PlayerPrefs.GetString("Difficulty") == "Easy" && PlayerPrefs.HasKey("UnlockedPink"))
        {
            unlockedText.SetActive(true);
            pink.enabled = true;
            cleared.enabled = true;
        }
        if (PlayerPrefs.GetString("Difficulty") == "Normal" && !PlayerPrefs.HasKey("UnlockedPink"))
        {
            pinkOutfit.enabled = true;
        }
        if (PlayerPrefs.GetString("Difficulty") == "Normal" && PlayerPrefs.HasKey("UnlockedPink"))
        {
            unlockedText.SetActive(true);
            pink.enabled = true;
            cleared.enabled = true;
        }
        if (PlayerPrefs.GetString("Difficulty") == "Hard" && !PlayerPrefs.HasKey("UnlockedOrange"))
        {
            orangeOutfit.enabled = true;
        }
        if (PlayerPrefs.GetString("Difficulty") == "Hard" && PlayerPrefs.HasKey("UnlockedOrange"))
        {
            unlockedText.SetActive(true);
            orange.enabled = true;
            cleared.enabled = true;
        }
        if (PlayerPrefs.GetString("Difficulty") == "Brutal" && !PlayerPrefs.HasKey("UnlockedPurple"))
        {
            purpleOutfit.enabled = true;
        }
        if (PlayerPrefs.GetString("Difficulty") == "Brutal" && PlayerPrefs.HasKey("UnlockedPurple"))
        {
            unlockedText.SetActive(true);
            purple.enabled = true;
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