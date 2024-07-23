using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNext78 : MonoBehaviour
{
    public GameObject Player;
    public AudioSource audio;
    public static bool isFading;
    public float FadeTime = 1.5f;
    public GameObject controlsCanvas;
    public GameObject levelManager;
    public GameObject timeline;
    public GameObject isoGoblin;
    EnemyPatrol enemyPatrol;
    MeleeGoblin meleeGoblin;
    public GameObject blackCanvas;

    private void Start()
    {
        enemyPatrol = isoGoblin.GetComponent<EnemyPatrol>();
        meleeGoblin = isoGoblin.GetComponent<MeleeGoblin>();
        timeline.SetActive(false);
        controlsCanvas.SetActive(true);
        enemyPatrol.enabled = true;
        meleeGoblin.enabled = true;
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
        isFading = true;
        blackCanvas.SetActive(true);
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
