using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnReki : MonoBehaviour
{
    //[SerializeField] private AudioClip checkpoint;
    public Transform currentCheckpoint;
    private HealthReki playerHealth;

    private void Awake()
    {
        playerHealth = GetComponent<HealthReki>();
    }

    //public void RespawnPoint()
    //{
    //    Debug.Log("Player respawn");
    //    playerHealth.RespawnPoint();
    //    transform.position = currentCheckpoint.transform.position; 
    //}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Checkpoint" || collision.gameObject.tag == "CheckPointSave")
        {
            currentCheckpoint = collision.transform;
            //SoundManager.instance.PlaySound(checkpoint);
            collision.GetComponent<Collider2D>().enabled = false;
            collision.GetComponent<Animator>().SetTrigger("appear");
        }

    }
}