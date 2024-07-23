using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNext23 : MonoBehaviour
{
    public GameObject timeline2;
    public GameObject Player;
    public AudioSource audio;
    public static bool isFading;
    public float FadeTime = 1.5f;
    public GameObject dashButton;
    public GameObject controlsCanvas;

    private void Start()
    {
        dashButton.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            timeline2.SetActive(true);
            Player.SetActive(false);
            controlsCanvas.SetActive(false);
            StartCoroutine(FadeOut());
        }
    }

    IEnumerator FadeOut()
    {
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
    public void OnDashActivate()
    {
        dashButton.SetActive(true);
    }
}
