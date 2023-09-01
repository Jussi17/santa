using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LifeLev90 : MonoBehaviour
{
    public GameObject redHead;
    public GameObject pinkHead;
    public GameObject blueHead;
    public GameObject orangeHead;
    public GameObject greenHead;
    public GameObject purpleHead;

    public GameObject redFull1;
    public GameObject redFull2;
    public GameObject redFull3;
    public GameObject redFull4;
    public GameObject redFull5;
    public GameObject redFull6Reki;
    public GameObject redFull7;

    public GameObject pinkFull1;
    public GameObject pinkFull2;
    public GameObject pinkFull3;
    public GameObject pinkFull4;
    public GameObject pinkFull5;
    public GameObject pinkFull6Reki;
    public GameObject pinkFull7;

    public GameObject blueFull1;
    public GameObject blueFull2;
    public GameObject blueFull3;
    public GameObject blueFull4;
    public GameObject blueFull5;
    public GameObject blueFull6Reki;
    public GameObject blueFull7;

    public GameObject orangeFull1;
    public GameObject orangeFull2;
    public GameObject orangeFull3;
    public GameObject orangeFull4;
    public GameObject orangeFull5;
    public GameObject orangeFull6Reki;
    public GameObject orangeFull7;

    public GameObject greenFull1;
    public GameObject greenFull2;
    public GameObject greenFull3;
    public GameObject greenFull4;
    public GameObject greenFull5;
    public GameObject greenFull6Reki;
    public GameObject greenFull7;

    public GameObject purpleFull1;
    public GameObject purpleFull2;
    public GameObject purpleFull3;
    public GameObject purpleFull4;
    public GameObject purpleFull5;
    public GameObject purpleFull6Reki;
    public GameObject purpleFull7;

    public GameObject redDead;
    public GameObject pinkDead;
    public GameObject blueDead;
    public GameObject orangeDead;
    public GameObject greenDead;
    public GameObject purpleDead;

    private Health90 health;
    private HealthReki healthReki;

    public int lives = 3;
    [SerializeField] public Text lifeText;

    public GameObject panel;
    private bool alreadyDead = false;
    private bool canDie = true;

    public GameObject tryAgainButton;
    public GameObject noButton;

    public static bool isFading;
    public float FadeTime = 3f;
    public AudioSource audioSource1;
    public AudioSource audioSource2;
    public AudioSource audioSource3;
    public AudioSource audioSource4;
    public AudioSource audioSource5;
    public AudioSource audioSource6;
    public AudioSource audioSource7;

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
            health = redFull1.GetComponent<Health90>();
            healthReki = redFull6Reki.GetComponent<HealthReki>();
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            pinkHead.SetActive(true);
            health = pinkFull1.GetComponent<Health90>();
            healthReki = pinkFull6Reki.GetComponent<HealthReki>();
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            blueHead.SetActive(true);
            health = blueFull1.GetComponent<Health90>();
            healthReki = blueFull6Reki.GetComponent<HealthReki>();
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            orangeHead.SetActive(true);
            health = orangeFull1.GetComponent<Health90>();
            healthReki = orangeFull6Reki.GetComponent<HealthReki>();
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            greenHead.SetActive(true);
            health = greenFull1.GetComponent<Health90>();
            healthReki = greenFull6Reki.GetComponent<HealthReki>();
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            purpleHead.SetActive(true);
            health = purpleFull1.GetComponent<Health90>();
            healthReki = purpleFull6Reki.GetComponent<HealthReki>();
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

    IEnumerator Delaus()
    {
        yield return new WaitForSeconds(2f);
        canDie = true;
    }

    void Update()
    {
        if (PlayerPrefs.HasKey("SantaRed"))
        {
            if (redFull2.activeInHierarchy)
            {
                redFull1 = redFull2;
                health = redFull2.GetComponent<Health90>();
            }
            if (redFull3.activeInHierarchy)
            {
                redFull1 = redFull3;
                health = redFull3.GetComponent<Health90>();
            }
            if (redFull4.activeInHierarchy)
            {
                redFull1 = redFull4;
                health = redFull4.GetComponent<Health90>();
            }
            if (redFull5.activeInHierarchy)
            {
                redFull1 = redFull5;
                health = redFull5.GetComponent<Health90>();
            }
            if (redFull6Reki.activeInHierarchy)
            {
                redFull1 = redFull6Reki;
                healthReki = redFull6Reki.GetComponent<HealthReki>();
            }
            if (redFull7.activeInHierarchy)
            {
                redFull1 = redFull7;
                health = redFull7.GetComponent<Health90>();
            }
        }

        if (PlayerPrefs.HasKey("SantaPink"))
        {
            if (pinkFull2.activeInHierarchy)
            {
                pinkFull1 = pinkFull2;
                health = pinkFull2.GetComponent<Health90>();
            }
            if (pinkFull3.activeInHierarchy)
            {
                pinkFull1 = pinkFull3;
                health = pinkFull3.GetComponent<Health90>();
            }
            if (pinkFull4.activeInHierarchy)
            {
                pinkFull1 = pinkFull4;
                health = pinkFull4.GetComponent<Health90>();
            }
            if (pinkFull5.activeInHierarchy)
            {
                pinkFull1 = pinkFull5;
                health = pinkFull5.GetComponent<Health90>();
            }
            if (pinkFull6Reki.activeInHierarchy)
            {
                pinkFull1 = pinkFull6Reki;
                healthReki = pinkFull6Reki.GetComponent<HealthReki>();
            }
            if (pinkFull7.activeInHierarchy)
            {
                pinkFull1 = pinkFull7;
                health = pinkFull7.GetComponent<Health90>();
            }
        }

        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            if (blueFull2.activeInHierarchy)
            {
                blueFull1 = blueFull2;
                health = blueFull2.GetComponent<Health90>();
            }
            if (blueFull3.activeInHierarchy)
            {
                blueFull1 = blueFull3;
                health = blueFull3.GetComponent<Health90>();
            }
            if (blueFull4.activeInHierarchy)
            {
                blueFull1 = blueFull4;
                health = blueFull4.GetComponent<Health90>();
            }
            if (blueFull5.activeInHierarchy)
            {
                blueFull1 = blueFull5;
                health = blueFull5.GetComponent<Health90>();
            }
            if (blueFull6Reki.activeInHierarchy)
            {
                blueFull1 = blueFull6Reki;
                healthReki = blueFull6Reki.GetComponent<HealthReki>();
            }
            if (blueFull7.activeInHierarchy)
            {
                blueFull1 = blueFull7;
                health = blueFull7.GetComponent<Health90>();
            }
        }

        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            if (orangeFull2.activeInHierarchy)
            {
                orangeFull1 = orangeFull2;
                health = orangeFull2.GetComponent<Health90>();
            }
            if (orangeFull3.activeInHierarchy)
            {
                orangeFull1 = orangeFull3;
                health = orangeFull3.GetComponent<Health90>();
            }
            if (orangeFull4.activeInHierarchy)
            {
                orangeFull1 = orangeFull4;
                health = orangeFull4.GetComponent<Health90>();
            }
            if (orangeFull5.activeInHierarchy)
            {
                orangeFull1 = orangeFull5;
                health = orangeFull5.GetComponent<Health90>();
            }
            if (orangeFull6Reki.activeInHierarchy)
            {
                orangeFull1 = orangeFull6Reki;
                healthReki = orangeFull6Reki.GetComponent<HealthReki>();
            }
            if (orangeFull7.activeInHierarchy)
            {
                orangeFull1 = orangeFull7;
                health = orangeFull7.GetComponent<Health90>();
            }
        }

        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            if (greenFull2.activeInHierarchy)
            {
                greenFull1 = greenFull2;
                health = greenFull2.GetComponent<Health90>();
            }
            if (greenFull3.activeInHierarchy)
            {
                greenFull1 = greenFull3;
                health = greenFull3.GetComponent<Health90>();
            }
            if (greenFull4.activeInHierarchy)
            {
                greenFull1 = greenFull4;
                health = greenFull4.GetComponent<Health90>();
            }
            if (greenFull5.activeInHierarchy)
            {
                greenFull1 = greenFull5;
                health = greenFull5.GetComponent<Health90>();
            }
            if (greenFull6Reki.activeInHierarchy)
            {
                greenFull1 = greenFull6Reki;
                healthReki = greenFull6Reki.GetComponent<HealthReki>();
            }
            if (greenFull7.activeInHierarchy)
            {
                greenFull1 = greenFull7;
                health = greenFull7.GetComponent<Health90>();
            }
        }

        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            if (purpleFull2.activeInHierarchy)
            {
                purpleFull1 = purpleFull2;
                health = purpleFull2.GetComponent<Health90>();
            }
            if (purpleFull3.activeInHierarchy)
            {
                purpleFull1 = purpleFull3;
                health = purpleFull3.GetComponent<Health90>();
            }
            if (purpleFull4.activeInHierarchy)
            {
                purpleFull1 = purpleFull4;
                health = purpleFull4.GetComponent<Health90>();
            }
            if (purpleFull5.activeInHierarchy)
            {
                purpleFull1 = purpleFull5;
                health = purpleFull5.GetComponent<Health90>();
            }
            if (purpleFull6Reki.activeInHierarchy)
            {
                purpleFull1 = purpleFull6Reki;
                healthReki = purpleFull6Reki.GetComponent<HealthReki>();
            }
            if (purpleFull7.activeInHierarchy)
            {
                purpleFull1 = purpleFull7;
                health = purpleFull7.GetComponent<Health90>();
            }
        }

        if (health.dead && canDie && !alreadyDead || healthReki.dead && canDie && !alreadyDead)
        {
            lives--;
            lifeText.text = "x " + lives.ToString();
            canDie = false;
            StartCoroutine(Delaus());
        }

        if (lives == 1)
        {
            lifeText.color = Color.red;
        }

        if (lives <= 0 && !alreadyDead)
        {
            panel.SetActive(true);
            if (audioSource2.isPlaying)
            {
                audioSource2.Stop();
            }
            if (audioSource3.isPlaying)
            {
                audioSource3.Stop();
            }
            if (audioSource4.isPlaying)
            {
                audioSource4.Stop();
            }
            if (audioSource5.isPlaying)
            {
                audioSource5.Stop();
            }
            if (audioSource6.isPlaying)
            {
                audioSource6.Stop();
            }
            if (audioSource7.isPlaying)
            {
                audioSource7.Stop();
            }

            if (PlayerPrefs.HasKey("SantaRed"))
            {
                redDead.SetActive(true);
                pinkDead.SetActive(false);
                blueDead.SetActive(false);
                orangeDead.SetActive(false);
                greenDead.SetActive(false);
                purpleDead.SetActive(false);
                redFull6Reki.SetActive(false);
                redFull1.SetActive(false);
                redFull2.SetActive(false);
                redFull3.SetActive(false);
                redFull4.SetActive(false);
                redFull5.SetActive(false);
                redFull7.SetActive(false);
            }
            if (PlayerPrefs.HasKey("SantaPink"))
            {
                redDead.SetActive(false);
                pinkDead.SetActive(true);
                blueDead.SetActive(false);
                orangeDead.SetActive(false);
                greenDead.SetActive(false);
                purpleDead.SetActive(false);
                pinkFull6Reki.SetActive(false);
                pinkFull1.SetActive(false);
                pinkFull2.SetActive(false);
                pinkFull3.SetActive(false);
                pinkFull4.SetActive(false);
                pinkFull5.SetActive(false);
                pinkFull7.SetActive(false);
            }
            if (PlayerPrefs.HasKey("SantaBlue"))
            {
                redDead.SetActive(false);
                pinkDead.SetActive(false);
                blueDead.SetActive(true);
                orangeDead.SetActive(false);
                greenDead.SetActive(false);
                purpleDead.SetActive(false);
                blueFull6Reki.SetActive(false);
                blueFull1.SetActive(false);
                blueFull2.SetActive(false);
                blueFull3.SetActive(false);
                blueFull4.SetActive(false);
                blueFull5.SetActive(false);
                blueFull7.SetActive(false);
            }
            if (PlayerPrefs.HasKey("SantaOrange"))
            {
                redDead.SetActive(false);
                pinkDead.SetActive(false);
                blueDead.SetActive(false);
                orangeDead.SetActive(true);
                greenDead.SetActive(false);
                purpleDead.SetActive(false);
                orangeFull6Reki.SetActive(false);
                orangeFull1.SetActive(false);
                orangeFull2.SetActive(false);
                orangeFull3.SetActive(false);
                orangeFull4.SetActive(false);
                orangeFull5.SetActive(false);
                orangeFull7.SetActive(false);
            }
            if (PlayerPrefs.HasKey("SantaGreen"))
            {
                redDead.SetActive(false);
                pinkDead.SetActive(false);
                blueDead.SetActive(false);
                orangeDead.SetActive(false);
                greenDead.SetActive(true);
                purpleDead.SetActive(false);
                greenFull6Reki.SetActive(false);
                greenFull1.SetActive(false);
                greenFull2.SetActive(false);
                greenFull3.SetActive(false);
                greenFull4.SetActive(false);
                greenFull5.SetActive(false);
                greenFull7.SetActive(false);
            }
            if (PlayerPrefs.HasKey("SantaPurple"))
            {
                redDead.SetActive(false);
                pinkDead.SetActive(false);
                blueDead.SetActive(false);
                orangeDead.SetActive(false);
                greenDead.SetActive(false);
                purpleDead.SetActive(true);
                purpleFull6Reki.SetActive(false);
                purpleFull1.SetActive(false);
                purpleFull2.SetActive(false);
                purpleFull3.SetActive(false);
                purpleFull4.SetActive(false);
                purpleFull5.SetActive(false);
                purpleFull7.SetActive(false);
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
        float startVolume1 = audioSource1.volume;

        while (audioSource1.volume > 0)
        {
            audioSource1.volume -= startVolume1 * Time.deltaTime / FadeTime;
            yield return null;
        }
        audioSource1.Stop();
        audioSource1.volume = startVolume1;
        isFading = false;
    }
}
