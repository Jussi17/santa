using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndPanel71 : MonoBehaviour
{
    public Image fail1;
    public Image fail2;
    public Image beat1;
    public Image beat2;
    public GameObject panel;
    [SerializeField] private HealthReki health;
    public GameObject playerRed;
    public GameObject playerPink;
    public GameObject playerBlue;
    public GameObject playerOrange;
    public GameObject playerGreen;
    public GameObject playerPurple;
    public Text obj1;
    public Text obj2;
    Cookie71 cook;
    public GameObject cookie;
    private Timer3 timer;

    void Start()
    {
        timer = GetComponent<Timer3>();
        cook = cookie.GetComponent<Cookie71>();
        if (PlayerPrefs.HasKey("SantaRed"))
        {
            health = playerRed.GetComponent<HealthReki>();
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            health = playerPink.GetComponent<HealthReki>();
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            health = playerBlue.GetComponent<HealthReki>();
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            health = playerOrange.GetComponent<HealthReki>();
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            health = playerGreen.GetComponent<HealthReki>();
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            health = playerPurple.GetComponent<HealthReki>();
        }
    }
    private void Update()
    {
        if (PlayerPrefs.HasKey("Gift37"))
        {
            beat1.enabled = true;
            fail1.enabled = false;
            obj1.color = new Color(0.0438f, 0.7547f, 0, 1);
        }
        if (!PlayerPrefs.HasKey("Gift37"))
        {
            beat1.enabled = false;
            fail1.enabled = true;
        }

        if (PlayerPrefs.HasKey("Gift38"))
        {
            beat2.enabled = true;
            fail2.enabled = false;
            obj2.color = new Color(0.0438f, 0.7547f, 0, 1);
        }
        if (!PlayerPrefs.HasKey("Gift38"))
        {
            beat2.enabled = false;
            fail2.enabled = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" || collision.tag == "Reindeer" || collision.tag == "Sleigh")
        {
            if (cook.hasCookie)
            {
                PlayerPrefs.SetString("Gift37", "Gift37");
            }

            if (timer.timer < 55)
            {
                PlayerPrefs.SetString("Gift38", "Gift38");
                StartCoroutine(Paneeli());
            }
            if (timer.timer >= 55)
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