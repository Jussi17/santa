using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController32 : MonoBehaviour
{
    private int nextSceneLoad;
    public static bool isFading;
    public float FadeTime = 3f;
    public AudioSource audioSource;
    public bool levelBeat = false;

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
            PlayerPrefs.SetString("LevelComplete9", activeScene);
            StartCoroutine(venaaTovi());
            StartCoroutine(FadeOut());
        }
    }
    IEnumerator venaaTovi()
    {
        yield return new WaitForSeconds(5.5f);
        levelBeat = true;
        SceneManager.LoadScene("OverLevel1", LoadSceneMode.Single);
        //SceneManager.LoadScene(nextSceneLoad);    
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
