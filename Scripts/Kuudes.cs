using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kuudes : MonoBehaviour
{
    public GameObject player6;
    public GameObject playerSleigh;
    public GameObject checkki;
    public GameObject player6Pink;
    public GameObject playerSleighPink;
    public GameObject player6Blue;
    public GameObject playerSleighBlue;
    public GameObject player6Orange;
    public GameObject playerSLeighOrange;
    public GameObject player6Green;
    public GameObject playerSleighGreen;
    public GameObject player6Purple;
    public GameObject playerSleighPurple;

    public GameObject empRed;
    public GameObject empPink;
    public GameObject empBlue;
    public GameObject empOrange;
    public GameObject empGreen;
    public GameObject empPurple;

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
    public bool kuudes = false;

    public CapsuleCollider2D cp;

    [SerializeField] AudioSource music6;
    [SerializeField] AudioSource music7;

    public GameObject rekiCam;
    public GameObject normCam;

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
        checkki.SetActive(false);

        upButton.enabled = false;
        upButtoni.enabled = false;
        downButtoni.enabled = false;
        downButton.enabled = false;
    }

    private void Update()
    {
        if (music7.isPlaying)
        {
            music6.Stop();
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            player6 = player6Pink;
            playerSleigh = playerSleighPink;
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            player6 = player6Blue;
            playerSleigh = playerSleighBlue;
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            player6 = player6Orange;
            playerSleigh = playerSLeighOrange;
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            player6 = player6Green;
            playerSleigh = playerSleighGreen;
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            player6 = player6Purple;
            playerSleigh = playerSleighPurple;
        }
        if (lv90.lives == 0)
        {
            music7.Stop();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Sleigh")
        {
            if (!isChanged4)
            {
                kuudes = true;
                anim.SetBool("kuudes", true);
                checkki.SetActive(true);
                player6.SetActive(true);
                playerSleigh.SetActive(false);
                music7.Play();
                cp.enabled = true;
                rekiCam.SetActive(false);
                normCam.SetActive(true);
                
                leftButton.enabled = true;
                leftButtoni.enabled = true;
                rightButton.enabled = true;
                rightButtoni.enabled = true;
                dashButton.enabled = true;
                slideButton.enabled = true;
                dashButtoni.enabled = true;
                slideButtoni.enabled = true;
                upButton.enabled = false;
                upButtoni.enabled = false;
                downButtoni.enabled = false;
                downButton.enabled = false;
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
                isChanged4 = true;
            }

        }
    }

}
