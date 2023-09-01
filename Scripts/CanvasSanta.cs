using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasSanta : MonoBehaviour
{
    public GameObject redSanta;
    public GameObject pinkSanta;
    public GameObject blueSanta;
    public GameObject orangeSanta;
    public GameObject greenSanta;
    public GameObject purpleSanta;

    private void Awake()
    {
        if (!PlayerPrefs.HasKey("SantaRed") && !PlayerPrefs.HasKey("SantaPink") && !PlayerPrefs.HasKey("SantaBlue") && !PlayerPrefs.HasKey("SantaOrange") && !PlayerPrefs.HasKey("SantaGreen") && !PlayerPrefs.HasKey("SantaPurple"))
        {
            redSanta.SetActive(true);
            pinkSanta.SetActive(false);
            blueSanta.SetActive(false);
            orangeSanta.SetActive(false);
            greenSanta.SetActive(false);
            purpleSanta.SetActive(false);
        }

        if (PlayerPrefs.HasKey("SantaRed"))
        {
            redSanta.SetActive(true);
            pinkSanta.SetActive(false);
            blueSanta.SetActive(false);
            orangeSanta.SetActive(false);
            greenSanta.SetActive(false);
            purpleSanta.SetActive(false);
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            redSanta.SetActive(false);
            pinkSanta.SetActive(true);
            blueSanta.SetActive(false);
            orangeSanta.SetActive(false);
            greenSanta.SetActive(false);
            purpleSanta.SetActive(false);
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            redSanta.SetActive(false);
            pinkSanta.SetActive(false);
            blueSanta.SetActive(true);
            orangeSanta.SetActive(false);
            greenSanta.SetActive(false);
            purpleSanta.SetActive(false);
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            redSanta.SetActive(false);
            pinkSanta.SetActive(false);
            blueSanta.SetActive(false);
            orangeSanta.SetActive(true);
            greenSanta.SetActive(false);
            purpleSanta.SetActive(false);
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            redSanta.SetActive(false);
            pinkSanta.SetActive(false);
            blueSanta.SetActive(false);
            orangeSanta.SetActive(false);
            greenSanta.SetActive(true);
            purpleSanta.SetActive(false);
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            redSanta.SetActive(false);
            pinkSanta.SetActive(false);
            blueSanta.SetActive(false);
            orangeSanta.SetActive(false);
            greenSanta.SetActive(false);
            purpleSanta.SetActive(true);
        }
    }


}
