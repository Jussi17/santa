using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Club : MonoBehaviour
{
    [SerializeField] private AudioSource ufoSound;
    private bool hasPlayed;
    public GameObject club;
    public GameObject club2;

    private void Start()
    {
        club.SetActive(false);
        club2.SetActive(false);
    }
    private void Update()
    {
        if (PlayerPrefs.HasKey("LevelComplete30") && !PlayerPrefs.HasKey("LevelComplete31"))
        {
            club.SetActive(true);
            club2.SetActive(true);
        }
        if (PlayerPrefs.HasKey("LevelComplete31"))
        {
            club.SetActive(false);
            club2.SetActive(false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && !PlayerPrefs.HasKey("Club"))
        {
            if (!hasPlayed)
            {
                ufoSound.Play();
                hasPlayed = true;
                PlayerPrefs.SetString("Club", "Club");
            }         
        }
    }
}
