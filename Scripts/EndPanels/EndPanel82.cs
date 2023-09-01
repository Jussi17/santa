using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndPanel82 : MonoBehaviour
{
    public Image fail1;
    public Image fail2;
    public Image beat1;
    public Image beat2;
    public GameObject panel;
    [SerializeField] private HealthFinale health;
    public GameObject playerRed;
    public GameObject playerPink;
    public GameObject playerBlue;
    public GameObject playerOrange;
    public GameObject playerGreen;
    public GameObject playerPurple;
    public Text obj1;
    public Text obj2;
    private Timer3 timer;

    void Start()
    {
        timer = GetComponent<Timer3>();
        if (PlayerPrefs.HasKey("SantaRed"))
        {
            health = playerRed.GetComponent<HealthFinale>();
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            health = playerPink.GetComponent<HealthFinale>();
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            health = playerBlue.GetComponent<HealthFinale>();
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            health = playerOrange.GetComponent<HealthFinale>();
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            health = playerGreen.GetComponent<HealthFinale>();
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            health = playerPurple.GetComponent<HealthFinale>();
        }
    }
    private void Update()
    {
        if (PlayerPrefs.HasKey("Gift45"))
        {
            beat1.enabled = true;
            fail1.enabled = false;
            obj1.color = new Color(0.0438f, 0.7547f, 0, 1);
        }
        if (!PlayerPrefs.HasKey("Gift45"))
        {
            beat1.enabled = false;
            fail1.enabled = true;
        }

        if (PlayerPrefs.HasKey("Gift46"))
        {
            beat2.enabled = true;
            fail2.enabled = false;
            obj2.color = new Color(0.0438f, 0.7547f, 0, 1);
        }
        if (!PlayerPrefs.HasKey("Gift46"))
        {
            beat2.enabled = false;
            fail2.enabled = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" || collision.tag == "Reindeer" || collision.tag == "Sleigh")
        {
            if (PlayerPrefs.GetString("Difficulty") == "Easy")
            {
                if (health.currentHealth >= 4)
                {
                    PlayerPrefs.SetString("Gift45", "Gift45");
                }
            }
            if (PlayerPrefs.GetString("Difficulty") == "Normal")
            {
                if (health.currentHealth >= 3)
                {
                    PlayerPrefs.SetString("Gift45", "Gift45");
                }
            }
            if (PlayerPrefs.GetString("Difficulty") == "Hard")
            {
                if (health.currentHealth >= 1.5f)
                {
                    PlayerPrefs.SetString("Gift45", "Gift45");
                }
            }
            if (PlayerPrefs.GetString("Difficulty") == "Brutal")
            {
                if (health.currentHealth >= 0.5f)
                {
                    PlayerPrefs.SetString("Gift45", "Gift45");
                }
            }

            if (timer.timer < 68)
            {
                PlayerPrefs.SetString("Gift46", "Gift46");
                StartCoroutine(Paneeli());
            }
            if (timer.timer >= 68)
            {
                StartCoroutine(Paneeli());
            }
        }
    }

    IEnumerator Paneeli()
    {
        yield return new WaitForSeconds(2.5f);
        panel.SetActive(true);
    }
}
