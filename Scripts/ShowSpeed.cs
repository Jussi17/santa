using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowSpeed : MonoBehaviour
{
    public Text textSpeed;
    SleighMovement slMovement;
    public GameObject red;
    public GameObject pink;
    public GameObject blue;
    public GameObject orange;
    public GameObject green;
    public GameObject purple;
    void Start()
    {
        textSpeed.enabled = false;

        if (PlayerPrefs.HasKey("SantaRed"))
        {
            slMovement = red.GetComponent<SleighMovement>();
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            slMovement = pink.GetComponent<SleighMovement>();
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            slMovement = blue.GetComponent<SleighMovement>();
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            slMovement = orange.GetComponent<SleighMovement>();
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            slMovement = green.GetComponent<SleighMovement>();
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            slMovement = purple.GetComponent<SleighMovement>();
        }
    }

    private void Update()
    {
        textSpeed.text = "SPEED: " + slMovement.sleighSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Sleigh")
        {
            textSpeed.enabled = true;
        }
    }

}
