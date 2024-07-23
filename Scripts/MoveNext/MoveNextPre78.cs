using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNextPre78 : MonoBehaviour
{
    public GameObject timeline;
    public GameObject Player;
    public AudioSource audio;
    public static bool isFading;
    public float FadeTime = 1.5f;
    public GameObject controlsCanvas;
    public GameObject levelManager;
    public GameObject blackCanvas;

    private void Start()
    {
        timeline.SetActive(false);
        controlsCanvas.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Player.SetActive(false);
            controlsCanvas.SetActive(false);
            StartCoroutine(FadeOut());
            StartCoroutine(LataaLv());
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
    IEnumerator LataaLv()
    {
        yield return new WaitForSeconds(1.5f);
        levelManager.SetActive(true);
    }
}
