using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

public class PauseScene4 : MonoBehaviour
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

    Respawn respawn;
    public bool checkClick = false;

    public GameObject warningPanel;
    Movement4 mov;

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
        respawn = player.GetComponent<Respawn>();
        warningPanel.SetActive(false);
        mov = player.GetComponent<Movement4>();
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
        Time.timeScale = 1f;
        GameIsPaused = false;
        audio.Play();
    }

    public void OnToLastCheckpoint()
    {
        if (mov.grounded == true)
        {
            checkClick = true;
            Time.timeScale = 1f;
            player.transform.position = respawn.currentCheckpoint.transform.position;
            pauseMenuUI.SetActive(false);
            GameIsPaused = false;
            audio.Play();
            StartCoroutine(OffCheck());
        }
        else
        {
            warningPanel.SetActive(true);
        }
    }
    IEnumerator OffCheck()
    {
        yield return new WaitForSeconds(0.2f);
        checkClick = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
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
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
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
