using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joke22 : MonoBehaviour
{
    public GameObject snowBall;
    public GameObject shadow;
    [SerializeField] private AudioSource snowHitSound;
    [SerializeField] private AudioSource crashSound;
    private bool hasHit = false;
    void Start()
    {
        snowBall.SetActive(false);
        shadow.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && !hasHit)
        {
            snowBall.SetActive(true);
            shadow.SetActive(true);
            hasHit = true;
            snowHitSound.Play();
            StartCoroutine(OffShadow());
        }
    }
    IEnumerator OffShadow()
    {
        yield return new WaitForSeconds(1.5f);
        crashSound.Play();
        shadow.SetActive(false);
    }
}
