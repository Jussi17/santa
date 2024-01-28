using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boots : MonoBehaviour
{
    public AudioSource successSound;
    public GameObject Panel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerPrefs.SetString("SpeedBoots", "SpeedBoots");
            PlayerPrefs.SetString("SpeedYes", "SpeedYes");
            successSound.Play();
            Panel.SetActive(true);
        }
    }
}
