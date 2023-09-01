using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OverLevel90 : MonoBehaviour
{
    public GameObject Panel;
    public Text playText;
    public Text loadingText;

    private void Start()
    {
        loadingText.enabled = false;
    }

    public void OnPlayClick()
    {
        if (PlayerPrefs.HasKey("Upgraded"))
        {
            loadingText.enabled = true;
            playText.color = Color.green;
            SceneManager.LoadScene("Level90", LoadSceneMode.Single);
        }
        if (!PlayerPrefs.HasKey("Upgraded"))
        {
            playText.color = Color.green;
            SceneManager.LoadScene("Wali91", LoadSceneMode.Single);
        }
    }

    public void OnBackClick()
    {
        Panel.SetActive(false);
    }

}
