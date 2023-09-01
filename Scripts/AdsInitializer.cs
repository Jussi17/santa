using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsInitializer : MonoBehaviour, IUnityAdsInitializationListener,IUnityAdsLoadListener, IUnityAdsShowListener
{
    [SerializeField] string androidGameId;
    [SerializeField] string iosGameId;
    string gameId;
    [SerializeField] bool testMode = true;
    [SerializeField] private AudioSource music;
    public bool adPlayed = false;
    public GameObject adObject;

    private void Awake()
    {
        if (!PlayerPrefs.HasKey("Upgraded"))
        {
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
    }
    private void Start()
    {
        if (!PlayerPrefs.HasKey("Upgraded"))
        {
            if (!adPlayed)
            {
                music.Pause();
                Time.timeScale = 0;
            }
        }
    }
    private void Update()
    {
        if (!PlayerPrefs.HasKey("Upgraded"))
        {
            if (!adPlayed)
            {
                music.Pause();
                Time.timeScale = 0;
            }          
        }
        if (adPlayed)
        {
            if (!music.isPlaying)
            {
                music.Play();
                Debug.Log("Musiikki haettu Updatesta");
                StartCoroutine(PoistaAd());
            }
        }
        if (PlayerPrefs.HasKey("Upgraded"))
        {
            adObject.SetActive(false);
        }
    }
    IEnumerator PoistaAd()
    {
        yield return new WaitForSeconds(0.8f);
        adObject.SetActive(false);
    }
    public void InitializeAds()
    {
        if (!PlayerPrefs.HasKey("Upgraded"))
        {
            gameId = (Application.platform == RuntimePlatform.IPhonePlayer) ? iosGameId : androidGameId;
            Advertisement.Initialize(gameId, testMode, this);
        }
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
        if (!PlayerPrefs.HasKey("Upgraded"))
        {
            Time.timeScale = 0;
            Advertisement.Load("Interstitial_Android", this);
        }
    }

    public void OnUnityAdsAdLoaded(string placementId)
    {
        Debug.Log("OnUnityAdLoaded");
        Advertisement.Show(placementId,this);
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
        Time.timeScale = 1;
        adPlayed = true;
        StartCoroutine(StartMusic());
    }
    IEnumerator StartMusic()
    {
        yield return new WaitForSeconds(0.4f);
        if (!music.isPlaying)
        {
            music.Play();
            Debug.Log("Musiikki haettu CoRutiinista");
        }      
    }
}
