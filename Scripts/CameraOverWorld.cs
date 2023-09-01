using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using System.Collections;

public class CameraOverWorld : MonoBehaviour
{
    public GameObject player;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;
    public GameObject player5;
    public GameObject playerPink;
    public GameObject playerPink2;
    public GameObject playerPink3;
    public GameObject playerPink4;
    public GameObject playerPink5;
    public GameObject playerBlue;
    public GameObject playerBlue2;
    public GameObject playerBlue3;
    public GameObject playerBlue4;
    public GameObject playerBlue5;
    public GameObject playerOrange;
    public GameObject playerOrange2;
    public GameObject playerOrange3;
    public GameObject playerOrange4;
    public GameObject playerOrange5;
    public GameObject playerGreen;
    public GameObject playerGreen2;
    public GameObject playerGreen3;
    public GameObject playerGreen4;
    public GameObject playerGreen5;
    public GameObject playerPurple;
    public GameObject playerPurple2;
    public GameObject playerPurple3;
    public GameObject playerPurple4;
    public GameObject playerPurple5;

    public float offset;
    private Vector3 playerPosition;
    private Vector3 playerPositionPink;
    private Vector3 playerPositionBlue;
    private Vector3 playerPositionOrange;
    private Vector3 playerPositionGreen;
    private Vector3 playerPositionPurple;
    public float offsetSmoothing;

    private void Awake()
    {
        if (PlayerPrefs.HasKey("LevelComplete3"))
        {
            player = player2;
            playerPink = playerPink2;
            playerBlue = playerBlue2;
            playerOrange = playerOrange2;
            playerGreen = playerGreen2;
            playerPurple = playerPurple2;
        }
        if (PlayerPrefs.HasKey("LevelComplete7"))
        {
            player2 = player3;
            playerPink2 = playerPink3;
            playerBlue2 = playerBlue3;
            playerOrange2 = playerOrange3;
            playerGreen2 = playerGreen3;
            playerPurple2 = playerPurple3;
        }
        if (PlayerPrefs.HasKey("LevelComplete15"))
        {
            player3 = player4;
            playerPink3 = playerPink4;
            playerBlue3 = playerBlue4;
            playerOrange3 = playerOrange4;
            playerGreen3 = playerGreen4;
            playerPurple3 = playerPurple4;
        }
        if (PlayerPrefs.HasKey("LevelComplete19"))
        {
            player4 = player5;
            playerPink4 = playerPink5;
            playerBlue4 = playerBlue5;
            playerOrange4 = playerOrange5;
            playerGreen4 = playerGreen5;
            playerPurple4 = playerPurple5;
        }

        if (PlayerPrefs.HasKey("SantaRed"))
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


        if (PlayerPrefs.HasKey("SantaPink"))
        {
            playerPositionPink = new Vector3(playerPink.transform.position.x, playerPink.transform.position.y, transform.position.z);

            if (playerPink.transform.localScale.x > 0f)
            {
                playerPositionPink = new Vector3(playerPositionPink.x + offset, playerPositionPink.y, playerPositionPink.z);
            }
            else if (playerPink.transform.localScale.y < 0)
            {
                playerPositionPink = new Vector3(playerPositionPink.x, playerPositionPink.y - offset, playerPositionPink.z);
            }
            else
            {
                playerPositionPink = new Vector3(playerPositionPink.x - offset, playerPositionPink.y, playerPositionPink.z);
            }
            transform.position = Vector3.Lerp(transform.position, playerPositionPink, offsetSmoothing * Time.deltaTime);
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            playerPositionBlue = new Vector3(playerBlue.transform.position.x, playerBlue.transform.position.y, transform.position.z);

            if (playerBlue.transform.localScale.x > 0f)
            {
                playerPositionBlue = new Vector3(playerPositionBlue.x + offset, playerPositionBlue.y, playerPositionBlue.z);
            }
            else if (playerBlue.transform.localScale.y < 0)
            {
                playerPositionBlue = new Vector3(playerPositionBlue.x, playerPositionBlue.y - offset, playerPositionBlue.z);
            }
            else
            {
                playerPositionBlue = new Vector3(playerPositionBlue.x - offset, playerPositionBlue.y, playerPositionBlue.z);
            }
            transform.position = Vector3.Lerp(transform.position, playerPositionBlue, offsetSmoothing * Time.deltaTime);
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            playerPositionOrange = new Vector3(playerOrange.transform.position.x, playerOrange.transform.position.y, transform.position.z);

            if (playerOrange.transform.localScale.x > 0f)
            {
                playerPositionOrange = new Vector3(playerPositionOrange.x + offset, playerPositionOrange.y, playerPositionOrange.z);
            }
            else if (playerOrange.transform.localScale.y < 0)
            {
                playerPositionOrange = new Vector3(playerPositionOrange.x, playerPositionOrange.y - offset, playerPositionOrange.z);
            }
            else
            {
                playerPositionOrange = new Vector3(playerPositionOrange.x - offset, playerPositionOrange.y, playerPositionOrange.z);
            }
            transform.position = Vector3.Lerp(transform.position, playerPositionOrange, offsetSmoothing * Time.deltaTime);
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            playerPositionGreen = new Vector3(playerGreen.transform.position.x, playerGreen.transform.position.y, transform.position.z);

            if (playerGreen.transform.localScale.x > 0f)
            {
                playerPositionGreen = new Vector3(playerPositionGreen.x + offset, playerPositionGreen.y, playerPositionGreen.z);
            }
            else if (playerGreen.transform.localScale.y < 0)
            {
                playerPositionGreen = new Vector3(playerPositionGreen.x, playerPositionGreen.y - offset, playerPositionGreen.z);
            }
            else
            {
                playerPositionGreen = new Vector3(playerPositionGreen.x - offset, playerPositionGreen.y, playerPositionGreen.z);
            }
            transform.position = Vector3.Lerp(transform.position, playerPositionGreen, offsetSmoothing * Time.deltaTime);
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            playerPositionPurple = new Vector3(playerPurple.transform.position.x, playerPurple.transform.position.y, transform.position.z);

            if (playerPurple.transform.localScale.x > 0f)
            {
                playerPositionPurple = new Vector3(playerPositionPurple.x + offset, playerPositionPurple.y, playerPositionPurple.z);
            }
            else if (playerPurple.transform.localScale.y < 0)
            {
                playerPositionPurple = new Vector3(playerPositionPurple.x, playerPositionPurple.y - offset, playerPositionPurple.z);
            }
            else
            {
                playerPositionPurple = new Vector3(playerPositionPurple.x - offset, playerPositionPurple.y, playerPositionPurple.z);
            }
            transform.position = Vector3.Lerp(transform.position, playerPositionPurple, offsetSmoothing * Time.deltaTime);
        }
    }

