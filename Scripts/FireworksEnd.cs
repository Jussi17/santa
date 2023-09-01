using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireworksEnd : MonoBehaviour
{
    public GameObject firework1;
    public GameObject firework2;
    public GameObject firework3;
    public GameObject firework4;
    [SerializeField] private AudioSource fireworkSound;
    private bool hasPlayed1 = false;
    private bool hasPlayed2 = false;
    private bool hasPlayed3 = false;
    private bool hasPlayed4 = false;

    void Start()
    {
        firework1.SetActive(false);
        firework2.SetActive(false);
        firework3.SetActive(false);
        firework4.SetActive(false);
    }

    void Update()
    {
        if (PlayerPrefs.HasKey("Finaali2") && !PlayerPrefs.HasKey("EndFireworks"))
        {
            StartCoroutine(Fireworkit());
        }
    }
    IEnumerator Fireworkit()
    {
        yield return new WaitForSeconds(2.92f);
        if (!hasPlayed1)
        {
            firework1.SetActive(true);
            fireworkSound.Play();
            hasPlayed1 = true;
        } 
        yield return new WaitForSeconds(2.3f);
        if (!hasPlayed2)
        {
            firework2.SetActive(true);
            fireworkSound.Play();
            hasPlayed2 = true;
        } 
        yield return new WaitForSeconds(2.3f);
        if (!hasPlayed3)
        {
            firework3.SetActive(true);
            fireworkSound.Play();
            hasPlayed3 = true;
        }   
        yield return new WaitForSeconds(2.3f);
        if (!hasPlayed4)
        {
            firework4.SetActive(true);
            fireworkSound.Play();
            hasPlayed4 = true;
        } 
        PlayerPrefs.SetString("EndFireworks", "EndFireworks");
    }
}
