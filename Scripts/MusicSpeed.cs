using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSpeed : MonoBehaviour
{
    public AudioSource music;
    private bool isTouch = false;
    public BoxCollider2D bx;
    public GameObject pauseCanvas;
    private SpriteRenderer sprite;
    public Health health;

    public GameObject red;
    public GameObject pink;
    public GameObject blue;
    public GameObject orange;
    public GameObject green;
    public GameObject purple;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        if (PlayerPrefs.HasKey("SantaRed"))
        {
            red.SetActive(true);
            pink.SetActive(false);
            blue.SetActive(false);
            orange.SetActive(false);
            green.SetActive(false);
            purple.SetActive(false);
            health = red.GetComponent<Health>();
        }

        if (PlayerPrefs.HasKey("SantaPink")) 
        {
            red.SetActive(false);
            pink.SetActive(true);
            blue.SetActive(false);
            orange.SetActive(false);
            green.SetActive(false);
            purple.SetActive(false);
            health = pink.GetComponent<Health>();
        }
        if (PlayerPrefs.HasKey("SantaBlue")) 
        {
            red.SetActive(false);
            pink.SetActive(false);
            blue.SetActive(true);
            orange.SetActive(false);
            green.SetActive(false);
            purple.SetActive(false);
            health = blue.GetComponent<Health>();
        }

        if (PlayerPrefs.HasKey("SantaOrange")) 
        {
            red.SetActive(false);
            pink.SetActive(false);
            blue.SetActive(false);
            orange.SetActive(true);
            green.SetActive(false);
            purple.SetActive(false);
            health = orange.GetComponent<Health>();
        }

        if (PlayerPrefs.HasKey("SantaGreen")) 
        {
            red.SetActive(false);
            pink.SetActive(false);
            blue.SetActive(false);
            orange.SetActive(false);
            green.SetActive(true);
            purple.SetActive(false);
            health = green.GetComponent<Health>();
        }

        if (PlayerPrefs.HasKey("SantaPurple")) 
        {
            red.SetActive(false);
            pink.SetActive(false);
            blue.SetActive(false);
            orange.SetActive(false);
            green.SetActive(false);
            purple.SetActive(true);
            health = purple.GetComponent<Health>();
        }

       
    }

    private void Update()
    {
        if (health.dead)
        {
            music.pitch = 1;     
        }  
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (!isTouch)
            {
                music.pitch = 1.2f;
                isTouch = true;
                bx.enabled = false;
                sprite.enabled = false;
            }    
        }
    }
}
