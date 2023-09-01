using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class PauseMenu90 : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    public AudioSource audio1;
    public AudioSource audio2;
    public AudioSource audio3;
    public AudioSource audio4;
    public AudioSource audio5;
    public AudioSource audio6;
    public AudioSource audio7;
    public AudioListener audioList;
    public AudioListener audioList2;
    public AudioListener audioList3;

    public GameObject red1;
    public GameObject red2;
    public GameObject red3;
    public GameObject red4;
    public GameObject red5;
    public GameObject red6;
    public GameObject red7;

    public GameObject pink1;
    public GameObject pink2;
    public GameObject pink3;
    public GameObject pink4;
    public GameObject pink5;
    public GameObject pink6;
    public GameObject pink7;

    public GameObject blue1;
    public GameObject blue2;
    public GameObject blue3;
    public GameObject blue4;
    public GameObject blue5;
    public GameObject blue6;
    public GameObject blue7;

    public GameObject orange1;
    public GameObject orange2;
    public GameObject orange3;
    public GameObject orange4;
    public GameObject orange5;
    public GameObject orange6;
    public GameObject orange7;

    public GameObject green1;
    public GameObject green2;
    public GameObject green3;
    public GameObject green4;
    public GameObject green5;
    public GameObject green6;
    public GameObject green7;

    public GameObject purple1;
    public GameObject purple2;
    public GameObject purple3;
    public GameObject purple4;
    public GameObject purple5;
    public GameObject purple6;
    public GameObject purple7;

    void Update()
    {
        if (CrossPlatformInputManager.GetButtonDown("Pause"))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        audioList.enabled = true;
        audioList2.enabled = true;
        audioList3.enabled = true;
        if (red1.activeInHierarchy || pink1.activeInHierarchy || blue1.activeInHierarchy || orange1.activeInHierarchy || green1.activeInHierarchy || purple1.activeInHierarchy)
        {
            audio1.Play();
        }
        if (red2.activeInHierarchy || pink2.activeInHierarchy || blue2.activeInHierarchy || orange2.activeInHierarchy || green2.activeInHierarchy || purple2.activeInHierarchy)
        {
            audio2.Play();
        }
        if (red3.activeInHierarchy || pink3.activeInHierarchy || blue3.activeInHierarchy || orange3.activeInHierarchy || green3.activeInHierarchy || purple3.activeInHierarchy)
        {
            audio3.Play();
        }
        if (red4.activeInHierarchy || pink4.activeInHierarchy || blue4.activeInHierarchy || orange4.activeInHierarchy || green4.activeInHierarchy || purple4.activeInHierarchy)
        {
            audio4.Play();
        }
        if (red5.activeInHierarchy || pink5.activeInHierarchy || blue5.activeInHierarchy || orange5.activeInHierarchy || green5.activeInHierarchy || purple5.activeInHierarchy)
        {
            audio5.Play();
        }
        if (red6.activeInHierarchy || pink6.activeInHierarchy || blue6.activeInHierarchy || orange6.activeInHierarchy || green6.activeInHierarchy || purple6.activeInHierarchy)
        {
            audio6.Play();
        }
        if (red7.activeInHierarchy || pink7.activeInHierarchy || blue7.activeInHierarchy || orange7.activeInHierarchy || green7.activeInHierarchy || purple7.activeInHierarchy)
        {
            audio7.Play();
        }
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        audioList.enabled = false;
        audioList2.enabled = true;
        audioList3.enabled = true;
        if (red1.activeInHierarchy || pink1.activeInHierarchy || blue1.activeInHierarchy || orange1.activeInHierarchy || green1.activeInHierarchy || purple1.activeInHierarchy)
        {
            audio1.Pause();
        }
        if (red2.activeInHierarchy || pink2.activeInHierarchy || blue2.activeInHierarchy || orange2.activeInHierarchy || green2.activeInHierarchy || purple2.activeInHierarchy)
        {
            audio2.Pause();
        }
        if (red3.activeInHierarchy || pink3.activeInHierarchy || blue3.activeInHierarchy || orange3.activeInHierarchy || green3.activeInHierarchy || purple3.activeInHierarchy)
        {
            audio3.Pause();
        }
        if (red4.activeInHierarchy || pink4.activeInHierarchy || blue4.activeInHierarchy || orange4.activeInHierarchy || green4.activeInHierarchy || purple4.activeInHierarchy)
        {
            audio4.Pause();
        }
        if (red5.activeInHierarchy || pink5.activeInHierarchy || blue5.activeInHierarchy || orange5.activeInHierarchy || green5.activeInHierarchy || purple5.activeInHierarchy)
        {
            audio5.Pause();
        }
        if (red6.activeInHierarchy || pink6.activeInHierarchy || blue6.activeInHierarchy || orange6.activeInHierarchy || green6.activeInHierarchy || purple6.activeInHierarchy)
        {
            audio6.Pause();
        }
        if (red7.activeInHierarchy || pink7.activeInHierarchy || blue7.activeInHierarchy || orange7.activeInHierarchy || green7.activeInHierarchy || purple7.activeInHierarchy)
        {
            audio7.Pause();
        }
    }

    public void WorldMap()
    {
        SceneManager.LoadScene("OverLevel1", LoadSceneMode.Single);
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void RestartLevel()
    {
        if (PlayerPrefs.HasKey("Upgraded"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            pauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
            GameIsPaused = false;
        }
        if (!PlayerPrefs.HasKey("Upgraded"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            pauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
            GameIsPaused = false;
        }
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }

}
