using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class NewCamera2 : MonoBehaviour
{
    public GameObject player;
    public GameObject player2;
    public GameObject playerPink;
    public GameObject playerPink2;
    public GameObject playerBlue;
    public GameObject playerBlue2;
    public GameObject playerOrange;
    public GameObject playerOrange2;
    public GameObject playerGreen;
    public GameObject playerGreen2;
    public GameObject playerPurple;
    public GameObject playerPurple2;
    public float offset;
    private Vector3 playerPosition;
    public float offsetSmoothing;


    private void Awake()
    {
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            player = playerPink;
            player2 = playerPink2;
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            player = playerBlue;
            player2 = playerBlue2;
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            player = playerOrange;
            player2 = playerOrange2;
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            player = playerGreen;
            player2 = playerGreen2;
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            player = playerPurple;
            player2 = playerPurple2;
        }
    }
    private void Update()
    {
        if (player2.activeInHierarchy)
        {
            player = player2;
        }
        if (playerPink2.activeInHierarchy)
        {
            playerPink = playerPink2;
        }
        if (playerBlue2.activeInHierarchy)
        {
            playerBlue = playerBlue2;
        }
        if (playerOrange2.activeInHierarchy)
        {
            playerOrange = playerOrange2;
        }
        if (playerGreen2.activeInHierarchy)
        {
            playerGreen = playerGreen2;
        }
        if (playerPurple2.activeInHierarchy)
        {
            playerPurple = playerPurple2;
        }

        if (PlayerPrefs.HasKey("SantaPink"))
        {
            player = playerPink;
            player2 = playerPink2;
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            player = playerBlue;
            player2 = playerBlue2;
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            player = playerOrange;
            player2 = playerOrange2;
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            player = playerGreen;
            player2 = playerGreen2;
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            player = playerPurple;
            player2 = playerPurple2;
        }

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
