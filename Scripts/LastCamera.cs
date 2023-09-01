using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class LastCamera : MonoBehaviour
{
    public GameObject player;
    public GameObject player1;
    public GameObject player2;
    public GameObject playerRein;
    public GameObject player3;
    public GameObject playerReki;
    public GameObject player4;

    public GameObject playerPink;
    public GameObject playerPink1;
    public GameObject playerPink2;
    public GameObject playerPinkRein;
    public GameObject playerPink3;
    public GameObject playerPinkReki;
    public GameObject playerPink4;

    public GameObject playerBlue;
    public GameObject playerBlue1;
    public GameObject playerBlue2;
    public GameObject playerBlueRein;
    public GameObject playerBlue3;
    public GameObject playerBlueReki;
    public GameObject playerBlue4;

    public GameObject playerOrange;
    public GameObject playerOrange1;
    public GameObject playerOrange2;
    public GameObject playerOrangeRein;
    public GameObject playerOrange3;
    public GameObject playerOrangeReki;
    public GameObject playerOrange4;

    public GameObject playerGreen;
    public GameObject playerGreen1;
    public GameObject playerGreen2;
    public GameObject playerGreenRein;
    public GameObject playerGreen3;
    public GameObject playerGreenReki;
    public GameObject playerGreen4;

    public GameObject playerPurple;
    public GameObject playerPurple1;
    public GameObject playerPurple2;
    public GameObject playerPurpleRein;
    public GameObject playerPurple3;
    public GameObject playerPurpleReki;
    public GameObject playerPurple4;

    public float offset;
    private Vector3 playerPosition;
    public float offsetSmoothing;


    private void Awake()
    {
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            player = playerPink;
            player1 = playerPink1;
            player2 = playerPink2;
            player3 = playerPink3;
            player4 = playerPink4;
            playerRein = playerPinkRein;
            playerReki = playerPinkReki;
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            player = playerBlue;
            player1 = playerBlue1;
            player2 = playerBlue2;
            player3 = playerBlue3;
            player4 = playerBlue4;
            playerRein = playerBlueRein;
            playerReki = playerBlueReki;
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            player = playerOrange;
            player1 = playerOrange1;
            player2 = playerOrange2;
            player3 = playerOrange3;
            player4 = playerOrange4;
            playerRein = playerOrangeRein;
            playerReki = playerOrangeReki;
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            player = playerGreen;
            player1 = playerGreen1;
            player2 = playerGreen2;
            player3 = playerGreen3;
            player4 = playerGreen4;
            playerRein = playerGreenRein;
            playerReki = playerGreenReki;
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            player = playerPurple;
            player1 = playerPurple1;
            player2 = playerPurple2;
            player3 = playerPurple3;
            player4 = playerPurple4;
            playerRein = playerPurpleRein;
            playerReki = playerPurpleReki;
        }
    }
    private void Update()
    {
        if (player1.activeInHierarchy)
        {
            player = player1;
        }
        if (player2.activeInHierarchy)
        {
            player1 = player2;
        }
        if (playerRein.activeInHierarchy)
        {
            player2 = playerRein;
        }
        if (player3.activeInHierarchy)
        {
            playerRein = player3;
        }
        if (playerReki.activeInHierarchy)
        {
            player3 = playerReki;
        }
        if (player4.activeInHierarchy)
        {
            playerReki = player4;
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
