using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kolmas : MonoBehaviour
{
    public GameObject playerRein;
    public GameObject player3;

    public GameObject playerReinPink;
    public GameObject player3Pink;
    public GameObject playerReinBlue;
    public GameObject player3Blue;
    public GameObject playerReinOrange;
    public GameObject player3Orange;
    public GameObject playerReinGreen;
    public GameObject player3Green;
    public GameObject playerReinPurple;
    public GameObject player3Purple;

    public Button dashButton;
    public Button slideButton;
    public Button leftButton;
    public Button rightButton;
    public Button upButton;
    public Button downButton;

    public Image dashButtoni;
    public Image slideButtoni;
    public Image leftButtoni;
    public Image rightButtoni;
    public Image upButtoni;
    public Image downButtoni;
    private bool isChanged3 = false;
    public bool kolmas = false;
    public CapsuleCollider2D cp;

    [SerializeField] AudioSource music3;
    [SerializeField] AudioSource music4;
    [SerializeField] AudioSource music5;
    [SerializeField] AudioSource music2;
    [SerializeField] AudioSource music6;

    LifeLev90 lv90;
    public GameObject lifeCanvas;

    public Animator anim;

    void Start()
    {
        lv90 = lifeCanvas.GetComponent<LifeLev90>();
        dashButton.enabled = false;
        slideButton.enabled = false;
        upButton.enabled = false;
        downButton.enabled = false;
        dashButtoni.enabled = false;
        slideButtoni.enabled = false;
        upButtoni.enabled = false;
        downButtoni.enabled = false;
        cp.enabled = false;
    }

    private void Update()
    {
        if (music5.isPlaying)
        {
            music4.Stop();
            music3.Stop();
            music2.Stop();
            music6.Stop();
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            player3 = player3Pink;
            playerRein = playerReinPink;
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            player3 = player3Blue;
            playerRein = playerReinBlue;
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            player3 = player3Orange;
            playerRein = playerReinOrange;
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            player3 = player3Green;
            playerRein = playerReinGreen;
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            player3 = player3Purple;
            playerRein = playerReinPurple;
        }
        if (lv90.lives == 0)
        {
            music4.Stop();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (!isChanged3)
            {
                kolmas = true;
                anim.SetBool("toka", true);
                player3.SetActive(false);
                playerRein.SetActive(true);
                music3.Stop();
                music4.Play();
                cp.enabled = true;
                dashButton.enabled = false;
                dashButtoni.enabled = false;
                isChanged3 = true;
            }

        }
    }

}
