using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonOpener11 : MonoBehaviour
{
    public GameObject Panel;
    public BoxCollider2D lava;
    LevelController11 lc;
    public BoxCollider2D bx;
    public Renderer renderer;
    public GameObject RespawnPoint;
    public Image gift1;
    public Image gift2;

    private void Start()
    {
        lc = GetComponent<LevelController11>();
        bx.enabled = true;
        lava.enabled = true;
        gift1.enabled = false;
        gift2.enabled = false;
    }

    private void Update()
    {
        
        if (PlayerPrefs.HasKey("LevelComplete1"))
        {
            Destroy(bx);
            Destroy(lava);
            renderer.GetComponent<SpriteRenderer>().color = new Color(1f, 0.64f, 0f);
            //Player.transform.position = new Vector2(RespawnPoint.transform.position.x, RespawnPoint.transform.position.y);
        }

        if (PlayerPrefs.HasKey("Gift3"))
        {
            renderer.GetComponent<SpriteRenderer>().color = Color.yellow;
            gift1.enabled = true;
        }
        if (PlayerPrefs.HasKey("Gift4"))
        {
            renderer.GetComponent<SpriteRenderer>().color = Color.yellow;
            gift2.enabled = true;
        }
        if (PlayerPrefs.HasKey("Gift3") && PlayerPrefs.HasKey("Gift4"))
        {
            renderer.GetComponent<SpriteRenderer>().color = Color.green;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Panel != null && Time.timeSinceLevelLoad > 0.8f && PlayerPrefs.HasKey("LevelComplete1"))
        {
            Panel.SetActive(true);
        }
        if (!PlayerPrefs.HasKey("LevelComplete1"))
        {
            Panel.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Panel.SetActive(false);
 
    }
}
