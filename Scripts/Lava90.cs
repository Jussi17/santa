using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava90 : MonoBehaviour
{
    [SerializeField] private AudioSource lavaSound;
    public GameObject lifeCanvas;
    LifeLev90 life;

    private void Start()
    {
        life = lifeCanvas.GetComponent<LifeLev90>();
    }
    private void Update()
    {
        if (life.lives < 1)
        {
            lavaSound.enabled = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Reindeer" || collision.gameObject.tag == "Sleigh")
        {
            lavaSound.Play();      
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Reindeer" || collision.gameObject.tag == "Sleigh")
        {
            lavaSound.Play();
        }
    }
}
