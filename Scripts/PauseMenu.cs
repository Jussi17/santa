using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public AudioSource audio;
    public GameObject player;
    public GameObject red;
    public GameObject pink;
    public GameObject blue;
    public GameObject orange;
    public GameObject green;
    public GameObject purple;

    private void Start()
    {
        if (PlayerPrefs.HasKey("SantaRed"))
        {
            player = red;
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            player = pink;
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            player = blue;
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            player = orange;
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            player = green;
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            player = purple;
        }
    }

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
        player.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
        audio.Play();
    }

    void Pause()
    {
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
        if (PlayerPrefs.HasKey("Upgraded"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            pauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
            GameIsPaused = false;
        }
        if (!PlayerPrefs.HasKey("Upgraded"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
            pauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
            GameIsPaused = false;
        }
    }

    public void QuitGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }

}
