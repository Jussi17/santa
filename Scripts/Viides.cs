using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Viides : MonoBehaviour
{
    public GameObject player5;
    public GameObject playerSleigh;

    public GameObject player5Pink;
    public GameObject playerSleighPink;
    public GameObject player5Blue;
    public GameObject playerSleighBlue;
    public GameObject player5Orange;
    public GameObject playerSleighOrange;
    public GameObject player5Green;
    public GameObject playerSleighGreen;
    public GameObject player5Purple;
    public GameObject playerSleighPurple;

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
    private bool isChanged4 = false;
    public bool viides = false;
    public CapsuleCollider2D cp;

    [SerializeField] AudioSource music5;
    [SerializeField] AudioSource music6;
    [SerializeField] AudioSource music7;

    public GameObject startCamera;
    public GameObject rekiCamera;

    public GameObject empRed;
    public GameObject empPink;
    public GameObject empBlue;
    public GameObject empOrange;
    public GameObject empGreen;
    public GameObject empPurple;

    LifeLev90 lv90;
    public GameObject lifeCanvas;

    public Animator anim;

    void Start()
    {
        lv90 = lifeCanvas.GetComponent<LifeLev90>();
        dashButton.enabled = false;
        slideButton.enabled = false;
        dashButtoni.enabled = false;
        slideButtoni.enabled = false;
        cp.enabled = false;
        if (PlayerPrefs.HasKey("SantaRed"))
        {
            empRed.SetActive(true);
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            empPink.SetActive(true);
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            empBlue.SetActive(true);
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            empOrange.SetActive(true);
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            empGreen.SetActive(true);
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            empPurple.SetActive(true);
        }
    }

    private void Update()
    {
        if (music7.isPlaying)
        {
            music6.Stop();
            music5.Stop();
        }
   
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            player5 = player5Pink;
            playerSleigh = playerSleighPink;
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            player5 = player5Blue;
            playerSleigh = playerSleighBlue;
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            player5 = player5Orange;
            playerSleigh = playerSleighOrange;
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            player5 = player5Green;
            playerSleigh = playerSleighGreen;
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            player5 = player5Purple;
            playerSleigh = playerSleighPurple;
        }
        if (lv90.lives == 0)
        {
            music6.Stop();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Reindeer")
        {
            if (!isChanged4)
            {
                viides = true;
                anim.SetBool("neljas", false);
                player5.SetActive(false);
                playerSleigh.SetActive(true);
                music6.Play();
                music5.Stop();
                cp.enabled = true;
                startCamera.SetActive(false);
                rekiCamera.SetActive(true);
                leftButton.enabled = false;
                leftButtoni.enabled = false;
                rightButton.enabled = false;
                rightButtoni.enabled = false;
                dashButton.enabled = false;
                slideButton.enabled = false;
                dashButtoni.enabled = false;
                slideButtoni.enabled = false;
                upButton.enabled = true;
                upButtoni.enabled = true;
                downButton.enabled = true;
                downButtoni.enabled = true;
                empBlue.SetActive(false);
                empGreen.SetActive(false);
                empOrange.SetActive(false);
                empPink.SetActive(false);
                empPurple.SetActive(false);
                empRed.SetActive(false);
                isChanged4 = true;
            }

        }
    }

}
