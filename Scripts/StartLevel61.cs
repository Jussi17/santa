using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLevel61 : MonoBehaviour
{
    Movement6 mv6;
    public GameObject red;
    public GameObject pink;
    public GameObject blue;
    public GameObject orange;
    public GameObject green;
    public GameObject purple;
    void Start()
    {
        if (PlayerPrefs.HasKey("SantaRed"))
        {
            mv6 = red.GetComponent<Movement6>();
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            mv6 = pink.GetComponent<Movement6>();
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            mv6 = blue.GetComponent<Movement6>();
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            mv6 = orange.GetComponent<Movement6>();
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            mv6 = green.GetComponent<Movement6>();
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            mv6 = purple.GetComponent<Movement6>();
        }
    }


}
