using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class PauseSleigh : MonoBehaviour
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
    private Rigidbody2D rb;

    private void Start()
    {
        if (PlayerPrefs.HasKey("SantaRed"))
        {
            player = red;
            rb = red.GetComponent<Rigidbody2D>();
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            player = pink;
            rb = pink.GetComponent<Rigidbody2D>();
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            player = blue;
            rb = blue.GetComponent<Rigidbody2D>();
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            player = orange;
            rb = orange.GetComponent<Rigidbody2D>();
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            player = green;
            rb = green.GetComponent<Rigidbody2D>();
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            player = purple;
            rb = purple.GetComponent<Rigidbody2D>();
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
        rb.AddForce(Vector2.right * 10000f);
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
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }

}
