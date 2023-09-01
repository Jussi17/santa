using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    [SerializeField] private AudioSource ghostSound;
    private bool hasPlayed = false;
    public GameObject ghost;

    void Start()
    {
        ghost.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && !hasPlayed)
        {
            ghost.SetActive(true);
            hasPlayed = true;
            ghostSound.Play();
            StartCoroutine(Kummitus());
        }
    }
    IEnumerator Kummitus()
    {
        yield return new WaitForSeconds(6.2f);
        ghost.SetActive(false);
    }
}
