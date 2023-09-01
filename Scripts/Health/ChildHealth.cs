using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildHealth : MonoBehaviour
{
    public GameObject red1;
    public GameObject red2;
    public GameObject red3;
    public GameObject redRein;
    public GameObject red4;
    public GameObject redReki;
    public GameObject red5;

    public GameObject pink1;
    public GameObject pink2;
    public GameObject pink3;
    public GameObject pinkRein;
    public GameObject pink4;
    public GameObject pinkReki;
    public GameObject pink5;

    public GameObject blue1;
    public GameObject blue2;
    public GameObject blue3;
    public GameObject blueRein;
    public GameObject blue4;
    public GameObject blueReki;
    public GameObject blue5;

    public GameObject orange1;
    public GameObject orange2;
    public GameObject orange3;
    public GameObject orangeRein;
    public GameObject orange4;
    public GameObject orangeReki;
    public GameObject orange5;

    public GameObject green1;
    public GameObject green2;
    public GameObject green3;
    public GameObject greenRein;
    public GameObject green4;
    public GameObject greenReki;
    public GameObject green5;

    public GameObject purple1;
    public GameObject purple2;
    public GameObject purple3;
    public GameObject purpleRein;
    public GameObject purple4;
    public GameObject purpleReki;
    public GameObject purple5;

    public GameObject childHealth;


    private void Start()
    {
        if (PlayerPrefs.HasKey("SantaRed"))
        {
            childHealth.transform.parent = red1.transform;
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            childHealth.transform.parent = pink1.transform;
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            childHealth.transform.parent = blue1.transform;
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            childHealth.transform.parent = orange1.transform;
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            childHealth.transform.parent = green1.transform;
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            childHealth.transform.parent = purple1.transform;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Eka")
        {
            if (PlayerPrefs.HasKey("SantaRed"))
            {
                childHealth.transform.parent = red2.transform;
            }
            if (PlayerPrefs.HasKey("SantaPink"))
            {
                childHealth.transform.parent = pink2.transform;
            }
            if (PlayerPrefs.HasKey("SantaBlue"))
            {
                childHealth.transform.parent = blue2.transform;
            }
            if (PlayerPrefs.HasKey("SantaOrange"))
            {
                childHealth.transform.parent = orange2.transform;
            }
            if (PlayerPrefs.HasKey("SantaGreen"))
            {
                childHealth.transform.parent = green2.transform;
            }
            if (PlayerPrefs.HasKey("SantaPurple"))
            {
                childHealth.transform.parent = purple2.transform;
            }
        }
        if (collision.gameObject.tag == "Toka")
        {
            if (PlayerPrefs.HasKey("SantaRed"))
            {
                childHealth.transform.parent = red3.transform;
            }
            if (PlayerPrefs.HasKey("SantaPink"))
            {
                childHealth.transform.parent = pink3.transform;
            }
            if (PlayerPrefs.HasKey("SantaBlue"))
            {
                childHealth.transform.parent = blue3.transform;
            }
            if (PlayerPrefs.HasKey("SantaOrange"))
            {
                childHealth.transform.parent = orange3.transform;
            }
            if (PlayerPrefs.HasKey("SantaGreen"))
            {
                childHealth.transform.parent = green3.transform;
            }
            if (PlayerPrefs.HasKey("SantaPurple"))
            {
                childHealth.transform.parent = purple3.transform;
            }
        }
        if (collision.gameObject.tag == "Kolme")
        {
            if (PlayerPrefs.HasKey("SantaRed"))
            {
                childHealth.transform.parent = redRein.transform;
            }
            if (PlayerPrefs.HasKey("SantaPink"))
            {
                childHealth.transform.parent = pinkRein.transform;
            }
            if (PlayerPrefs.HasKey("SantaBlue"))
            {
                childHealth.transform.parent = blueRein.transform;
            }
            if (PlayerPrefs.HasKey("SantaOrange"))
            {
                childHealth.transform.parent = orangeRein.transform;
            }
            if (PlayerPrefs.HasKey("SantaGreen"))
            {
                childHealth.transform.parent = greenRein.transform;
            }
            if (PlayerPrefs.HasKey("SantaPurple"))
            {
                childHealth.transform.parent = purpleRein.transform;
            }
        }
    }
}
