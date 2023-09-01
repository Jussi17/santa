using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepSoundAd : MonoBehaviour
{
    [SerializeField] private AudioSource runSound;
    AdsInitializer ads;
    public GameObject adObject;
    void Start()
    {
        ads = adObject.GetComponent<AdsInitializer>();
    }

    void Update()
    {
        if (!PlayerPrefs.HasKey("Upgraded"))
        {
            if (ads.adPlayed == false)
            {
                runSound.enabled = false;
            }
            if (ads.adPlayed)
            {
                runSound.enabled = true;
            }
        }
    }
}
