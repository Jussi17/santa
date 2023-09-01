using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DashImaheRein : MonoBehaviour
{
    public Image jumpImage;
    public Sprite jumpNormalImage;
    public Sprite jumpNotImage;
    ReindeerMovement mv;
    public GameObject red;
    public GameObject pink;
    public GameObject blue;
    public GameObject orange;
    public GameObject green;
    public GameObject purple;

    private void Start()
    {
        if (PlayerPrefs.HasKey("SantaRed"))
        {
            mv = red.GetComponent<ReindeerMovement>();
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            mv = pink.GetComponent<ReindeerMovement>();
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            mv = blue.GetComponent<ReindeerMovement>();
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            mv = orange.GetComponent<ReindeerMovement>();
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            mv = green.GetComponent<ReindeerMovement>();
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            mv = purple.GetComponent<ReindeerMovement>();
        }
    }
    private void Update()
    {
        if (mv.jumpsLeft > 0)
        {
            jumpImage.sprite = jumpNormalImage;
        }
        if (mv.jumpsLeft == 0)
        {
            jumpImage.sprite = jumpNotImage;
        }
    }
}
