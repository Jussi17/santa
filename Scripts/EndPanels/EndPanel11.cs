using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndPanel11 : MonoBehaviour
{
    public Image fail1;
    public Image fail2;
    public Image beat1;
    public Image beat2;
    public GameObject panel;
    [SerializeField] private Health health;
    public GameObject playerRed;
    public GameObject playerPink;
    public GameObject playerBlue;
    public GameObject playerOrange;
    public GameObject playerGreen;
    public GameObject playerPurple;
    public bool saaGift = false;
    public Text obj1;
    public Text obj2;
    Cookie11 cook;
    public GameObject cookie;
    private Timer3 timer;

    void Start()
    {
        timer = GetComponent<Timer3>();
        cook = cookie.GetComponent<Cookie11>();
        if (PlayerPrefs.HasKey("SantaRed"))
        {
            health = playerRed.GetComponent<Health>();
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            health = playerPink.GetComponent<Health>();
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            health = playerBlue.GetComponent<Health>();
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            health = playerOrange.GetComponent<Health>();
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            health = playerGreen.GetComponent<Health>();
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            health = playerPurple.GetComponent<Health>();
        }
    }

    private void Update()
    {
        if (PlayerPrefs.HasKey("Gift1"))
        {
            obj1.color = new Color(0.0438f, 0.7547f, 0, 1);
            beat1.enabled = true;
            fail1.enabled = false;
        }
        if (!PlayerPrefs.HasKey("Gift1"))
        {
            beat1.enabled = false;
            fail1.enabled = true;
        }

        if (PlayerPrefs.HasKey("Gift2"))
        {
            obj2.color = new Color(0.0438f, 0.7547f, 0, 1);
            beat2.enabled = true;
            fail2.enabled = false;
        }
        if (!PlayerPrefs.HasKey("Gift2"))
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
                PlayerPrefs.SetString("Gift1", "Gift1");
            }

            if (timer.timer < 56)
            {
                PlayerPrefs.SetString("Gift2", "Gift2");
                saaGift = true;
                StartCoroutine(Paneeli());
            }
            if (timer.timer >= 56)
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
