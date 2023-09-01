using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LifeReki : MonoBehaviour
{
    public GameObject redHead;
    public GameObject pinkHead;
    public GameObject blueHead;
    public GameObject orangeHead;
    public GameObject greenHead;
    public GameObject purpleHead;

    public GameObject redFull;
    public GameObject pinkFull;
    public GameObject blueFull;
    public GameObject orangeFull;
    public GameObject greenFull;
    public GameObject purpleFull;

    public GameObject redDead;
    public GameObject pinkDead;
    public GameObject blueDead;
    public GameObject orangeDead;
    public GameObject greenDead;
    public GameObject purpleDead;

    private HealthReki health;
    private bool canDie = true;

    public int lives = 3;
    [SerializeField] public Text lifeText;

    public GameObject panel;
    private bool alreadyDead = false;

    public GameObject tryAgainButton;
    public GameObject noButton;

    public static bool isFading;
    public float FadeTime = 3f;
    public AudioSource audioSource;

    [SerializeField] private AudioSource tryAgainSound;
    [SerializeField] private AudioSource noSound;
    [SerializeField] private AudioSource gameOverSound;

    void Start()
    {
        redHead.SetActive(false);
        pinkHead.SetActive(false);
        blueHead.SetActive(false);
        orangeHead.SetActive(false);
        greenHead.SetActive(false);
        purpleHead.SetActive(false);
        panel.SetActive(false);

        if (PlayerPrefs.HasKey("SantaRed"))
        {
            redHead.SetActive(true);
            health = redFull.GetComponent<HealthReki>();
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            pinkHead.SetActive(true);
            health = pinkFull.GetComponent<HealthReki>();
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            blueHead.SetActive(true);
            health = blueFull.GetComponent<HealthReki>();
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            orangeHead.SetActive(true);
            health = orangeFull.GetComponent<HealthReki>();
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            greenHead.SetActive(true);
            health = greenFull.GetComponent<HealthReki>();
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            purpleHead.SetActive(true);
            health = purpleFull.GetComponent<HealthReki>();
        }
        if (PlayerPrefs.GetString("Difficulty") == "Easy")
        {
            lives = 5;
            lifeText.text = "x " + lives.ToString();
        }
        if (PlayerPrefs.GetString("Difficulty") == "Normal")
        {
            lives = 3;
            lifeText.text = "x " + lives.ToString();
        }
        if (PlayerPrefs.GetString("Difficulty") == "Hard")
        {
            lives = 2;
            lifeText.text = "x " + lives.ToString();
        }
        if (PlayerPrefs.GetString("Difficulty") == "Brutal")
        {
            lives = 1;
            lifeText.text = "x " + lives.ToString();
        }
    }

    IEnumerator Elossa()
    {
        yield return new WaitForSeconds(2.3f);
        canDie = true;
    }

    void Update()
    {
        if (health.dead && canDie && !alreadyDead)
        {
            lives--;
            lifeText.text = "x " + lives.ToString();
            canDie = false;
            StartCoroutine(Elossa());
        }

        if (lives == 1)
        {
            lifeText.color = Color.red;
        }

        if (lives == 0 && !alreadyDead)
        {
            panel.SetActive(true);
            redFull.SetActive(false);
            pinkFull.SetActive(false);
            blueFull.SetActive(false);
            orangeFull.SetActive(false);
            greenFull.SetActive(false);
            purpleFull.SetActive(false);
            if (PlayerPrefs.HasKey("SantaRed"))
            {
                redDead.SetActive(true);
                pinkDead.SetActive(false);
                blueDead.SetActive(false);
                orangeDead.SetActive(false);
                greenDead.SetActive(false);
                purpleDead.SetActive(false);
            }
            if (PlayerPrefs.HasKey("SantaPink"))
            {
                redDead.SetActive(false);
                pinkDead.SetActive(true);
                blueDead.SetActive(false);
                orangeDead.SetActive(false);
                greenDead.SetActive(false);
                purpleDead.SetActive(false);
            }
            if (PlayerPrefs.HasKey("SantaBlue"))
            {
                redDead.SetActive(false);
                pinkDead.SetActive(false);
                blueDead.SetActive(true);
                orangeDead.SetActive(false);
                greenDead.SetActive(false);
                purpleDead.SetActive(false);
            }
            if (PlayerPrefs.HasKey("SantaOrange"))
            {
                redDead.SetActive(false);
                pinkDead.SetActive(false);
                blueDead.SetActive(false);
                orangeDead.SetActive(true);
                greenDead.SetActive(false);
                purpleDead.SetActive(false);
            }
            if (PlayerPrefs.HasKey("SantaGreen"))
            {
                redDead.SetActive(false);
                pinkDead.SetActive(false);
                blueDead.SetActive(false);
                orangeDead.SetActive(false);
                greenDead.SetActive(true);
                purpleDead.SetActive(false);
            }
            if (PlayerPrefs.HasKey("SantaPurple"))
            {
                redDead.SetActive(false);
                pinkDead.SetActive(false);
                blueDead.SetActive(false);
                orangeDead.SetActive(false);
                greenDead.SetActive(false);
                purpleDead.SetActive(true);
            }
            health.enabled = false;
            alreadyDead = true;
            gameOverSound.Play();
            StartCoroutine(FadeOut());
        }
    }

    public void OnTryAgainClick()
    {
        tryAgainSound.Play();
        tryAgainButton.GetComponent<Image>().color = Color.green;
        noButton.SetActive(false);
        StartCoroutine(NewTry());
    }
    IEnumerator NewTry()
    {
        if (PlayerPrefs.HasKey("Upgraded"))
        {
            yield return new WaitForSeconds(2.1f);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (!PlayerPrefs.HasKey("Upgraded"))
        {
            yield return new WaitForSeconds(2.1f);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }

    public void OnNoClick()
    {
        noSound.Play();
        noButton.GetComponent<Image>().color = Color.green;
        tryAgainButton.SetActive(false);
        StartCoroutine(DontTry());
    }
    IEnumerator DontTry()
    {
        yield return new WaitForSeconds(1.2f);
        SceneManager.LoadScene("OverLevel1", LoadSceneMode.Single);
    }


    IEnumerator FadeOut()
    {
        isFading = true;
        float startVolume = audioSource.volume;
        while (audioSource.volume > 0)
        {
            audioSource.volume -= startVolume * Time.deltaTime / FadeTime;
            yield return null;
        }
        audioSource.Stop();
        audioSource.volume = startVolume;
        isFading = false;
    }
}
