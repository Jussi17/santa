using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class PauseOver : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public AudioSource audio;
    public GameObject player;
    public GameObject red;
    public GameObject red2;
    public GameObject red3;
    public GameObject red4;
    public GameObject red5;
    public GameObject pink;
    public GameObject pink2;
    public GameObject pink3;
    public GameObject pink4;
    public GameObject pink5;
    public GameObject blue;
    public GameObject blue2;
    public GameObject blue3;
    public GameObject blue4;
    public GameObject blue5;
    public GameObject orange;
    public GameObject orange2;
    public GameObject orange3;
    public GameObject orange4;
    public GameObject orange5;
    public GameObject green;
    public GameObject green2;
    public GameObject green3;
    public GameObject green4;
    public GameObject green5;
    public GameObject purple;
    public GameObject purple2;
    public GameObject purple3;
    public GameObject purple4;
    public GameObject purple5;
    public bool isPaused = false;

    void Update()
    {
        if (PlayerPrefs.HasKey("SantaRed"))
        {
            if (red.activeInHierarchy)
            {
                player = red;
            }
            if (red2.activeInHierarchy)
            {
                player = red2;
            }
            if (red3.activeInHierarchy)
            {
                player = red3;
            }
            if (red4.activeInHierarchy)
            {
                player = red4;
            }
            if (red5.activeInHierarchy)
            {
                player = red5;
            }
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            if (pink.activeInHierarchy)
            {
                player = pink;
            }
            if (pink2.activeInHierarchy)
            {
                player = pink2;
            }
            if (pink3.activeInHierarchy)
            {
                player = pink3;
            }
            if (pink4.activeInHierarchy)
            {
                player = pink4;
            }
            if (pink5.activeInHierarchy)
            {
                player = pink5;
            }

        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            if (blue.activeInHierarchy)
            {
                player = blue;
            }
            if (blue2.activeInHierarchy)
            {
                player = blue2;
            }
            if (blue3.activeInHierarchy)
            {
                player = blue3;
            }
            if (blue4.activeInHierarchy)
            {
                player = blue4;
            }
            if (blue5.activeInHierarchy)
            {
                player = blue5;
            }
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            if (orange.activeInHierarchy)
            {
                player = orange;
            }
            if (orange2.activeInHierarchy)
            {
                player = orange2;
            }
            if (orange3.activeInHierarchy)
            {
                player = orange3;
            }
            if (orange4.activeInHierarchy)
            {
                player = orange4;
            }
            if (orange5.activeInHierarchy)
            {
                player = orange5;
            }
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            if (green.activeInHierarchy)
            {
                player = green;
            }
            if (green2.activeInHierarchy)
            {
                player = green2;
            }
            if (green3.activeInHierarchy)
            {
                player = green3;
            }
            if (green4.activeInHierarchy)
            {
                player = green4;
            }
            if (green5.activeInHierarchy)
            {
                player = green5;
            }
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            if (purple.activeInHierarchy)
            {
                player = purple;
            }
            if (purple2.activeInHierarchy)
            {
                player = purple2;
            }
            if (purple3.activeInHierarchy)
            {
                player = purple3;
            }
            if (purple4.activeInHierarchy)
            {
                player = purple4;
            }
            if (purple5.activeInHierarchy)
            {
                player = purple5;
            }
        }

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
        isPaused = false;
        pauseMenuUI.SetActive(false);
        player.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
        if (audio.isPlaying == false)
        {
            audio.Play();
        }     
    }

    void Pause()
    {
        isPaused = true;
        pauseMenuUI.SetActive(true);
        player.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
        audio.Pause();
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
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }

}
