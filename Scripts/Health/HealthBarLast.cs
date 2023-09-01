using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarLast : MonoBehaviour
{
    [SerializeField] public Health90 playerHealth;
    [SerializeField] public HealthReki rekiHealth;

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

    [SerializeField] private Image totalhealthBar;
    [SerializeField] private Image currenthealthBar;
    [SerializeField] private Image currenthealthBar2;
    [SerializeField] private Image currenthealthBar3;
    [SerializeField] private Image currenthealthBar4;
    [SerializeField] private Image currenthealthBar5;
    [SerializeField] private Image currenthealthBar6;
    [SerializeField] private Image currenthealthBar7;


    private void Start()
    {
        //totalhealthBar.fillAmount = playerHealth.currentHealth / 10;
        currenthealthBar2.gameObject.SetActive(false);
        currenthealthBar3.gameObject.SetActive(false);
        currenthealthBar4.gameObject.SetActive(false);
        currenthealthBar5.gameObject.SetActive(false);
        currenthealthBar6.gameObject.SetActive(false);
        currenthealthBar7.gameObject.SetActive(false);
        if (PlayerPrefs.GetString("Difficulty") == "Easy")
        {
            totalhealthBar.fillAmount = 4 / 10f;
        }
        if (PlayerPrefs.GetString("Difficulty") == "Normal")
        {
            totalhealthBar.fillAmount = 3 / 10f;
        }
        if (PlayerPrefs.GetString("Difficulty") == "Hard")
        {
            totalhealthBar.fillAmount = 1.5f / 10f;
        }
        if (PlayerPrefs.GetString("Difficulty") == "Brutal")
        {
            totalhealthBar.fillAmount = 0.5f / 10f;
        }
    }

    private void Update()
    {
        if (PlayerPrefs.HasKey("SantaRed"))
        {
            playerHealth = red1.GetComponent<Health90>();
            currenthealthBar.fillAmount = playerHealth.currentHealth / 10;

            if (red2.activeInHierarchy)
            {
                currenthealthBar.gameObject.SetActive(false);
                currenthealthBar2.gameObject.SetActive(true);
                playerHealth = red2.GetComponent<Health90>();
                playerHealth.currentHealth = red1.GetComponent<Health90>().currentHealth;
                currenthealthBar2.fillAmount = playerHealth.currentHealth / 10;
                red1 = red2;
            }
            if (red3.activeInHierarchy)
            {
                currenthealthBar2.gameObject.SetActive(false);
                currenthealthBar3.gameObject.SetActive(true);
                playerHealth = red3.GetComponent<Health90>();
                playerHealth.currentHealth = red2.GetComponent<Health90>().currentHealth;
                currenthealthBar3.fillAmount = playerHealth.currentHealth / 10;
                red2 = red3;
            }
            if (redRein.activeInHierarchy)
            {
                currenthealthBar3.gameObject.SetActive(false);
                currenthealthBar4.gameObject.SetActive(true);
                playerHealth = redRein.GetComponent<Health90>();
                playerHealth.currentHealth = red3.GetComponent<Health90>().currentHealth;
                currenthealthBar4.fillAmount = playerHealth.currentHealth / 10;
                red3 = redRein;
            }
            if (red4.activeInHierarchy)
            {
                currenthealthBar4.gameObject.SetActive(false);
                currenthealthBar5.gameObject.SetActive(true);
                playerHealth = red4.GetComponent<Health90>();
                playerHealth.currentHealth = redRein.GetComponent<Health90>().currentHealth;
                currenthealthBar5.fillAmount = playerHealth.currentHealth / 10;
                redRein = red4;
            }
            if (redReki.activeInHierarchy)
            {
                currenthealthBar5.gameObject.SetActive(false);
                currenthealthBar6.gameObject.SetActive(true);

                //rekiHealth = redReki.GetComponent<HealthReki>();
                //rekiHealth.currentHealth = redReki.GetComponent<HealthReki>().currentHealth;
                currenthealthBar6.fillAmount = rekiHealth.currentHealth / 10;
                //red4 = redReki;
            }
            if (red5.activeInHierarchy)
            {
                currenthealthBar6.gameObject.SetActive(false);
                currenthealthBar7.gameObject.SetActive(true);
                playerHealth = red5.GetComponent<Health90>();
                currenthealthBar7.fillAmount = playerHealth.currentHealth / 10;
                //redReki = red5;
            }
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            playerHealth = pink1.GetComponent<Health90>();
            rekiHealth = pinkReki.GetComponent<HealthReki>();
            currenthealthBar.fillAmount = playerHealth.currentHealth / 10;

            if (pink2.activeInHierarchy)
            {
                currenthealthBar.gameObject.SetActive(false);
                currenthealthBar2.gameObject.SetActive(true);
                playerHealth = pink2.GetComponent<Health90>();
                playerHealth.currentHealth = pink1.GetComponent<Health90>().currentHealth;
                currenthealthBar2.fillAmount = playerHealth.currentHealth / 10;
                pink1 = pink2;
            }
            if (pink3.activeInHierarchy)
            {
                currenthealthBar2.gameObject.SetActive(false);
                currenthealthBar3.gameObject.SetActive(true);
                playerHealth = pink3.GetComponent<Health90>();
                playerHealth.currentHealth = pink2.GetComponent<Health90>().currentHealth;
                currenthealthBar3.fillAmount = playerHealth.currentHealth / 10;
                pink2 = pink3;
            }
            if (pinkRein.activeInHierarchy)
            {
                currenthealthBar3.gameObject.SetActive(false);
                currenthealthBar4.gameObject.SetActive(true);
                playerHealth = pinkRein.GetComponent<Health90>();
                playerHealth.currentHealth = pink3.GetComponent<Health90>().currentHealth;
                currenthealthBar4.fillAmount = playerHealth.currentHealth / 10;
                pink3 = pinkRein;
            }
            if (pink4.activeInHierarchy)
            {
                currenthealthBar4.gameObject.SetActive(false);
                currenthealthBar5.gameObject.SetActive(true);
                playerHealth = pink4.GetComponent<Health90>();
                playerHealth.currentHealth = pinkRein.GetComponent<Health90>().currentHealth;
                currenthealthBar5.fillAmount = playerHealth.currentHealth / 10;
                pinkRein = pink4;
            }
            if (pinkReki.activeInHierarchy)
            {
                currenthealthBar5.gameObject.SetActive(false);
                currenthealthBar6.gameObject.SetActive(true);
                currenthealthBar6.fillAmount = rekiHealth.currentHealth / 10;
            }
            if (pink5.activeInHierarchy)
            {
                currenthealthBar6.gameObject.SetActive(false);
                currenthealthBar7.gameObject.SetActive(true);
                playerHealth = pink5.GetComponent<Health90>();
                currenthealthBar7.fillAmount = playerHealth.currentHealth / 10;
            }
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            playerHealth = blue1.GetComponent<Health90>();
            rekiHealth = blueReki.GetComponent<HealthReki>();
            currenthealthBar.fillAmount = playerHealth.currentHealth / 10;

            if (blue2.activeInHierarchy)
            {
                currenthealthBar.gameObject.SetActive(false);
                currenthealthBar2.gameObject.SetActive(true);
                playerHealth = blue2.GetComponent<Health90>();
                playerHealth.currentHealth = blue1.GetComponent<Health90>().currentHealth;
                currenthealthBar2.fillAmount = playerHealth.currentHealth / 10;
                blue1 = blue2;
            }
            if (blue3.activeInHierarchy)
            {
                currenthealthBar2.gameObject.SetActive(false);
                currenthealthBar3.gameObject.SetActive(true);
                playerHealth = blue3.GetComponent<Health90>();
                playerHealth.currentHealth = blue2.GetComponent<Health90>().currentHealth;
                currenthealthBar3.fillAmount = playerHealth.currentHealth / 10;
                blue2 = blue3;
            }
            if (blueRein.activeInHierarchy)
            {
                currenthealthBar3.gameObject.SetActive(false);
                currenthealthBar4.gameObject.SetActive(true);
                playerHealth = blueRein.GetComponent<Health90>();
                playerHealth.currentHealth = blue3.GetComponent<Health90>().currentHealth;
                currenthealthBar4.fillAmount = playerHealth.currentHealth / 10;
                blue3 = blueRein;
            }
            if (blue4.activeInHierarchy)
            {
                currenthealthBar4.gameObject.SetActive(false);
                currenthealthBar5.gameObject.SetActive(true);
                playerHealth = blue4.GetComponent<Health90>();
                playerHealth.currentHealth = blueRein.GetComponent<Health90>().currentHealth;
                currenthealthBar5.fillAmount = playerHealth.currentHealth / 10;
                blueRein = blue4;
            }
            if (blueReki.activeInHierarchy)
            {
                currenthealthBar5.gameObject.SetActive(false);
                currenthealthBar6.gameObject.SetActive(true);
                currenthealthBar6.fillAmount = rekiHealth.currentHealth / 10;
            }
            if (blue5.activeInHierarchy)
            {
                currenthealthBar6.gameObject.SetActive(false);
                currenthealthBar7.gameObject.SetActive(true);
                playerHealth = blue5.GetComponent<Health90>();
                currenthealthBar7.fillAmount = playerHealth.currentHealth / 10;
            }
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            playerHealth = orange1.GetComponent<Health90>();
            rekiHealth = orangeReki.GetComponent<HealthReki>();
            currenthealthBar.fillAmount = playerHealth.currentHealth / 10;

            if (orange2.activeInHierarchy)
            {
                currenthealthBar.gameObject.SetActive(false);
                currenthealthBar2.gameObject.SetActive(true);
                playerHealth = orange2.GetComponent<Health90>();
                playerHealth.currentHealth = orange1.GetComponent<Health90>().currentHealth;
                currenthealthBar2.fillAmount = playerHealth.currentHealth / 10;
                orange1 = orange2;
            }
            if (orange3.activeInHierarchy)
            {
                currenthealthBar2.gameObject.SetActive(false);
                currenthealthBar3.gameObject.SetActive(true);
                playerHealth = orange3.GetComponent<Health90>();
                playerHealth.currentHealth = orange2.GetComponent<Health90>().currentHealth;
                currenthealthBar3.fillAmount = playerHealth.currentHealth / 10;
                orange2 = orange3;
            }
            if (orangeRein.activeInHierarchy)
            {
                currenthealthBar3.gameObject.SetActive(false);
                currenthealthBar4.gameObject.SetActive(true);
                playerHealth = orangeRein.GetComponent<Health90>();
                playerHealth.currentHealth = orange3.GetComponent<Health90>().currentHealth;
                currenthealthBar4.fillAmount = playerHealth.currentHealth / 10;
                orange3 = orangeRein;
            }
            if (orange4.activeInHierarchy)
            {
                currenthealthBar4.gameObject.SetActive(false);
                currenthealthBar5.gameObject.SetActive(true);
                playerHealth = orange4.GetComponent<Health90>();
                playerHealth.currentHealth = orangeRein.GetComponent<Health90>().currentHealth;
                currenthealthBar5.fillAmount = playerHealth.currentHealth / 10;
                orangeRein = orange4;
            }
            if (orangeReki.activeInHierarchy)
            {
                currenthealthBar5.gameObject.SetActive(false);
                currenthealthBar6.gameObject.SetActive(true);
                currenthealthBar6.fillAmount = rekiHealth.currentHealth / 10;
            }
            if (orange5.activeInHierarchy)
            {
                currenthealthBar6.gameObject.SetActive(false);
                currenthealthBar7.gameObject.SetActive(true);
                playerHealth = orange5.GetComponent<Health90>();
                currenthealthBar7.fillAmount = playerHealth.currentHealth / 10;
            }
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            playerHealth = green1.GetComponent<Health90>();
            rekiHealth = greenReki.GetComponent<HealthReki>();
            currenthealthBar.fillAmount = playerHealth.currentHealth / 10;

            if (green2.activeInHierarchy)
            {
                currenthealthBar.gameObject.SetActive(false);
                currenthealthBar2.gameObject.SetActive(true);
                playerHealth = green2.GetComponent<Health90>();
                playerHealth.currentHealth = green1.GetComponent<Health90>().currentHealth;
                currenthealthBar2.fillAmount = playerHealth.currentHealth / 10;
                green1 = green2;
            }
            if (green3.activeInHierarchy)
            {
                currenthealthBar2.gameObject.SetActive(false);
                currenthealthBar3.gameObject.SetActive(true);
                playerHealth = green3.GetComponent<Health90>();
                playerHealth.currentHealth = green2.GetComponent<Health90>().currentHealth;
                currenthealthBar3.fillAmount = playerHealth.currentHealth / 10;
                green2 = green3;
            }
            if (greenRein.activeInHierarchy)
            {
                currenthealthBar3.gameObject.SetActive(false);
                currenthealthBar4.gameObject.SetActive(true);
                playerHealth = greenRein.GetComponent<Health90>();
                playerHealth.currentHealth = green3.GetComponent<Health90>().currentHealth;
                currenthealthBar4.fillAmount = playerHealth.currentHealth / 10;
                green3 = greenRein;
            }
            if (green4.activeInHierarchy)
            {
                currenthealthBar4.gameObject.SetActive(false);
                currenthealthBar5.gameObject.SetActive(true);
                playerHealth = green4.GetComponent<Health90>();
                playerHealth.currentHealth = greenRein.GetComponent<Health90>().currentHealth;
                currenthealthBar5.fillAmount = playerHealth.currentHealth / 10;
                greenRein = green4;
            }
            if (greenReki.activeInHierarchy)
            {
                currenthealthBar5.gameObject.SetActive(false);
                currenthealthBar6.gameObject.SetActive(true);
                currenthealthBar6.fillAmount = rekiHealth.currentHealth / 10;
            }
            if (green5.activeInHierarchy)
            {
                currenthealthBar6.gameObject.SetActive(false);
                currenthealthBar7.gameObject.SetActive(true);
                playerHealth = green5.GetComponent<Health90>();
                currenthealthBar7.fillAmount = playerHealth.currentHealth / 10;
            }
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            playerHealth = purple1.GetComponent<Health90>();
            rekiHealth = blueReki.GetComponent<HealthReki>();
            currenthealthBar.fillAmount = playerHealth.currentHealth / 10;

            if (purple2.activeInHierarchy)
            {
                currenthealthBar.gameObject.SetActive(false);
                currenthealthBar2.gameObject.SetActive(true);
                playerHealth = purple2.GetComponent<Health90>();
                playerHealth.currentHealth = purple1.GetComponent<Health90>().currentHealth;
                currenthealthBar2.fillAmount = playerHealth.currentHealth / 10;
                purple1 = purple2;
            }
            if (purple3.activeInHierarchy)
            {
                currenthealthBar2.gameObject.SetActive(false);
                currenthealthBar3.gameObject.SetActive(true);
                playerHealth = purple3.GetComponent<Health90>();
                playerHealth.currentHealth = purple2.GetComponent<Health90>().currentHealth;
                currenthealthBar3.fillAmount = playerHealth.currentHealth / 10;
                purple2 = purple3;
            }
            if (purpleRein.activeInHierarchy)
            {
                currenthealthBar3.gameObject.SetActive(false);
                currenthealthBar4.gameObject.SetActive(true);
                playerHealth = purpleRein.GetComponent<Health90>();
                playerHealth.currentHealth = purple3.GetComponent<Health90>().currentHealth;
                currenthealthBar4.fillAmount = playerHealth.currentHealth / 10;
                purple3 = purpleRein;
            }
            if (purple4.activeInHierarchy)
            {
                currenthealthBar4.gameObject.SetActive(false);
                currenthealthBar5.gameObject.SetActive(true);
                playerHealth = purple4.GetComponent<Health90>();
                playerHealth.currentHealth = purpleRein.GetComponent<Health90>().currentHealth;
                currenthealthBar5.fillAmount = playerHealth.currentHealth / 10;
                purpleRein = purple4;
            }
            if (purpleReki.activeInHierarchy)
            {
                currenthealthBar5.gameObject.SetActive(false);
                currenthealthBar6.gameObject.SetActive(true);
                currenthealthBar6.fillAmount = rekiHealth.currentHealth / 10;
            }
            if (purple5.activeInHierarchy)
            {
                currenthealthBar6.gameObject.SetActive(false);
                currenthealthBar7.gameObject.SetActive(true);
                playerHealth = purple5.GetComponent<Health90>();
                currenthealthBar7.fillAmount = playerHealth.currentHealth / 10;
            }
        }
    }
}
