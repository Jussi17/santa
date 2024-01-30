using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaSplash : MonoBehaviour
{
    public GameObject splash;
    private AudioSource splashSound;
    void Start()
    {
        splash.SetActive(false);
        splashSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Puu")
        {
            splash.SetActive(true);
            splashSound.Play();
            StartCoroutine("OffSplash");
        }
    }
    IEnumerator OffSplash()
    {
        yield return new WaitForSeconds(0.8f);
        splash.SetActive(false);
    }
}
