using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController91 : MonoBehaviour
{
    private int nextSceneLoad;
    public static bool isFading;
    public float FadeTime = 3f;
    public AudioSource audioSource;
    public bool levelBeat = false;

    public GameObject tryAgainButton;
    public GameObject backButton;
    CandyCane candyCane;
    public GameObject candy;

    private void Start()
    {
        //nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
        levelBeat = false;
        tryAgainButton.SetActive(false);
        backButton.SetActive(false);
        candyCane = candy.GetComponent<CandyCane>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" || collision.tag == "Reindeer" || collision.tag == "Sleigh")
        {
            string activeScene = SceneManager.GetActiveScene().name;
            PlayerPrefs.SetString("LevelComplete32", activeScene);
            if (Time.timeSinceLevelLoad >= 189f)
            {
                StartCoroutine(BadEnd());
            }
            if (Time.timeSinceLevelLoad < 189f && candyCane.foundCandy == false)
            {
                StartCoroutine(BadEnd());
            }
            if (Time.timeSinceLevelLoad < 189f && candyCane.foundCandy)
            {
                StartCoroutine(venaaTovi());
            }
            
            StartCoroutine(FadeOut());
        }
    }
    IEnumerator venaaTovi()
    {
        tryAgainButton.SetActive(false);
        backButton.SetActive(false);
        PlayerPrefs.SetString("Hype1", "Hype1");
        yield return new WaitForSeconds(5.5f);
        levelBeat = true;
        SceneManager.LoadScene("OverLevel1", LoadSceneMode.Single);
        //SceneManager.LoadScene(nextSceneLoad);    
    }

    IEnumerator BadEnd()
    {
        yield return new WaitForSeconds(1.5f);
        tryAgainButton.SetActive(true);
        backButton.SetActive(true);
    }
    IEnumerator FadeOut()
    {
        isFading = true;
        float startVolume = audioSource.volume;
        while (audioSource.volume > 0)
        {
            audioSource.volume -= startVolume * Time.deltaTime / FadeTime;
            yield return null;
        }
        audioSource.Stop();
        audioSource.volume = startVolume;
        isFading = false;
    }
}
