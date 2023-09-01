using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UfoAd : MonoBehaviour
{
    AdsInitializer ads;
    public GameObject adObject;
    [SerializeField] private AudioSource ufoSound;
    private bool ufoPlayed = false;

    void Start()
    {
        ads = adObject.GetComponent<AdsInitializer>();     
    }

    void Update()
    {
        if (PlayerPrefs.HasKey("Upgraded"))
        {
            if (!ufoPlayed)
            {
                StartCoroutine(PlayUfoSound());
            }        
        }
        if (!PlayerPrefs.HasKey("Upgraded"))
        {
            if (!ufoPlayed)
            {
                if (ads.adPlayed)
                {
                    StartCoroutine(PlayUfoSound());
                }
            }
        }
    }
    IEnumerator PlayUfoSound()
    {
        yield return new WaitForSeconds(0.32f);
        ufoSound.Play();
        ufoPlayed = true;
    }
}
