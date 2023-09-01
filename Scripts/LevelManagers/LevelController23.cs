using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController23 : MonoBehaviour
{
    private int nextSceneLoad;
    public static bool isFading;
    public float FadeTime = 3f;
    public AudioSource audioSource;
    public bool levelBeat = false;
    public AudioSource fastAudio;

    private void Start()
    {
        //nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
        levelBeat = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" || collision.tag == "Reindeer" || collision.tag == "Sleigh")
        {
            string activeScene = SceneManager.GetActiveScene().name;
            PlayerPrefs.SetString("LevelComplete6", activeScene);
            StartCoroutine(venaaTovi());
            StartCoroutine(FadeOut());
            StartCoroutine(FadeOut2());
        }
    }
    IEnumerator venaaTovi()
    {
        yield return new WaitForSeconds(5.5f);
        levelBeat = true;
        SceneManager.LoadScene("OverLevel1", LoadSceneMode.Single);
        //SceneManager.LoadScene(nextSceneLoad);    
    }
    IEnumerator FadeOut2()
    {
        isFading = true;
        float startVolume = fastAudio.volume;
        while (fastAudio.volume > 0)
        {
            fastAudio.volume -= startVolume * Time.deltaTime / FadeTime;
            yield return null;
        }
        fastAudio.Stop();
        fastAudio.volume = startVolume;
        isFading = false;
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

