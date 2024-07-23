using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;

public class MoveNextPre45 : MonoBehaviour
{
    public GameObject Player;
    public AudioSource audio;
    public static bool isFading;
    public float FadeTime = 1.5f;
    public GameObject controlsCanvas;
    public GameObject blackCanvas;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Reindeer")
        {
            Player.SetActive(false);
            controlsCanvas.SetActive(false);
            StartCoroutine(FadeOut());
            StartCoroutine(NextScene());
        }
    }

    IEnumerator FadeOut()
    {
        blackCanvas.SetActive(true);
        isFading = true;
        float startVolume = audio.volume;
        while (audio.volume > 0)
        {
            audio.volume -= startVolume * Time.deltaTime / FadeTime;
            yield return null;
        }
        audio.Stop();
        audio.volume = startVolume;
        isFading = false;
    }
    IEnumerator NextScene()
    {
        yield return new WaitForSeconds(1.5f);
        PlayerPrefs.SetString("AcutPre4", "AcutPre4");
        if (PlayerPrefs.HasKey("Upgraded"))
        {
            if (PlayerPrefs.HasKey("Cutti"))
            {
                SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
            }
            if (!PlayerPrefs.HasKey("Cutti"))
            {
                SceneManager.LoadScene("Cut4-5", LoadSceneMode.Single);
            }
        }
        if (!PlayerPrefs.HasKey("Upgraded"))
        {
            if (PlayerPrefs.HasKey("Cutti"))
            {
                SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
            }
            if (!PlayerPrefs.HasKey("Cutti"))
            {
                SceneManager.LoadScene("Vali4-5", LoadSceneMode.Single);
            }
        }
    }
}
