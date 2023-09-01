using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateLightning : MonoBehaviour
{
    [SerializeField] private AudioSource lightningSound;
    [SerializeField] private AudioSource laughSound;
    //public GameObject lightning;
    public GameObject hyvaKuusi;
    public GameObject paloKuusi;
    public GameObject burnedGround;
    private bool hasStrike = false;

    void Start()
    {
        //lightning.SetActive(false);
        paloKuusi.SetActive(false);
        burnedGround.SetActive(false);
    }

    void Update()
    {
        if (PlayerPrefs.HasKey("LevelComplete17") && !PlayerPrefs.HasKey("Salama"))
        {
            StartCoroutine(Salama());
        }
        if (PlayerPrefs.HasKey("Salama"))
        {
            paloKuusi.SetActive(true);
            hyvaKuusi.SetActive(false);
            burnedGround.SetActive(true);
            //lightning.SetActive(false);
        }
    }
    IEnumerator Salama()
    {     
        yield return new WaitForSeconds(2.75f);
        if (!hasStrike)
        {
            lightningSound.Play();
            hasStrike = true;
        }
        //lightning.SetActive(true);
        StartCoroutine(Resultti());

    }
    IEnumerator Resultti()
    {
        yield return new WaitForSeconds(0.3f);
        PlayerPrefs.SetString("Salama1", "Salama1");
        yield return new WaitForSeconds(0.15f);
        paloKuusi.SetActive(true);
        hyvaKuusi.SetActive(false);
        burnedGround.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        PlayerPrefs.SetString("Salama", "Salama");
        yield return new WaitForSeconds(2f);
        laughSound.Play();
    }
}
