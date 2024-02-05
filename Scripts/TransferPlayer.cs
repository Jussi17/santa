using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransferPlayer : MonoBehaviour
{
    [SerializeField] private Transform playerT;
    [SerializeField] private Transform playerTPink;
    [SerializeField] private Transform playerTBlue;
    [SerializeField] private Transform playerTOrange;
    [SerializeField] private Transform playerTGreen;
    [SerializeField] private Transform playerTPurple;
    [SerializeField] private Transform respawnPoint;

    void Start()
    {
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            playerT = playerTPink;
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            playerT = playerTBlue;
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            playerT = playerTOrange;
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            playerT = playerTGreen;
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            playerT = playerTPurple;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerT.transform.position = respawnPoint.transform.position;
        }
    }
}
