using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarOver : MonoBehaviour
{
    [SerializeField] public Health playerHealth;
    public GameObject red;
    public GameObject red2;
    public GameObject red3;
    public GameObject red4;
    public GameObject red5;

    public GameObject pink;
    public GameObject pink2;
    public GameObject pink3;
    public GameObject pink4;
    public GameObject pink5;

    public GameObject blue;
    public GameObject blue2;
    public GameObject blue3;
    public GameObject blue4;
    public GameObject blue5;

    public GameObject orange;
    public GameObject orange2;
    public GameObject orange3;
    public GameObject orange4;
    public GameObject orange5;

    public GameObject green;
    public GameObject green2;
    public GameObject green3;
    public GameObject green4;
    public GameObject green5;

    public GameObject purple;
    public GameObject purple2;
    public GameObject purple3;
    public GameObject purple4;
    public GameObject purple5;

    [SerializeField] private Image totalhealthBar;
    [SerializeField] private Image currenthealthBar;

    private void Awake()
    {

        if (PlayerPrefs.HasKey("SantaRed"))
        {
            playerHealth = red.GetComponent<Health>();
            if (red2.activeInHierarchy)
            {
                playerHealth = red2.GetComponent<Health>();
            }
            if (red3.activeInHierarchy)
            {
                playerHealth = red3.GetComponent<Health>();
            }
            if (red4.activeInHierarchy)
            {
                playerHealth = red4.GetComponent<Health>();
            }
            if (red5.activeInHierarchy)
            {
                playerHealth = red5.GetComponent<Health>();
            }
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            playerHealth = pink.GetComponent<Health>();
            if (pink2.activeInHierarchy)
            {
                playerHealth = pink2.GetComponent<Health>();
            }
            if (pink3.activeInHierarchy)
            {
                playerHealth = pink3.GetComponent<Health>();
            }
            if (pink4.activeInHierarchy)
            {
                playerHealth = pink4.GetComponent<Health>();
            }
            if (pink5.activeInHierarchy)
            {
                playerHealth = pink5.GetComponent<Health>();
            }
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            playerHealth = blue.GetComponent<Health>();
            if (blue2.activeInHierarchy)
            {
                playerHealth = blue2.GetComponent<Health>();
            }
            if (blue3.activeInHierarchy)
            {
                playerHealth = blue3.GetComponent<Health>();
            }
            if (blue4.activeInHierarchy)
            {
                playerHealth = blue4.GetComponent<Health>();
            }
            if (blue5.activeInHierarchy)
            {
                playerHealth = blue5.GetComponent<Health>();
            }
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            playerHealth = orange.GetComponent<Health>();
            if (orange2.activeInHierarchy)
            {
                playerHealth = orange2.GetComponent<Health>();
            }
            if (orange3.activeInHierarchy)
            {
                playerHealth = orange3.GetComponent<Health>();
            }
            if (orange4.activeInHierarchy)
            {
                playerHealth = orange4.GetComponent<Health>();
            }
            if (orange5.activeInHierarchy)
            {
                playerHealth = orange5.GetComponent<Health>();
            }
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            playerHealth = green.GetComponent<Health>();
            if (green2.activeInHierarchy)
            {
                playerHealth = green2.GetComponent<Health>();
            }
            if (green3.activeInHierarchy)
            {
                playerHealth = green3.GetComponent<Health>();
            }
            if (green4.activeInHierarchy)
            {
                playerHealth = green4.GetComponent<Health>();
            }
            if (green5.activeInHierarchy)
            {
                playerHealth = green5.GetComponent<Health>();
            }
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            playerHealth = purple.GetComponent<Health>();
            if (purple2.activeInHierarchy)
            {
                playerHealth = purple2.GetComponent<Health>();
            }
            if (purple3.activeInHierarchy)
            {
                playerHealth = purple3.GetComponent<Health>();
            }
            if (purple4.activeInHierarchy)
            {
                playerHealth = purple4.GetComponent<Health>();
            }
            if (purple5.activeInHierarchy)
            {
                playerHealth = purple5.GetComponent<Health>();
            }
        }
    }
    private void Start()
    {
        if (PlayerPrefs.HasKey("SantaRed"))
        {
            totalhealthBar.fillAmount = playerHealth.currentHealth / 10;
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            totalhealthBar.fillAmount = playerHealth.currentHealth / 10;
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            totalhealthBar.fillAmount = playerHealth.currentHealth / 10;
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            totalhealthBar.fillAmount = playerHealth.currentHealth / 10;
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            totalhealthBar.fillAmount = playerHealth.currentHealth / 10;
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            totalhealthBar.fillAmount = playerHealth.currentHealth / 10;
        }
    }

    private void Update()
    {
        if (PlayerPrefs.HasKey("SantaRed"))
        {
            currenthealthBar.fillAmount = playerHealth.currentHealth / 10;
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            currenthealthBar.fillAmount = playerHealth.currentHealth / 10;
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            currenthealthBar.fillAmount = playerHealth.currentHealth / 10;
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            currenthealthBar.fillAmount = playerHealth.currentHealth / 10;
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            currenthealthBar.fillAmount = playerHealth.currentHealth / 10;
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            currenthealthBar.fillAmount = playerHealth.currentHealth / 10;
        }
    }
}
