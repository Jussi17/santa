using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyActive : MonoBehaviour
{
    [SerializeField] private AudioSource shockSound;
    Movement6 mv;
    public GameObject candy;
    public GameObject Red;
    public GameObject Pink;
    public GameObject Blue;
    public GameObject Orange;
    public GameObject Green;
    public GameObject Purple;
    private BoxCollider2D bx;
    private bool isShock = false;
    public GameObject mapButton;

    void Start()
    {
        bx = GetComponent<BoxCollider2D>();
        candy.SetActive(false);
        if (PlayerPrefs.HasKey("SantaRed"))
        {
            mv = Red.GetComponent<Movement6>();
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            Red = Pink;
            mv = Pink.GetComponent<Movement6>();
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            Red = Blue;
            mv = Blue.GetComponent<Movement6>();
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            Red = Orange;
            mv = Orange.GetComponent<Movement6>();
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            Red = Green;
            mv = Green.GetComponent<Movement6>();
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            Red = Purple;
            mv = Purple.GetComponent<Movement6>();
        }
    }

    void Update()
    {
        if (PlayerPrefs.HasKey("CandyOff"))
        {
            candy.SetActive(false);
            bx.enabled = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && mv.isGrounded())
        {
            if (!isShock)
            {
                shockSound.Play();
                candy.SetActive(true);
                mapButton.SetActive(false);
                candy.transform.parent = Red.transform;
                isShock = true;
            }           
        }
    }
}
