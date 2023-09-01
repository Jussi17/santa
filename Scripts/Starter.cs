using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starter : MonoBehaviour
{
    public GameObject redSanta1;
    public GameObject redSanta2;
    public GameObject redSanta3;
    public GameObject redSanta4;
    public GameObject redSanta5;

    public GameObject pinkSanta1;
    public GameObject pinkSanta2;
    public GameObject pinkSanta3;
    public GameObject pinkSanta4;
    public GameObject pinkSanta5;

    public GameObject blueSanta1;
    public GameObject blueSanta2;
    public GameObject blueSanta3;
    public GameObject blueSanta4;
    public GameObject blueSanta5;

    public GameObject orangeSanta1;
    public GameObject orangeSanta2;
    public GameObject orangeSanta3;
    public GameObject orangeSanta4;
    public GameObject orangeSanta5;

    public GameObject greenSanta1;
    public GameObject greenSanta2;
    public GameObject greenSanta3;
    public GameObject greenSanta4;
    public GameObject greenSanta5;

    public GameObject purpleSanta1;
    public GameObject purpleSanta2;
    public GameObject purpleSanta3;
    public GameObject purpleSanta4;
    public GameObject purpleSanta5;
    public GameObject ufoHide;
    public GameObject hat;
    public GameObject hat2;

    public GameObject dashButton;
    public GameObject slideButton;

    public GameObject blackCanvas;
    public Animator animL;
    public Animator animR;

    private void Awake()
    {
        blackCanvas.SetActive(true);
        animL.enabled = false;
        animR.enabled = false;
        dashButton.SetActive(false);
        slideButton.SetActive(false);
        StartCoroutine(Poistu());
    }

    private void Start()
    {
        Time.timeScale = 1;
        hat2.SetActive(false);
        redSanta1.SetActive(false);
        redSanta2.SetActive(false);
        redSanta3.SetActive(false);
        redSanta4.SetActive(false);
        redSanta5.SetActive(false);
        pinkSanta1.SetActive(false);
        pinkSanta2.SetActive(false);
        pinkSanta3.SetActive(false);
        pinkSanta4.SetActive(false);
        pinkSanta5.SetActive(false);
        blueSanta1.SetActive(false);
        blueSanta2.SetActive(false);
        blueSanta3.SetActive(false);
        blueSanta4.SetActive(false);
        blueSanta5.SetActive(false);
        orangeSanta1.SetActive(false);
        orangeSanta2.SetActive(false);
        orangeSanta3.SetActive(false);
        orangeSanta4.SetActive(false);
        orangeSanta5.SetActive(false);
        greenSanta1.SetActive(false);
        greenSanta2.SetActive(false);
        greenSanta3.SetActive(false);
        greenSanta4.SetActive(false);
        greenSanta5.SetActive(false);
        purpleSanta1.SetActive(false);
        purpleSanta2.SetActive(false);
        purpleSanta3.SetActive(false);
        purpleSanta4.SetActive(false);
        purpleSanta5.SetActive(false);
    }

    IEnumerator Poistu()
    {
        yield return new WaitForSeconds(2f);
        animL.enabled = true;
        animR.enabled = true;
        yield return new WaitForSeconds(0.65f);
        blackCanvas.SetActive(false);
    }

    void Update()
    {
        if (PlayerPrefs.GetString("Difficulty") == "Hard")
        {
            PlayerPrefs.DeleteKey("ExtraHelp");
        }
        if (PlayerPrefs.GetString("Difficulty") == "Brutal")
        {
            PlayerPrefs.DeleteKey("ExtraHelp");
        }

        if (PlayerPrefs.HasKey("Hat"))
        {
            hat.SetActive(false);
            hat2.SetActive(true);
        }
        if (!PlayerPrefs.HasKey("LevelComplete3"))
        {
            if (PlayerPrefs.HasKey("SantaRed"))
            {
                redSanta1.SetActive(true);
                pinkSanta1.SetActive(false);
                blueSanta1.SetActive(false);
                orangeSanta1.SetActive(false);
                greenSanta1.SetActive(false);
                purpleSanta1.SetActive(false);
            }
            if (PlayerPrefs.HasKey("SantaPink"))
            {
                redSanta1.SetActive(false);
                pinkSanta1.SetActive(true);
                blueSanta1.SetActive(false);
                orangeSanta1.SetActive(false);
                greenSanta1.SetActive(false);
                purpleSanta1.SetActive(false);
            }
            if (PlayerPrefs.HasKey("SantaBlue"))
            {
                redSanta1.SetActive(false);
                pinkSanta1.SetActive(false);
                blueSanta1.SetActive(true);
                orangeSanta1.SetActive(false);
                greenSanta1.SetActive(false);
                purpleSanta1.SetActive(false);
            }
            if (PlayerPrefs.HasKey("SantaOrange"))
            {
                redSanta1.SetActive(false);
                pinkSanta1.SetActive(false);
                blueSanta1.SetActive(false);
                orangeSanta1.SetActive(true);
                greenSanta1.SetActive(false);
                purpleSanta1.SetActive(false);
            }
            if (PlayerPrefs.HasKey("SantaGreen"))
            {
                redSanta1.SetActive(false);
                pinkSanta1.SetActive(false);
                blueSanta1.SetActive(false);
                orangeSanta1.SetActive(false);
                greenSanta1.SetActive(true);
                purpleSanta1.SetActive(false);
            }
            if (PlayerPrefs.HasKey("SantaPurple"))
            {
                redSanta1.SetActive(false);
                pinkSanta1.SetActive(false);
                blueSanta1.SetActive(false);
                orangeSanta1.SetActive(false);
                greenSanta1.SetActive(false);
                purpleSanta1.SetActive(true);
            }
        }
        if (PlayerPrefs.HasKey("LevelComplete7"))
        {
            ufoHide.SetActive(false);
        }
            if (PlayerPrefs.HasKey("LevelComplete3") && !PlayerPrefs.HasKey("LevelComplete7"))
            {
                if (PlayerPrefs.HasKey("SantaRed"))
                {
                    redSanta2.SetActive(true);
                    pinkSanta2.SetActive(false);
                    blueSanta2.SetActive(false);
                    orangeSanta2.SetActive(false);
                    greenSanta2.SetActive(false);
                    purpleSanta2.SetActive(false);
                }
                if (PlayerPrefs.HasKey("SantaPink"))
                {
                    redSanta2.SetActive(false);
                    pinkSanta2.SetActive(true);
                    blueSanta2.SetActive(false);
                    orangeSanta2.SetActive(false);
                    greenSanta2.SetActive(false);
                    purpleSanta2.SetActive(false);
                }
                if (PlayerPrefs.HasKey("SantaBlue"))
                {
                    redSanta2.SetActive(false);
                    pinkSanta2.SetActive(false);
                    blueSanta2.SetActive(true);
                    orangeSanta2.SetActive(false);
                    greenSanta2.SetActive(false);
                    purpleSanta2.SetActive(false);
                }
                if (PlayerPrefs.HasKey("SantaOrange"))
                {
                    redSanta2.SetActive(false);
                    pinkSanta2.SetActive(false);
                    blueSanta2.SetActive(false);
                    orangeSanta2.SetActive(true);
                    greenSanta2.SetActive(false);
                    purpleSanta2.SetActive(false);
                }
                if (PlayerPrefs.HasKey("SantaGreen"))
                {
                    redSanta2.SetActive(false);
                    pinkSanta2.SetActive(false);
                    blueSanta2.SetActive(false);
                    orangeSanta2.SetActive(false);
                    greenSanta2.SetActive(true);
                    purpleSanta2.SetActive(false);
                }
                if (PlayerPrefs.HasKey("SantaPurple"))
                {
                    redSanta2.SetActive(false);
                    pinkSanta2.SetActive(false);
                    blueSanta2.SetActive(false);
                    orangeSanta2.SetActive(false);
                    greenSanta2.SetActive(false);
                    purpleSanta2.SetActive(true);
                }
            }
        if (PlayerPrefs.HasKey("LevelComplete7") && !PlayerPrefs.HasKey("LevelComplete15"))
        {
            dashButton.SetActive(true);
            if (PlayerPrefs.HasKey("SantaRed"))
            {
                redSanta3.SetActive(true);
                pinkSanta3.SetActive(false);
                blueSanta3.SetActive(false);
                orangeSanta3.SetActive(false);
                greenSanta3.SetActive(false);
                purpleSanta3.SetActive(false);
            }
            if (PlayerPrefs.HasKey("SantaPink"))
            {
                redSanta3.SetActive(false);
                pinkSanta3.SetActive(true);
                blueSanta3.SetActive(false);
                orangeSanta3.SetActive(false);
                greenSanta3.SetActive(false);
                purpleSanta3.SetActive(false);
            }
            if (PlayerPrefs.HasKey("SantaBlue"))
            {
                redSanta3.SetActive(false);
                pinkSanta3.SetActive(false);
                blueSanta3.SetActive(true);
                orangeSanta3.SetActive(false);
                greenSanta3.SetActive(false);
                purpleSanta3.SetActive(false);
            }
            if (PlayerPrefs.HasKey("SantaOrange"))
            {
                redSanta3.SetActive(false);
                pinkSanta3.SetActive(false);
                blueSanta3.SetActive(false);
                orangeSanta3.SetActive(true);
                greenSanta3.SetActive(false);
                purpleSanta3.SetActive(false);
            }
            if (PlayerPrefs.HasKey("SantaGreen"))
            {
                redSanta3.SetActive(false);
                pinkSanta3.SetActive(false);
                blueSanta3.SetActive(false);
                orangeSanta3.SetActive(false);
                greenSanta3.SetActive(true);
                purpleSanta3.SetActive(false);
            }
            if (PlayerPrefs.HasKey("SantaPurple"))
            {
                redSanta3.SetActive(false);
                pinkSanta3.SetActive(false);
                blueSanta3.SetActive(false);
                orangeSanta3.SetActive(false);
                greenSanta3.SetActive(false);
                purpleSanta3.SetActive(true);
            }
        }
        if (PlayerPrefs.HasKey("LevelComplete15") && !PlayerPrefs.HasKey("LevelComplete19"))
        {
            dashButton.SetActive(true);
            slideButton.SetActive(true);
            if (PlayerPrefs.HasKey("SantaRed"))
            {
                redSanta4.SetActive(true);
                pinkSanta4.SetActive(false);
                blueSanta4.SetActive(false);
                orangeSanta4.SetActive(false);
                greenSanta4.SetActive(false);
                purpleSanta4.SetActive(false);
            }
            if (PlayerPrefs.HasKey("SantaPink"))
            {
                redSanta4.SetActive(false);
                pinkSanta4.SetActive(true);
                blueSanta4.SetActive(false);
                orangeSanta4.SetActive(false);
                greenSanta4.SetActive(false);
                purpleSanta4.SetActive(false);
            }
            if (PlayerPrefs.HasKey("SantaBlue"))
            {
                redSanta4.SetActive(false);
                pinkSanta4.SetActive(false);
                blueSanta4.SetActive(true);
                orangeSanta4.SetActive(false);
                greenSanta4.SetActive(false);
                purpleSanta4.SetActive(false);
            }
            if (PlayerPrefs.HasKey("SantaOrange"))
            {
                redSanta4.SetActive(false);
                pinkSanta4.SetActive(false);
                blueSanta4.SetActive(false);
                orangeSanta4.SetActive(true);
                greenSanta4.SetActive(false);
                purpleSanta4.SetActive(false);
            }
            if (PlayerPrefs.HasKey("SantaGreen"))
            {
                redSanta4.SetActive(false);
                pinkSanta4.SetActive(false);
                blueSanta4.SetActive(false);
                orangeSanta4.SetActive(false);
                greenSanta4.SetActive(true);
                purpleSanta4.SetActive(false);
            }
            if (PlayerPrefs.HasKey("SantaPurple"))
            {
                redSanta4.SetActive(false);
                pinkSanta4.SetActive(false);
                blueSanta4.SetActive(false);
                orangeSanta4.SetActive(false);
                greenSanta4.SetActive(false);
                purpleSanta4.SetActive(true);
            }
        }
        if (PlayerPrefs.HasKey("LevelComplete19"))
        {
            dashButton.SetActive(true);
            slideButton.SetActive(true);
            if (PlayerPrefs.HasKey("SantaRed"))
            {
                redSanta5.SetActive(true);
                pinkSanta5.SetActive(false);
                blueSanta5.SetActive(false);
                orangeSanta5.SetActive(false);
                greenSanta5.SetActive(false);
                purpleSanta5.SetActive(false);
            }
            if (PlayerPrefs.HasKey("SantaPink"))
            {
                redSanta5.SetActive(false);
                pinkSanta5.SetActive(true);
                blueSanta5.SetActive(false);
                orangeSanta5.SetActive(false);
                greenSanta5.SetActive(false);
                purpleSanta5.SetActive(false);
            }
            if (PlayerPrefs.HasKey("SantaBlue"))
            {
                redSanta5.SetActive(false);
                pinkSanta5.SetActive(false);
                blueSanta5.SetActive(true);
                orangeSanta5.SetActive(false);
                greenSanta5.SetActive(false);
                purpleSanta5.SetActive(false);
            }
            if (PlayerPrefs.HasKey("SantaOrange"))
            {
                redSanta5.SetActive(false);
                pinkSanta5.SetActive(false);
                blueSanta5.SetActive(false);
                orangeSanta5.SetActive(true);
                greenSanta5.SetActive(false);
                purpleSanta5.SetActive(false);
            }
            if (PlayerPrefs.HasKey("SantaGreen"))
            {
                redSanta5.SetActive(false);
                pinkSanta5.SetActive(false);
                blueSanta5.SetActive(false);
                orangeSanta5.SetActive(false);
                greenSanta5.SetActive(true);
                purpleSanta5.SetActive(false);
            }
            if (PlayerPrefs.HasKey("SantaPurple"))
            {
                redSanta5.SetActive(false);
                pinkSanta5.SetActive(false);
                blueSanta5.SetActive(false);
                orangeSanta5.SetActive(false);
                greenSanta5.SetActive(false);
                purpleSanta5.SetActive(true);
            }
            if (PlayerPrefs.HasKey("UfoRight"))
            {
                StartCoroutine(PoisPref());
            }
        }
    }
    IEnumerator PoisPref()
    {
        yield return new WaitForSeconds(4);
        PlayerPrefs.DeleteKey("UfoRight");
    }
}
