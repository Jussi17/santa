using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class CamSled : MonoBehaviour
{
    public GameObject player;
    public GameObject playerPink;
    public GameObject playerBlue;
    public GameObject playerOrange;
    public GameObject playerGreen;
    public GameObject playerPurple;
    public float offset;
    private Vector3 playerPosition;
    public float offsetSmoothing;

    private void Awake()
    {
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            player = playerPink;
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            player = playerBlue;
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            player = playerOrange;
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            player = playerGreen;
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            player = playerPurple;
        }
    }

    private void Update()
    {
        playerPosition = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);

        if (player.transform.localScale.x > 0f)
        {
            playerPosition = new Vector3(playerPosition.x + offset, playerPosition.y, playerPosition.z);
        }
        else if (player.transform.localScale.y < 0)
        {
            playerPosition = new Vector3(playerPosition.x, playerPosition.y - offset, playerPosition.z);
        }
        else
        {
            playerPosition = new Vector3(playerPosition.x - offset, playerPosition.y, playerPosition.z);
        }
        transform.position = Vector3.Lerp(transform.position, playerPosition, offsetSmoothing * Time.deltaTime);
    }

    public void Zoomaus()
    {
        if (CrossPlatformInputManager.GetButtonDown("Zoom"))
        {
            playerPosition = new Vector3(playerPosition.x * 100 * -offset, playerPosition.y * -offset, playerPosition.z);
        }
    }

}
