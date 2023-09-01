using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCrack : MonoBehaviour
{
    [SerializeField] private AudioSource crackSound;
    private bool hasPlayed = false;
    public GameObject crack;
    void Start()
    {
        crack.SetActive(false);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && !hasPlayed)
        {
            crack.SetActive(true);
            hasPlayed = true;
            crackSound.Play();
        }
    }

}
