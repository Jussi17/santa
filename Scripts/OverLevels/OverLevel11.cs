using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OverLevel11 : MonoBehaviour
{
    public GameObject Panel;
    private GameObject Player;
    public Text playText;

    public void OnPlayClick()
    {
        if (PlayerPrefs.HasKey("Upgraded"))
        {
            playText.color = Color.green;
            SceneManager.LoadScene("Level1", LoadSceneMode.Single);
            Player = GameObject.FindGameObjectWithTag("Player");
        }
        if (!PlayerPrefs.HasKey("Upgraded"))
        {
            playText.color = Color.green;
            SceneManager.LoadScene("Wali11", LoadSceneMode.Single);
            Player = GameObject.FindGameObjectWithTag("Player");
        }
    }

    public void OnBackClick()
    {
        Panel.SetActive(false);
    }

}
