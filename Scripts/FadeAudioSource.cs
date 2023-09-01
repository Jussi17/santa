using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public static class FadeAudioSource
{
    public static bool isFading;
    public static IEnumerator FadeOut(AudioSource audioSource, float FadeTime)
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