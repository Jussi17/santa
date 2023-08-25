using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsInitializeCut : MonoBehaviour, IUnityAdsInitializationListener, IUnityAdsLoadListener, IUnityAdsShowListener
{
    [SerializeField] string androidGameId;
    [SerializeField] string iosGameId;
    string gameId;
    [SerializeField] bool testMode = true;
    private bool adPlayed = false;
    public GameObject loadText;
    public GameObject adText;
    [SerializeField] private AudioListener audio;

    private void Awake()
    {
        audio.enabled = false;
         loadText.SetActive(false);
         Time.timeScale = 0;
         if (Advertisement.isInitialized)
         {
             Debug.Log("Advertisement is initialised");
             LoadInerstitialAd();
         }
         else
         {
             InitializeAds();
         }
     
    }
    private void Start()
    {
         if (!adPlayed)
         {
             Time.timeScale = 0;
         }          
    }
    private void Update()
    {
        if (!adPlayed)
        {
            Time.timeScale = 0;
        }

        if (adPlayed)
        {
            loadText.SetActive(true);
            adText.SetActive(false);
            Time.timeScale = 1;
            audio.enabled = true;
            OnAudioReset();
        }
    }
    public void OnAudioReset()
    {
        AudioSettings.Reset(AudioSettings.GetConfiguration());
    }

    public void InitializeAds()
    {
        gameId = (Application.platform == RuntimePlatform.IPhonePlayer) ? iosGameId : androidGameId;
        Advertisement.Initialize(gameId, testMode, this);
    }

    public void OnInitializationComplete()
    {
        Debug.Log("Unity Ads initialization complete.");
        LoadInerstitialAd();
    }

    public void OnInitializationFailed(UnityAdsInitializationError error, string message)
    {
        Debug.Log($"Unity Ads initialization failed:  {error.ToString()} - {message}");
    }
    public void LoadInerstitialAd()
    {
        Time.timeScale = 0;
        Advertisement.Load("Interstitial_Android", this);
    }

    public void OnUnityAdsAdLoaded(string placementId)
    {
        Debug.Log("OnUnityAdLoaded");
        Advertisement.Show(placementId, this);
    }

    public void OnUnityAdsFailedToLoad(string placementId, UnityAdsLoadError error, string message)
    {
        Debug.Log($"Error showing Ad Unit{placementId}:  {error.ToString()} - {message}");
    }

    public void OnUnityAdsShowFailure(string placementId, UnityAdsShowError error, string message)
    {
        Debug.Log("OnUnityAdShowFailure");
    }

    public void OnUnityAdsShowStart(string placementId)
    {
        Debug.Log("OnUnityAdShowStart");
        Time.timeScale = 0;
    }

    public void OnUnityAdsShowClick(string placementId)
    {
        Debug.Log("OnUnityAdShowClick");
    }

    public void OnUnityAdsShowComplete(string placementId, UnityAdsShowCompletionState showCompletionState)
    {
        Debug.Log("OnUnityAdShowComplete");
        adPlayed = true;
        Time.timeScale = 1;
    }
}
