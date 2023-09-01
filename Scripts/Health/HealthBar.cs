using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] public Health playerHealth;
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
            playerHealth = red.GetComponent<Health>();
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            playerHealth = pink.GetComponent<Health>();
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            playerHealth = blue.GetComponent<Health>();
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            playerHealth = orange.GetComponent<Health>();
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            playerHealth = green.GetComponent<Health>();
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            playerHealth = purple.GetComponent<Health>();
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
