using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed22 : MonoBehaviour
{
    public GameObject redSpeed;
    public GameObject pinkSpeed;
    public GameObject blueSpeed;
    public GameObject orangeSpeed;
    public GameObject greenSpeed;
    public GameObject purpleSpeed;
    public GameObject red;
    public GameObject pink;
    public GameObject blue;
    public GameObject orange;
    public GameObject green;
    public GameObject purple;
    private Health health;
    private bool hasLaughed = false;
    [SerializeField] private AudioSource speedSound;

    private void Awake()
    {
        if (PlayerPrefs.HasKey("SantaRed"))
        {
            health = red.GetComponent<Health>();
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            health = pink.GetComponent<Health>();
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            health = blue.GetComponent<Health>();
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            health = orange.GetComponent<Health>();
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            health = green.GetComponent<Health>();
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            health = purple.GetComponent<Health>();
        }
    }

    void Start()
    {
        redSpeed.SetActive(false);
        pinkSpeed.SetActive(false);
        blueSpeed.SetActive(false);
        orangeSpeed.SetActive(false);
        greenSpeed.SetActive(false);
        purpleSpeed.SetActive(false);
    }

    void Update()
    {
        if (health.dead)
        {
            redSpeed.SetActive(false);
            pinkSpeed.SetActive(false);
            blueSpeed.SetActive(false);
            orangeSpeed.SetActive(false);
            greenSpeed.SetActive(false);
            purpleSpeed.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Seiska")
        {
            if (PlayerPrefs.HasKey("SantaRed"))
            {
                redSpeed.SetActive(true);
                if (!hasLaughed)
                {
                    speedSound.Play();
                    hasLaughed = true;
                }
            }
            if (PlayerPrefs.HasKey("SantaPink"))
            {
                pinkSpeed.SetActive(true);
                if (!hasLaughed)
                {
                    speedSound.Play();
                    hasLaughed = true;
                }
            }
            if (PlayerPrefs.HasKey("SantaBlue"))
            {
                blueSpeed.SetActive(true);
                if (!hasLaughed)
                {
                    speedSound.Play();
                    hasLaughed = true;
                }
            }
            if (PlayerPrefs.HasKey("SantaOrange"))
            {
                orangeSpeed.SetActive(true);
                if (!hasLaughed)
                {
                    speedSound.Play();
                    hasLaughed = true;
                }
            }
            if (PlayerPrefs.HasKey("SantaGreen"))
            {
                greenSpeed.SetActive(true);
                if (!hasLaughed)
                {
                    speedSound.Play();
                    hasLaughed = true;
                }
            }
            if (PlayerPrefs.HasKey("SantaPurple"))
            {
                purpleSpeed.SetActive(true);
                if (!hasLaughed)
                {
                    speedSound.Play();
                    hasLaughed = true;
                }
            }
        }
    }
}
