using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarReki : MonoBehaviour
{
    [SerializeField] public HealthReki playerHealth;
    public GameObject red;
    public GameObject pink;
    public GameObject blue;
    public GameObject orange;
    public GameObject green;
    public GameObject purple;
    [SerializeField] private Image totalhealthBar;
    [SerializeField] private Image currenthealthBar;

    private void Awake()
    {
        if (PlayerPrefs.HasKey("SantaRed"))
        {
            playerHealth = red.GetComponent<HealthReki>();
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            playerHealth = pink.GetComponent<HealthReki>();
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            playerHealth = blue.GetComponent<HealthReki>();
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            playerHealth = orange.GetComponent<HealthReki>();
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            playerHealth = green.GetComponent<HealthReki>();
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            playerHealth = purple.GetComponent<HealthReki>();
        }
    }

    private void Update()
    {
        if (PlayerPrefs.HasKey("SantaRed"))
        {
            currenthealthBar.fillAmount = playerHealth.currentHealth / 10;
            totalhealthBar.fillAmount = playerHealth.startingHealth / 10;
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            currenthealthBar.fillAmount = playerHealth.currentHealth / 10;
            totalhealthBar.fillAmount = playerHealth.startingHealth / 10;
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            currenthealthBar.fillAmount = playerHealth.currentHealth / 10;
            totalhealthBar.fillAmount = playerHealth.startingHealth / 10;
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            currenthealthBar.fillAmount = playerHealth.currentHealth / 10;
            totalhealthBar.fillAmount = playerHealth.startingHealth / 10;
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            currenthealthBar.fillAmount = playerHealth.currentHealth / 10;
            totalhealthBar.fillAmount = playerHealth.startingHealth / 10;
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            currenthealthBar.fillAmount = playerHealth.currentHealth / 10;
            totalhealthBar.fillAmount = playerHealth.startingHealth / 10;
        }
    }
}

