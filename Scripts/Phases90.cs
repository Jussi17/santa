using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phases90 : MonoBehaviour
{
    public GameObject Layer2Parent;
    public GameObject Layer3Parent;

    public GameObject Layer2Phase1;
    public GameObject Layer2Phase2;
    public GameObject Layer2Phase3;
    public GameObject Layer3Phase1;
    public GameObject Layer3Phase2;

    public GameObject red1;
    public GameObject red2;
    public GameObject red3;
    public GameObject red4;
    public GameObject red5;
    public GameObject red6;
    public GameObject red7;
    public GameObject pink1;
    public GameObject pink2;
    public GameObject pink3;
    public GameObject pink4;
    public GameObject pink5;
    public GameObject pink6;
    public GameObject pink7;
    public GameObject blue1;
    public GameObject blue2;
    public GameObject blue3;
    public GameObject blue4;
    public GameObject blue5;
    public GameObject blue6;
    public GameObject blue7;
    public GameObject orange1;
    public GameObject orange2;
    public GameObject orange3;
    public GameObject orange4;
    public GameObject orange5;
    public GameObject orange6;
    public GameObject orange7;
    public GameObject green1;
    public GameObject green2;
    public GameObject green3;
    public GameObject green4;
    public GameObject green5;
    public GameObject green6;
    public GameObject green7;
    public GameObject purple1;
    public GameObject purple2;
    public GameObject purple3;
    public GameObject purple4;
    public GameObject purple5;
    public GameObject purple6;
    public GameObject purple7;

    public GameObject mount;
    public GameObject mount1;

    void Start()
    {
        Layer2Phase2.SetActive(false);
        Layer2Phase3.SetActive(false);
        Layer3Phase2.SetActive(false);

        Layer2Phase2.transform.parent = null;
        Layer2Phase3.transform.parent = null;
        Layer3Phase2.transform.parent = null;
    }

    void Update()
    {
        if (PlayerPrefs.HasKey("SantaRed"))
        {
            if (red1.activeInHierarchy || red2.activeInHierarchy)
            {
                Layer2Phase1.SetActive(true);
                Layer3Phase1.SetActive(true);
                Layer2Phase2.SetActive(false);
                Layer3Phase2.SetActive(false);
                Layer2Phase3.SetActive(false);
            }
            if (red3.activeInHierarchy)
            {
                Layer2Phase1.SetActive(false);
                Layer3Phase1.SetActive(false);
                Layer2Phase2.SetActive(false);
                Layer3Phase2.SetActive(false);
                Layer2Phase3.SetActive(false);

                Layer2Phase1.transform.parent = null;
                Layer3Phase1.transform.parent = null;
            }
            if (red4.activeInHierarchy || red5.activeInHierarchy)
            {
                Layer2Phase1.SetActive(false);
                Layer3Phase1.SetActive(false);
                Layer2Phase2.SetActive(true);
                Layer3Phase2.SetActive(true);
                Layer2Phase3.SetActive(false);

                Layer2Phase2.transform.parent = Layer2Parent.transform;
                Layer3Phase2.transform.parent = Layer3Parent.transform;
            }
            if (red6.activeInHierarchy)
            {
                Layer2Phase1.SetActive(false);
                Layer3Phase1.SetActive(false);
                Layer2Phase2.SetActive(false);
                Layer3Phase2.SetActive(false);
                Layer2Phase3.SetActive(false);
            }
            if (red7.activeInHierarchy)
            {
                Layer2Phase1.SetActive(false);
                Layer3Phase1.SetActive(false);
                Layer2Phase2.SetActive(false);
                Layer3Phase2.SetActive(false);
                Layer2Phase3.SetActive(true);
                Layer2Phase3.transform.parent = Layer2Parent.transform;
                mount.SetActive(false);
                mount1.SetActive(false);
            }
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            if (pink1.activeInHierarchy || pink2.activeInHierarchy)
            {
                Layer2Phase1.SetActive(true);
                Layer3Phase1.SetActive(true);
                Layer2Phase2.SetActive(false);
                Layer3Phase2.SetActive(false);
                Layer2Phase3.SetActive(false);
            }
            if (pink3.activeInHierarchy)
            {
                Layer2Phase1.SetActive(false);
                Layer3Phase1.SetActive(false);
                Layer2Phase2.SetActive(false);
                Layer3Phase2.SetActive(false);
                Layer2Phase3.SetActive(false);

                Layer2Phase1.transform.parent = null;
                Layer3Phase1.transform.parent = null;
            }
            if (pink4.activeInHierarchy || pink5.activeInHierarchy)
            {
                Layer2Phase1.SetActive(false);
                Layer3Phase1.SetActive(false);
                Layer2Phase2.SetActive(true);
                Layer3Phase2.SetActive(true);
                Layer2Phase3.SetActive(false);

                Layer2Phase2.transform.parent = Layer2Parent.transform;
                Layer3Phase2.transform.parent = Layer3Parent.transform;
            }
            if (pink6.activeInHierarchy)
            {
                Layer2Phase1.SetActive(false);
                Layer3Phase1.SetActive(false);
                Layer2Phase2.SetActive(false);
                Layer3Phase2.SetActive(false);
                Layer2Phase3.SetActive(false);
            }
            if (pink7.activeInHierarchy)
            {
                Layer2Phase1.SetActive(false);
                Layer3Phase1.SetActive(false);
                Layer2Phase2.SetActive(false);
                Layer3Phase2.SetActive(false);
                Layer2Phase3.SetActive(true);
                Layer2Phase3.transform.parent = Layer2Parent.transform;
                mount.SetActive(false);
                mount1.SetActive(false);
            }
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            if (blue1.activeInHierarchy || blue2.activeInHierarchy)
            {
                Layer2Phase1.SetActive(true);
                Layer3Phase1.SetActive(true);
                Layer2Phase2.SetActive(false);
                Layer3Phase2.SetActive(false);
                Layer2Phase3.SetActive(false);
            }
            if (blue3.activeInHierarchy)
            {
                Layer2Phase1.SetActive(false);
                Layer3Phase1.SetActive(false);
                Layer2Phase2.SetActive(false);
                Layer3Phase2.SetActive(false);
                Layer2Phase3.SetActive(false);

                Layer2Phase1.transform.parent = null;
                Layer3Phase1.transform.parent = null;
            }
            if (blue4.activeInHierarchy || blue5.activeInHierarchy)
            {
                Layer2Phase1.SetActive(false);
                Layer3Phase1.SetActive(false);
                Layer2Phase2.SetActive(true);
                Layer3Phase2.SetActive(true);
                Layer2Phase3.SetActive(false);

                Layer2Phase2.transform.parent = Layer2Parent.transform;
                Layer3Phase2.transform.parent = Layer3Parent.transform;
            }
            if (blue6.activeInHierarchy)
            {
                Layer2Phase1.SetActive(false);
                Layer3Phase1.SetActive(false);
                Layer2Phase2.SetActive(false);
                Layer3Phase2.SetActive(false);
                Layer2Phase3.SetActive(false);
            }
            if (blue7.activeInHierarchy)
            {
                Layer2Phase1.SetActive(false);
                Layer3Phase1.SetActive(false);
                Layer2Phase2.SetActive(false);
                Layer3Phase2.SetActive(false);
                Layer2Phase3.SetActive(true);
                Layer2Phase3.transform.parent = Layer2Parent.transform;
                mount.SetActive(false);
                mount1.SetActive(false);
            }
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            if (orange1.activeInHierarchy || orange2.activeInHierarchy)
            {
                Layer2Phase1.SetActive(true);
                Layer3Phase1.SetActive(true);
                Layer2Phase2.SetActive(false);
                Layer3Phase2.SetActive(false);
                Layer2Phase3.SetActive(false);
            }
            if (orange3.activeInHierarchy)
            {
                Layer2Phase1.SetActive(false);
                Layer3Phase1.SetActive(false);
                Layer2Phase2.SetActive(false);
                Layer3Phase2.SetActive(false);
                Layer2Phase3.SetActive(false);

                Layer2Phase1.transform.parent = null;
                Layer3Phase1.transform.parent = null;
            }
            if (orange4.activeInHierarchy || orange5.activeInHierarchy)
            {
                Layer2Phase1.SetActive(false);
                Layer3Phase1.SetActive(false);
                Layer2Phase2.SetActive(true);
                Layer3Phase2.SetActive(true);
                Layer2Phase3.SetActive(false);

                Layer2Phase2.transform.parent = Layer2Parent.transform;
                Layer3Phase2.transform.parent = Layer3Parent.transform;
            }
            if (orange6.activeInHierarchy)
            {
                Layer2Phase1.SetActive(false);
                Layer3Phase1.SetActive(false);
                Layer2Phase2.SetActive(false);
                Layer3Phase2.SetActive(false);
                Layer2Phase3.SetActive(false);
            }
            if (orange7.activeInHierarchy)
            {
                Layer2Phase1.SetActive(false);
                Layer3Phase1.SetActive(false);
                Layer2Phase2.SetActive(false);
                Layer3Phase2.SetActive(false);
                Layer2Phase3.SetActive(true);
                Layer2Phase3.transform.parent = Layer2Parent.transform;
                mount.SetActive(false);
                mount1.SetActive(false);
            }
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            if (green1.activeInHierarchy || green2.activeInHierarchy)
            {
                Layer2Phase1.SetActive(true);
                Layer3Phase1.SetActive(true);
                Layer2Phase2.SetActive(false);
                Layer3Phase2.SetActive(false);
                Layer2Phase3.SetActive(false);
            }
            if (green3.activeInHierarchy)
            {
                Layer2Phase1.SetActive(false);
                Layer3Phase1.SetActive(false);
                Layer2Phase2.SetActive(false);
                Layer3Phase2.SetActive(false);
                Layer2Phase3.SetActive(false);

                Layer2Phase1.transform.parent = null;
                Layer3Phase1.transform.parent = null;
            }
            if (green4.activeInHierarchy || green5.activeInHierarchy)
            {
                Layer2Phase1.SetActive(false);
                Layer3Phase1.SetActive(false);
                Layer2Phase2.SetActive(true);
                Layer3Phase2.SetActive(true);
                Layer2Phase3.SetActive(false);

                Layer2Phase2.transform.parent = Layer2Parent.transform;
                Layer3Phase2.transform.parent = Layer3Parent.transform;
            }
            if (green6.activeInHierarchy)
            {
                Layer2Phase1.SetActive(false);
                Layer3Phase1.SetActive(false);
                Layer2Phase2.SetActive(false);
                Layer3Phase2.SetActive(false);
                Layer2Phase3.SetActive(false);
            }
            if (green7.activeInHierarchy)
            {
                Layer2Phase1.SetActive(false);
                Layer3Phase1.SetActive(false);
                Layer2Phase2.SetActive(false);
                Layer3Phase2.SetActive(false);
                Layer2Phase3.SetActive(true);
                Layer2Phase3.transform.parent = Layer2Parent.transform;
                mount.SetActive(false);
                mount1.SetActive(false);
            }
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            if (purple1.activeInHierarchy || purple2.activeInHierarchy)
            {
                Layer2Phase1.SetActive(true);
                Layer3Phase1.SetActive(true);
                Layer2Phase2.SetActive(false);
                Layer3Phase2.SetActive(false);
                Layer2Phase3.SetActive(false);
            }
            if (purple3.activeInHierarchy)
            {
                Layer2Phase1.SetActive(false);
                Layer3Phase1.SetActive(false);
                Layer2Phase2.SetActive(false);
                Layer3Phase2.SetActive(false);
                Layer2Phase3.SetActive(false);

                Layer2Phase1.transform.parent = null;
                Layer3Phase1.transform.parent = null;
            }
            if (purple4.activeInHierarchy || purple5.activeInHierarchy)
            {
                Layer2Phase1.SetActive(false);
                Layer3Phase1.SetActive(false);
                Layer2Phase2.SetActive(true);
                Layer3Phase2.SetActive(true);
                Layer2Phase3.SetActive(false);

                Layer2Phase2.transform.parent = Layer2Parent.transform;
                Layer3Phase2.transform.parent = Layer3Parent.transform;
            }
            if (purple6.activeInHierarchy)
            {
                Layer2Phase1.SetActive(false);
                Layer3Phase1.SetActive(false);
                Layer2Phase2.SetActive(false);
                Layer3Phase2.SetActive(false);
                Layer2Phase3.SetActive(false);
            }
            if (purple7.activeInHierarchy)
            {
                Layer2Phase1.SetActive(false);
                Layer3Phase1.SetActive(false);
                Layer2Phase2.SetActive(false);
                Layer3Phase2.SetActive(false);
                Layer2Phase3.SetActive(true);
                Layer2Phase3.transform.parent = Layer2Parent.transform;
                mount.SetActive(false);
                mount1.SetActive(false);
            }
        }
      
    }
}
