using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNextIntro2 : MonoBehaviour
{
    public GameObject canvas;
    public GameObject timeline2;
    public GameObject Player;
    public AudioSource audio;
    public static bool isFading;
    public float FadeTime = 1.5f;
    void Start()
    {
        canvas.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            timeline2.SetActive(true);
            canvas.SetActive(false);
            Player.SetActive(false);
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
}
