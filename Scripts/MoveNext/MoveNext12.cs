using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveNext12 : MonoBehaviour
{
    public GameObject warningCanvas;
    public GameObject timeline2;
    public GameObject Player;
    public AudioSource audio;
    public static bool isFading;
    public float FadeTime = 1.5f;
    private CapsuleCollider2D cp;
    public bool hasDoubleJumped = false;
    Movement2 mv2;
    public AudioSource clappyAudio;
    private bool hasLaughed = false;
    void Start()
    {
        cp = GetComponent<CapsuleCollider2D>();
        mv2 = Player.GetComponentInChildren<Movement2>();
        clappyAudio.enabled = false;
    }

    private void Update()
    {
        if (mv2.jumpsLeft == 0)
        {
            hasDoubleJumped = true;
        }
        if (hasDoubleJumped == true)
        {
            cp.enabled = false;
            if (!hasLaughed)
            {
                clappyAudio.enabled = true;
                hasLaughed = true;
            }

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            timeline2.SetActive(true);
            Player.SetActive(false);
            StartCoroutine(FadeOut());
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            warningCanvas.SetActive(true);
            StartCoroutine(PoisCanvas());
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
    IEnumerator PoisCanvas()
    {
        yield return new WaitForSeconds(2);
        warningCanvas.SetActive(false);
    }
}
