using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurnSleigh : MonoBehaviour
{
    public GameObject fireSleigh;
    public GameObject normalSleigh;
    public GameObject normalFire;
    public GameObject normalKuusi;
    public GameObject burnedKuusi;
    public GameObject burnedReki;
    public GameObject burnedGround;
    public GameObject burnedGroundFinal;
    [SerializeField] private AudioSource blastSound;
    private bool hasPlayed = false;
    void Start()
    {
        fireSleigh.SetActive(false);
        normalSleigh.SetActive(true);
        normalFire.SetActive(true);
        normalKuusi.SetActive(true);
        burnedKuusi.SetActive(false);
        burnedReki.SetActive(false);
        burnedGround.SetActive(false);
        burnedGroundFinal.SetActive(false);
    }

    void Update()
    {
        if (PlayerPrefs.HasKey("LevelComplete"))
        {
            fireSleigh.SetActive(true);
            normalSleigh.SetActive(false);
            normalFire.SetActive(false);
            normalKuusi.SetActive(false);
            burnedKuusi.SetActive(true);
            burnedReki.SetActive(true);
            burnedGround.SetActive(true);
            if (!PlayerPrefs.HasKey("Burned"))
            {
                StartCoroutine(Blasting());
            }          
        }
        if (PlayerPrefs.HasKey("LevelComplete10"))
        {
            fireSleigh.SetActive(false);
            burnedKuusi.SetActive(false);
            burnedReki.SetActive(false);
            burnedGroundFinal.SetActive(true);
        }
    }
    IEnumerator Blasting()
    {
        yield return new WaitForSeconds(1f);
        if (!hasPlayed)
        {
            blastSound.Play();
            hasPlayed = true;
        }
        
        PlayerPrefs.SetString("Burned", "Burned");
    }
}
