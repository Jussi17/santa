using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Eka : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public GameObject checki;

    public GameObject player1Pink;
    public GameObject player2Pink;
    public GameObject player1Blue;
    public GameObject player2Blue;
    public GameObject player1Orange;
    public GameObject player2Orange;
    public GameObject player1Green;
    public GameObject player2Green;
    public GameObject player1Purple;
    public GameObject player2Purple;

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
    private bool isChanged = false;
    public bool eka = false;

    public CapsuleCollider2D cp;

    [SerializeField] AudioSource music1;
    [SerializeField] AudioSource music2;
    [SerializeField] AudioSource music3;
    [SerializeField] AudioSource music4;
    [SerializeField] AudioSource music5;
    [SerializeField] AudioSource music6;

    LifeLev90 lv90;
    public GameObject lifeCanvas;
    public Animator anim;

    void Start()
    {
        lv90 = lifeCanvas.GetComponent<LifeLev90>();
        checki.SetActive(false);
        player2.SetActive(false);
        player2Pink.SetActive(false);
        player2Blue.SetActive(false);
        player2Orange.SetActive(false);
        player2Green.SetActive(false);
        player2Purple.SetActive(false);

        dashButton.enabled = false;
        slideButton.enabled = false;
        upButton.enabled = false;
        downButton.enabled = false;
        dashButtoni.enabled = false;
        slideButtoni.enabled = false;
        upButtoni.enabled = false;
        downButtoni.enabled = false;
        cp.enabled = false;
        leftButton.enabled = true;
        leftButtoni.enabled = true;
        rightButton.enabled = true;
        rightButtoni.enabled = true;
    }

    private void Update()
    {
        if (music3.isPlaying)
        {
            music2.Stop();
            music1.Stop();
            music4.Stop();
            music5.Stop();
            music6.Stop();
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            player1 = player1Pink;
            player2 = player2Pink;
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            player1 = player1Blue;
            player2 = player2Blue;
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            player1 = player1Orange;
            player2 = player2Orange;
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            player1 = player1Green;
            player2 = player2Green;
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            player1 = player1Purple;
            player2 = player2Purple;
        }
        if (lv90.lives == 0)
        {
            music2.Stop();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (!isChanged)
            {
                eka = true;
                player1.SetActive(false);
                player2.SetActive(true);
                music1.Stop();
                music2.Play();
                cp.enabled = true;
                anim.SetBool("eka", true);
                isChanged = true;
            }
         
        }
    }

}