    private void Update()
    {
        if (PlayerPrefs.HasKey("LevelComplete3"))
        {
            player = player2;
            playerPink = playerPink2;
            playerBlue = playerBlue2;
            playerOrange = playerOrange2;
            playerGreen = playerGreen2;
            playerPurple = playerPurple2;
        }
        if (PlayerPrefs.HasKey("LevelComplete7"))
        {
            player2 = player3;
            playerPink2 = playerPink3;
            playerBlue2 = playerBlue3;
            playerOrange2 = playerOrange3;
            playerGreen2 = playerGreen3;
            playerPurple2 = playerPurple3;
        }
        if (PlayerPrefs.HasKey("LevelComplete15"))
        {
            player3 = player4;
            playerPink3 = playerPink4;
            playerBlue3 = playerBlue4;
            playerOrange3 = playerOrange4;
            playerGreen3 = playerGreen4;
            playerPurple3 = playerPurple4;
        }
        if (PlayerPrefs.HasKey("LevelComplete19"))
        {
            player4 = player5;
            playerPink4 = playerPink5;
            playerBlue4 = playerBlue5;
            playerOrange4 = playerOrange5;
            playerGreen4 = playerGreen5;
            playerPurple4 = playerPurple5;
        }

        if (PlayerPrefs.HasKey("SantaRed"))
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


        if (PlayerPrefs.HasKey("SantaPink"))
        {
            playerPositionPink = new Vector3(playerPink.transform.position.x, playerPink.transform.position.y, transform.position.z);

            if (playerPink.transform.localScale.x > 0f)
            {
                playerPositionPink = new Vector3(playerPositionPink.x + offset, playerPositionPink.y, playerPositionPink.z);
            }
            else if (playerPink.transform.localScale.y < 0)
            {
                playerPositionPink = new Vector3(playerPositionPink.x, playerPositionPink.y - offset, playerPositionPink.z);
            }
            else
            {
                playerPositionPink = new Vector3(playerPositionPink.x - offset, playerPositionPink.y, playerPositionPink.z);
            }
            transform.position = Vector3.Lerp(transform.position, playerPositionPink, offsetSmoothing * Time.deltaTime);
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            playerPositionBlue = new Vector3(playerBlue.transform.position.x, playerBlue.transform.position.y, transform.position.z);

            if (playerBlue.transform.localScale.x > 0f)
            {
                playerPositionBlue = new Vector3(playerPositionBlue.x + offset, playerPositionBlue.y, playerPositionBlue.z);
            }
            else if (playerBlue.transform.localScale.y < 0)
            {
                playerPositionBlue = new Vector3(playerPositionBlue.x, playerPositionBlue.y - offset, playerPositionBlue.z);
            }
            else
            {
                playerPositionBlue = new Vector3(playerPositionBlue.x - offset, playerPositionBlue.y, playerPositionBlue.z);
            }
            transform.position = Vector3.Lerp(transform.position, playerPositionBlue, offsetSmoothing * Time.deltaTime);
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            playerPositionOrange = new Vector3(playerOrange.transform.position.x, playerOrange.transform.position.y, transform.position.z);

            if (playerOrange.transform.localScale.x > 0f)
            {
                playerPositionOrange = new Vector3(playerPositionOrange.x + offset, playerPositionOrange.y, playerPositionOrange.z);
            }
            else if (playerOrange.transform.localScale.y < 0)
            {
                playerPositionOrange = new Vector3(playerPositionOrange.x, playerPositionOrange.y - offset, playerPositionOrange.z);
            }
            else
            {
                playerPositionOrange = new Vector3(playerPositionOrange.x - offset, playerPositionOrange.y, playerPositionOrange.z);
            }
            transform.position = Vector3.Lerp(transform.position, playerPositionOrange, offsetSmoothing * Time.deltaTime);
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            playerPositionGreen = new Vector3(playerGreen.transform.position.x, playerGreen.transform.position.y, transform.position.z);

            if (playerGreen.transform.localScale.x > 0f)
            {
                playerPositionGreen = new Vector3(playerPositionGreen.x + offset, playerPositionGreen.y, playerPositionGreen.z);
            }
            else if (playerGreen.transform.localScale.y < 0)
            {
                playerPositionGreen = new Vector3(playerPositionGreen.x, playerPositionGreen.y - offset, playerPositionGreen.z);
            }
            else
            {
                playerPositionGreen = new Vector3(playerPositionGreen.x - offset, playerPositionGreen.y, playerPositionGreen.z);
            }
            transform.position = Vector3.Lerp(transform.position, playerPositionGreen, offsetSmoothing * Time.deltaTime);
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            playerPositionPurple = new Vector3(playerPurple.transform.position.x, playerPurple.transform.position.y, transform.position.z);

            if (playerPurple.transform.localScale.x > 0f)
            {
                playerPositionPurple = new Vector3(playerPositionPurple.x + offset, playerPositionPurple.y, playerPositionPurple.z);
            }
            else if (playerPurple.transform.localScale.y < 0)
            {
                playerPositionPurple = new Vector3(playerPositionPurple.x, playerPositionPurple.y - offset, playerPositionPurple.z);
            }
            else
            {
                playerPositionPurple = new Vector3(playerPositionPurple.x - offset, playerPositionPurple.y, playerPositionPurple.z);
            }
            transform.position = Vector3.Lerp(transform.position, playerPositionPurple, offsetSmoothing * Time.deltaTime);
        }
    }
    public void Zoomaus()
    {
        if (CrossPlatformInputManager.GetButtonDown("Zoom") && PlayerPrefs.HasKey("SantaRed"))
        {
            playerPosition = new Vector3(playerPosition.x * 100 * -offset, playerPosition.y * -offset, playerPosition.z);
        }
        if (CrossPlatformInputManager.GetButtonDown("Zoom") && PlayerPrefs.HasKey("SantaPink"))
        {
            playerPositionPink = new Vector3(playerPositionPink.x * 100 * -offset, playerPositionPink.y * -offset, playerPositionPink.z);
        }
        if (CrossPlatformInputManager.GetButtonDown("Zoom") && PlayerPrefs.HasKey("SantaBlue"))
        {
            playerPositionBlue = new Vector3(playerPositionBlue.x * 100 * -offset, playerPositionBlue.y * -offset, playerPositionBlue.z);
        }
        if (CrossPlatformInputManager.GetButtonDown("Zoom") && PlayerPrefs.HasKey("SantaOrange"))
        {
            playerPositionOrange = new Vector3(playerPositionOrange.x * 100 * -offset, playerPositionOrange.y * -offset, playerPositionOrange.z);
        }
        if (CrossPlatformInputManager.GetButtonDown("Zoom") && PlayerPrefs.HasKey("SantaGreen"))
        {
            playerPositionGreen = new Vector3(playerPositionGreen.x * 100 * -offset, playerPositionGreen.y * -offset, playerPositionGreen.z);
        }
        if (CrossPlatformInputManager.GetButtonDown("Zoom") && PlayerPrefs.HasKey("SantaPurple"))
        {
            playerPositionPurple = new Vector3(playerPositionPurple.x * 100 * -offset, playerPositionPurple.y * -offset, playerPositionPurple.z);
        }
    }

}

