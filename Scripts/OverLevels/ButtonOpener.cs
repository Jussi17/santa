using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonOpener : MonoBehaviour
{
    public GameObject Panel;
    public BoxCollider2D lava;
    LevelController lc;
    public BoxCollider2D bx;
    public Renderer renderer;
    public GameObject Player;
    public GameObject Player2;
    public GameObject Player3;
    public GameObject Player4;
    public GameObject Player5;

    public GameObject PinkPlayer;
    public GameObject PinkPlayer2;
    public GameObject PinkPlayer3;
    public GameObject PinkPlayer4;
    public GameObject PinkPlayer5;

    public GameObject BluePlayer;
    public GameObject BluePlayer2;
    public GameObject BluePlayer3;
    public GameObject BluePlayer4;
    public GameObject BluePlayer5;

    public GameObject OrangePlayer;
    public GameObject OrangePlayer2;
    public GameObject OrangePlayer3;
    public GameObject OrangePlayer4;
    public GameObject OrangePlayer5;

    public GameObject GreenPlayer;
    public GameObject GreenPlayer2;
    public GameObject GreenPlayer3;
    public GameObject GreenPlayer4;
    public GameObject GreenPlayer5;

    public GameObject PurplePlayer;
    public GameObject PurplePlayer2;
    public GameObject PurplePlayer3;
    public GameObject PurplePlayer4;
    public GameObject PurplePlayer5;

    public GameObject RespawnPoint;
    public Image gift1;
    public Image gift2;
    private bool saaGift = false;
    private Color color = new Color(1.0f, 9.64f, 0.0f);

    private void Start()
    {
        lc = GetComponent<LevelController>();
        bx.enabled = true;
        lava.enabled = true;
        gift1.enabled = false;
        gift2.enabled = false;
    }

    private void Update()
    {
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            Player = PinkPlayer;
            Player2 = PinkPlayer2;
            Player3 = PinkPlayer3;
            Player4 = PinkPlayer4;
            Player5 = PinkPlayer5;
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            Player = BluePlayer;
            Player2 = BluePlayer2;
            Player3 = BluePlayer3;
            Player4 = BluePlayer4;
            Player5 = BluePlayer5;
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            Player = OrangePlayer;
            Player2 = OrangePlayer2;
            Player3 = OrangePlayer3;
            Player4 = OrangePlayer4;
            Player5 = OrangePlayer5;
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            Player = GreenPlayer;
            Player2 = GreenPlayer2;
            Player3 = GreenPlayer3;
            Player4 = GreenPlayer4;
            Player5 = GreenPlayer5;
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            Player = PurplePlayer;
            Player2 = PurplePlayer2;
            Player3 = PurplePlayer3;
            Player4 = PurplePlayer4;
            Player5 = PurplePlayer5;
        }

        if (PlayerPrefs.HasKey("LevelComplete"))
        {
            Destroy(bx);
            Destroy(lava);
            renderer.GetComponent<SpriteRenderer>().color = new Color(1f, 0.64f, 0f);
        }
        if (PlayerPrefs.HasKey("LevelComplete3"))
        {
            Player = Player2;
        }
        if (PlayerPrefs.HasKey("LevelComplete7"))
        {
            Player2 = Player3;
        }
        if (PlayerPrefs.HasKey("LevelComplete15"))
        {
            Player3 = Player4;
        }
        if (PlayerPrefs.HasKey("LevelComplete19"))
        {
            Player4 = Player5;
        }

        if (PlayerPrefs.HasKey("Gift1"))
        {
            renderer.GetComponent<SpriteRenderer>().color = Color.yellow;
            gift1.enabled = true;
            saaGift = true;
        }
        if (PlayerPrefs.HasKey("Gift2"))
        {
            renderer.GetComponent<SpriteRenderer>().color = Color.yellow;
            gift2.enabled = true;
            saaGift = true;
        }
        if (PlayerPrefs.HasKey("Gift1") && PlayerPrefs.HasKey("Gift2"))
        {
            renderer.GetComponent<SpriteRenderer>().color = Color.green;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Panel != null && Time.timeSinceLevelLoad > 0.8f && PlayerPrefs.HasKey("LevelComplete"))
        {
            Panel.SetActive(true);
        }
        if (!PlayerPrefs.HasKey("LevelComplete"))
        {
            Panel.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Panel.SetActive(false);

    }
}
