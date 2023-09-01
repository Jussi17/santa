using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitPace : MonoBehaviour
{
    public Text textSpeed;
    HealthReki health;
    SleighMovement slMove;
    public GameObject player;
    [SerializeField] private AudioSource paceSound;
    [SerializeField] private AudioSource mainMusic;
    public GameObject trailSpeed;

    private void Start()
    {
        health = player.GetComponent<HealthReki>();
        slMove = player.GetComponent<SleighMovement>();
        trailSpeed.SetActive(false);
    }

    private void Update()
    {
        if (health.dead)
        {
            textSpeed.enabled = false;
        }
        if (slMove.sleighSpeed >= 220)
        {
            trailSpeed.SetActive(true);
            mainMusic.pitch = 1.1f;
        }
        if (slMove.sleighSpeed < 220)
        {
            trailSpeed.SetActive(false);
            mainMusic.pitch = 1.05f;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Fast")
        {
            paceSound.pitch = 1.5f;
            paceSound.Play();
            textSpeed.color = Color.green;
            StartCoroutine(BackWhite());
        }
        if (collision.gameObject.tag == "Slow")
        {
            paceSound.pitch = 0.2f;
            paceSound.Play();
            textSpeed.color = Color.red;
            StartCoroutine(BackWhite());
        }
    }
    IEnumerator BackWhite()
    {
        yield return new WaitForSeconds(0.1f);
        textSpeed.color = Color.white;
    }
}
