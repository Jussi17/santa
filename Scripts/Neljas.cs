using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Neljas : MonoBehaviour
{
    public GameObject player5;
    public GameObject player4;

    public GameObject player5Pink;
    public GameObject player4Pink;
    public GameObject player5Blue;
    public GameObject player4Blue;
    public GameObject player5Orange;
    public GameObject player4Orange;
    public GameObject player5Green;
    public GameObject player4Green;
    public GameObject player5Purple;
    public GameObject player4Purple;

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
    public bool neljas = false;

    public CapsuleCollider2D cp;

    [SerializeField] AudioSource music4;
    [SerializeField] AudioSource music5;
    [SerializeField] AudioSource music6;
    [SerializeField] AudioSource music3;
    [SerializeField] AudioSource music2;

    public GameObject spike1;
    public GameObject spike2;

    LifeLev90 lv90;
    public GameObject lifeCanvas;
    public GameObject koristeRein;
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
        koristeRein.SetActive(false);
    }

    private void Update()
    {
        if (music6.isPlaying)
        {
            music4.Stop();
            music5.Stop();
            music2.Stop();
            music3.Stop();
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            player5 = player5Pink;
            player4 = player4Pink;
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            player5 = player5Blue;
            player4 = player4Blue;
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            player5 = player5Orange;
            player4 = player4Orange;
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            player5 = player5Green;
            player4 = player4Green;
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            player5 = player5Purple;
            player4 = player4Purple;
        }
        if (lv90.lives == 0)
        {
            music5.Stop();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Reindeer")
        {
            if (!isChanged4)
            {
                neljas = true;
                anim.SetBool("neljas", true);
                player4.SetActive(false);
                player5.SetActive(true);

                spike1.SetActive(false);
                spike2.SetActive(false);

                music5.Play();
                music4.Stop();
                cp.enabled = true;
                dashButton.enabled = true;
                dashButtoni.enabled = true;
                slideButton.enabled = true;
                slideButtoni.enabled = true;
                isChanged4 = true;
                koristeRein.SetActive(true);
            }

        }
    }

}
