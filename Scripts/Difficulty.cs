using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class Difficulty : MonoBehaviour
{
    [SerializeField] private AudioSource laughSound;
    public GameObject buttonNormal;
    public GameObject hardButton;
    public GameObject brutalButton;
    public GameObject easyButton;
    public GameObject buttonBack;
    public GameObject buttonOutfit;
    public Text normalText;
    public Text hardText;
    public Text brutalText;
    public Text easyText;
    private bool hasLaughed = false;
    private bool click= false;

    private void Start()
    {
        brutalButton.SetActive(false);
    }
    private void Update()
    {
        if (PlayerPrefs.HasKey("SataHard") && !click)
        {
            brutalButton.SetActive(true);
        }
    }

    public void OnEasyClick()
    {
        click = true;
        PlayerPrefs.SetString("Difficulty", "Easy");
        PlayerPrefs.SetString("ExtraHelp", "ExtraHelp");
        if (!hasLaughed)
        {
            laughSound.Play();
            hasLaughed = true;
        }
        easyButton.GetComponent<Image>().color = Color.green;
        easyText.color = Color.white;
        buttonBack.SetActive(false);
        buttonOutfit.SetActive(false);
        hardButton.SetActive(false);
        brutalButton.SetActive(false);
        buttonNormal.SetActive(false);
        StartCoroutine(NormalLaugh());
    }

    public void OnNormalClick()
    {
        click = true;
        PlayerPrefs.SetString("Difficulty", "Normal");
        if (!hasLaughed)
        {
             laughSound.Play();
             hasLaughed = true;
        }           
        buttonNormal.GetComponent<Image>().color = Color.green;
        normalText.color = Color.white;
        buttonBack.SetActive(false);
        buttonOutfit.SetActive(false);
        hardButton.SetActive(false);
        brutalButton.SetActive(false);
        easyButton.SetActive(false);
        StartCoroutine(NormalLaugh());
    }

    public void OnHardClick()
    {
        click = true;
        PlayerPrefs.SetString("Difficulty", "Hard");
        if (!hasLaughed)
        {
            laughSound.Play();
            hasLaughed = true;
        }          
        hardButton.GetComponent<Image>().color = Color.green;
        hardText.color = Color.white;
        buttonBack.SetActive(false);
        buttonOutfit.SetActive(false);
        buttonNormal.SetActive(false);
        brutalButton.SetActive(false);
        easyButton.SetActive(false);
        StartCoroutine(HardLaugh());
    }

    public void OnBrutalClick()
    {
        PlayerPrefs.SetString("Difficulty", "Brutal");
        if (!hasLaughed)
        {
            laughSound.pitch = 0.83f;
            laughSound.Play();
            hasLaughed = true;
        }
        brutalText.color = Color.green;
        buttonBack.SetActive(false);
        hardButton.SetActive(false);
        buttonOutfit.SetActive(false);
        buttonNormal.SetActive(false);
        easyButton.SetActive(false);
        StartCoroutine(HardLaugh());
    }

    IEnumerator NormalLaugh()
    {
        yield return new WaitForSeconds(2.1f);
        SceneManager.LoadScene("Intro", LoadSceneMode.Single);
    }

    IEnumerator HardLaugh()
    {
        yield return new WaitForSeconds(2.8f);
        SceneManager.LoadScene("Intro", LoadSceneMode.Single);
    }
}
