using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyCane : MonoBehaviour
{
    public bool foundCandy = false;
    [SerializeField] private AudioSource hohoSound;
    public Renderer rend;
    public GameObject darkCandy;
    public GameObject lightCandy;
    public GameObject candyEffect;
    private bool hasPlayed = false;

    private void Start()
    {
        darkCandy.SetActive(true);
        lightCandy.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Reindeer")
        {
            rend.enabled = false;
            if (!hasPlayed)
            {
                hohoSound.Play();
                hasPlayed = true;
            }
            
            foundCandy = true;
            lightCandy.SetActive(true);
            darkCandy.SetActive(false);
            candyEffect.SetActive(false);
        }
    }
}
