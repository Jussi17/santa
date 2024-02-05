using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Which90 : MonoBehaviour
{
    public GameObject red;
    public GameObject pink;
    public GameObject blue;
    public GameObject orange;
    public GameObject green;
    public GameObject purple;

    public GameObject red1;
    public GameObject pink1;
    public GameObject blue1;
    public GameObject orange1;
    public GameObject green1;
    public GameObject purple1;

    public GameObject red2;
    public GameObject pink2;
    public GameObject blue2;
    public GameObject orange2;
    public GameObject green2;
    public GameObject purple2;

    public GameObject redR;
    public GameObject pinkR;
    public GameObject blueR;
    public GameObject orangeR;
    public GameObject greenR;
    public GameObject purpleR;

    public GameObject red3;
    public GameObject pink3;
    public GameObject blue3;
    public GameObject orange3;
    public GameObject green3;
    public GameObject purple3;

    public GameObject red4;
    public GameObject pink4;
    public GameObject blue4;
    public GameObject orange4;
    public GameObject green4;
    public GameObject purple4;

    Movement mov;
    Movement2 mov2;
    Movement3 mov3;
    ReindeerMovement reinMov;
    Movement4 mov4;
    Movement6 mov6;
    Rigidbody2D rb;

    public bool liikkuu = false;
    public Text text;

    private void Start()
    {
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            red = pink;
            red1 = pink1;
            red2 = pink2;
            redR = pinkR;
            red3 = pink3;
            red4 = pink4; 
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            red = blue;
            red1 = blue1;
            red2 = blue2;
            redR = blueR;
            red3 = blue3;
            red4 = blue4;
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            red = orange;
            red1 = orange1;
            red2 = orange2;
            redR = orangeR;
            red3 = orange3;
            red4 = orange4;
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            red = green;
            red1 = green1;
            red2 = green2;
            redR = greenR;
            red3 = green3;
            red4 = green4;
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            red = purple;
            red1 = purple1;
            red2 = purple2;
            redR = purpleR;
            red3 = purple3;
            red4 = purple4;
        }
        mov = red.GetComponent<Movement>();
        mov2 = red1.GetComponent<Movement2>();
        mov3 = red2.GetComponent<Movement3>();
        reinMov = redR.GetComponent<ReindeerMovement>();
        mov4 = red3.GetComponent<Movement4>();
        mov6 = red4.GetComponent<Movement6>();
    }

    void Update()
    {

            if (red.activeInHierarchy)
            {
            rb = red.GetComponent<Rigidbody2D>();
            if (rb.velocity.y < 0.2f && rb.velocity.y > -0.2f)
                {
                    liikkuu = false;
                }
                else
                {
                    liikkuu = true;
                }
            }
            if (red1.activeInHierarchy)
            {
            rb = red1.GetComponent<Rigidbody2D>();
            if (rb.velocity.y < 0.2f && rb.velocity.y > -0.2f)
                {
                    liikkuu = false;
                }
                else
                {
                    liikkuu = true;
                }
            }
            if (red2.activeInHierarchy)
            {
            rb = red2.GetComponent<Rigidbody2D>();
            if (rb.velocity.y < 0.2f && rb.velocity.y > -0.2f)
                {
                    liikkuu = false;
                }
                else
                {
                    liikkuu = true;
                }
            }
            if (redR.activeInHierarchy)
            {
            rb = redR.GetComponent<Rigidbody2D>();
            text.fontSize = 95;
            text.text = ("can't return to last checkpoint while blitzen is jumping or falling!");
            if (rb.velocity.y < 0.2f && rb.velocity.y > -0.2f)
                {
                    liikkuu = false;
                }
                else
                {
                    liikkuu = true;
                }
            }
            if (red3.activeInHierarchy)
            {
            text.text = ("can't return to last checkpoint while santa is jumping or falling!");
            text.fontSize = 100;
            rb = red3.GetComponent<Rigidbody2D>();
            if (rb.velocity.y < 0.2f && rb.velocity.y > -0.2f)
                {
                    liikkuu = false;
                }
                else
                {
                    liikkuu = true;
                }
            }
            if (red4.activeInHierarchy)
            {
            rb = red4.GetComponent<Rigidbody2D>();
            if (rb.velocity.y < 0.2f && rb.velocity.y > -0.2f)
                {
                    liikkuu = false;
                }
                else
                {
                    liikkuu = true;
                }
            }
        }
    
}
