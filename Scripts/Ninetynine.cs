using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ninetynine : MonoBehaviour
{
    public AudioSource successSound;
    public GameObject Panel;
    LifeLev90 life;
    public GameObject canvasLife;

    private void Start()
    {
        life = canvasLife.GetComponent<LifeLev90>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerPrefs.SetString("NinetyNine", "NinetyNine");
            PlayerPrefs.SetString("LifeYes", "LifeYes");
            successSound.Play();
            Panel.SetActive(true);
            life.lives = 99;
            life.lifeText.text = "x " + life.lives.ToString();
            life.lifeText.color = Color.white;
        }
    }
}
