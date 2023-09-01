using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SantaSel9 : MonoBehaviour
{
    public Image defSanta;
    public Image redSanta;
    public Image pinkSanta;
    public Image blueSanta;
    public Image orangeSanta;
    public Image greenSanta;
    public Image purpleSanta;

    public Image defSanta1;
    public Image redSanta1;
    public Image pinkSanta1;
    public Image blueSanta1;
    public Image orangeSanta1;
    public Image greenSanta1;
    public Image purpleSanta1;

    private void Awake()
    {
        redSanta.enabled = false;
        pinkSanta.enabled = false;
        blueSanta.enabled = false;
        orangeSanta.enabled = false;
        greenSanta.enabled = false;
        purpleSanta.enabled = false;

        redSanta1.enabled = false;
        pinkSanta1.enabled = false;
        blueSanta1.enabled = false;
        orangeSanta1.enabled = false;
        greenSanta1.enabled = false;
        purpleSanta1.enabled = false;

        if (!PlayerPrefs.HasKey("SantaRed") && !PlayerPrefs.HasKey("SantaPink") && !PlayerPrefs.HasKey("SantaBlue") && !PlayerPrefs.HasKey("SantaOrange") && !PlayerPrefs.HasKey("SantaGreen") && !PlayerPrefs.HasKey("SantaPurple"))
        {
            redSanta.enabled = true;
            redSanta1.enabled = true;
            defSanta = redSanta;
            defSanta1 = redSanta1;
        }

        if (PlayerPrefs.HasKey("SantaRed"))
        {
            redSanta.enabled = true;
            redSanta1.enabled = true;
            defSanta = redSanta;
            defSanta1 = redSanta1;
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            pinkSanta.enabled = true;
            pinkSanta1.enabled = true;
            defSanta = pinkSanta;
            defSanta1 = pinkSanta1;
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            blueSanta.enabled = true;
            blueSanta1.enabled = true;
            defSanta = blueSanta;
            defSanta1 = blueSanta1;
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            orangeSanta.enabled = true;
            orangeSanta1.enabled = true;
            defSanta = orangeSanta;
            defSanta1 = orangeSanta1;
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            greenSanta.enabled = true;
            greenSanta1.enabled = true;
            defSanta = greenSanta;
            defSanta1 = greenSanta1;
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            purpleSanta.enabled = true;
            purpleSanta1.enabled = true;
            defSanta = purpleSanta;
            defSanta1 = purpleSanta1;
        }
    }
}
