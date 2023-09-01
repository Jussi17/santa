using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toka : MonoBehaviour
{
    public GameObject player3;
    public GameObject player2;

    public GameObject player3Pink;
    public GameObject player2Pink;
    public GameObject player3Blue;
    public GameObject player2Blue;
    public GameObject player3Orange;
    public GameObject player2Orange;
    public GameObject player3Green;
    public GameObject player2Green;
    public GameObject player3Purple;
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
    private bool isChanged2 = false;
    public bool toka = false;

    public CapsuleCollider2D cp;

    [SerializeField] AudioSource music2;
    [SerializeField] AudioSource music3;
    [SerializeField] AudioSource music4;
    [SerializeField] AudioSource music5;
    [SerializeField] AudioSource music6;

    LifeLev90 lv90;
    public GameObject lifeCanvas;

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
        if (music4.isPlaying)
        {
            music3.Stop();
            music2.Stop();
            music5.Stop();
            music6.Stop();
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            player3 = player3Pink;
            player2 = player2Pink;
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            player3 = player3Blue;
            player2 = player2Blue;
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            player3 = player3Orange;
            player2 = player2Orange;
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            player3 = player3Green;
            player2 = player2Green;
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            player3 = player3Purple;
            player2 = player2Purple;
        }
        if (lv90.lives == 0)
        {
            music3.Stop();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (!isChanged2)
            {
                toka = true;
                player2.SetActive(false);
                player3.SetActive(true);

                music3.Play();
                cp.enabled = true;
                dashButton.enabled = true;
                dashButtoni.enabled = true;               
                isChanged2 = true;
            }

        }
    }

}
