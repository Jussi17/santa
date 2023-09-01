using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LanguageScreen : MonoBehaviour
{
    public Text englishText;
    public Text finnishText;
    public GameObject proceedButton;
    public Text prodeedEngText;
    public Text prodeedFinText;
    [SerializeField] private AudioSource MenuClick;

    private void Start()
    {
        proceedButton.SetActive(false);
    }

    void Update()
    {
        if (PlayerPrefs.HasKey("English"))
        {
            englishText.color = Color.green;
            finnishText.color = Color.white;
            proceedButton.SetActive(true);
            prodeedFinText.enabled = false;
            prodeedEngText.enabled = true;
        }
        if (PlayerPrefs.HasKey("Finnish"))
        {
            englishText.color = Color.white;
            finnishText.color = Color.green;
            proceedButton.SetActive(true);
            prodeedEngText.enabled = false;
            prodeedFinText.enabled = true;
        }
    }

    public void OnEnglishClick()
    {
        PlayerPrefs.SetString("English", "English");
        PlayerPrefs.DeleteKey("Finnish");
    }
    public void OnFinnishClick()
    {
        PlayerPrefs.SetString("Finnish", "Finnish");
        PlayerPrefs.DeleteKey("English");
    }
    public void OnProceedClick()
    {
        MenuClick.Play();
        proceedButton.GetComponent<Image>().color = Color.green;
        StartCoroutine(Eteenpain());
    }
    IEnumerator Eteenpain()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
}
