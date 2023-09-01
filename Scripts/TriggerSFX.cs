using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSFX : MonoBehaviour
{
    public AudioSource playSound;
    [SerializeField] private AudioSource fireWorkSound;
    [SerializeField] ParticleSystem particleSystem;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        playSound.Play();
        StartCoroutine(FireWork());
    }
    IEnumerator FireWork()
    {
        yield return new WaitForSeconds(0.8f);
        particleSystem.Play();
        fireWorkSound.Play();
    }
}
