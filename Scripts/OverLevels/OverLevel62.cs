using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OverLevel62 : MonoBehaviour
{
    public GameObject Panel;
    public Text playText;

    public void OnPlayClick()
    {
        if (PlayerPrefs.HasKey("Upgraded"))
        {
            playText.color = Color.green;
            SceneManager.LoadScene("Level6 1", LoadSceneMode.Single);
        }
        if (!PlayerPrefs.HasKey("Upgraded"))
        {
            playText.color = Color.green;
            SceneManager.LoadScene("Wali62", LoadSceneMode.Single);
        }
    }

    public void OnBackClick()
    {
        Panel.SetActive(false);
    }

}
