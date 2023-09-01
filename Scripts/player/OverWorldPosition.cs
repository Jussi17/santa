using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverWorldPosition : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private Transform santa;
    [SerializeField] private Transform respawnPoint1;
    [SerializeField] private Transform respawnPoint2;
    [SerializeField] private Transform respawnPoint3;
    [SerializeField] private Transform respawnPoint4;
    [SerializeField] private Transform respawnPoint5;
    [SerializeField] private Transform respawnPoint6;
    [SerializeField] private Transform respawnPoint7;
    [SerializeField] private Transform respawnPoint8;
    [SerializeField] private Transform respawnPoint9;
    [SerializeField] private Transform respawnPoint10;
    [SerializeField] private Transform respawnPoint11;
    [SerializeField] private Transform respawnPoint12;
    [SerializeField] private Transform respawnPoint13;
    [SerializeField] private Transform respawnPoint14;
    [SerializeField] private Transform respawnPoint15;
    [SerializeField] private Transform respawnPoint16;
    [SerializeField] private Transform respawnPoint17;
    [SerializeField] private Transform respawnPoint18;
    [SerializeField] private Transform respawnPoint19;
    [SerializeField] private Transform respawnPoint20;
    [SerializeField] private Transform respawnPoint21;
    [SerializeField] private Transform respawnPoint22;
    [SerializeField] private Transform respawnPoint23;
    [SerializeField] private Transform respawnPoint24;
    [SerializeField] private Transform respawnPoint25;
    [SerializeField] private Transform respawnPoint26;
    [SerializeField] private Transform respawnPoint27;
    [SerializeField] private Transform respawnPoint28;
    [SerializeField] private Transform respawnPoint29;
    [SerializeField] private Transform respawnPoint30;
    [SerializeField] private Transform respawnPoint31;
    [SerializeField] private Transform respawnPoint32;
    [SerializeField] private Transform respawnPoint33;
    [SerializeField] private Transform respawnPoint34;
    [SerializeField] private Transform respawnPoint35;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        if (PlayerPrefs.HasKey("1"))
        {
            santa.transform.position = respawnPoint1.transform.position;
            rb.velocity = new Vector2(0, 0);
        }
        if (PlayerPrefs.HasKey("2"))
        {
            santa.transform.position = respawnPoint2.transform.position;
            rb.velocity = new Vector2(0, 0);
        }
        if (PlayerPrefs.HasKey("3"))
        {
            santa.transform.position = respawnPoint3.transform.position;
            rb.velocity = new Vector2(0, 0);
        }
        if (PlayerPrefs.HasKey("4"))
        {
            santa.transform.position = respawnPoint4.transform.position;
            rb.velocity = new Vector2(0, 0);
        }
        if (PlayerPrefs.HasKey("5"))
        {
            santa.transform.position = respawnPoint5.transform.position;
            rb.velocity = new Vector2(0, 0);
        }
        if (PlayerPrefs.HasKey("6"))
        {
            santa.transform.position = respawnPoint6.transform.position;
            rb.velocity = new Vector2(0, 0);
        }
        if (PlayerPrefs.HasKey("7"))
        {
            santa.transform.position = respawnPoint7.transform.position;
            rb.velocity = new Vector2(0, 0);
        }
        if (PlayerPrefs.HasKey("8"))
        {
            santa.transform.position = respawnPoint8.transform.position;
            rb.velocity = new Vector2(0, 0);
        }
        if (PlayerPrefs.HasKey("9"))
        {
            santa.transform.position = respawnPoint9.transform.position;
            rb.velocity = new Vector2(0, 0);
        }
        if (PlayerPrefs.HasKey("10"))
        {
            santa.transform.position = respawnPoint10.transform.position;
            rb.velocity = new Vector2(0, 0);
        }
        if (PlayerPrefs.HasKey("11"))
        {
            santa.transform.position = respawnPoint11.transform.position;
            rb.velocity = new Vector2(0, 0);
        }
        if (PlayerPrefs.HasKey("12"))
        {
            santa.transform.position = respawnPoint12.transform.position;
            rb.velocity = new Vector2(0, 0);
        }
        if (PlayerPrefs.HasKey("13"))
        {
            santa.transform.position = respawnPoint13.transform.position;
            rb.velocity = new Vector2(0, 0);
        }
        if (PlayerPrefs.HasKey("14"))
        {
            santa.transform.position = respawnPoint14.transform.position;
            rb.velocity = new Vector2(0, 0);
        }
        if (PlayerPrefs.HasKey("15"))
        {
            santa.transform.position = respawnPoint15.transform.position;
            rb.velocity = new Vector2(0, 0);
        }
        if (PlayerPrefs.HasKey("16"))
        {
            santa.transform.position = respawnPoint16.transform.position;
            rb.velocity = new Vector2(0, 0);
        }
        if (PlayerPrefs.HasKey("17"))
        {
            santa.transform.position = respawnPoint17.transform.position;
            rb.velocity = new Vector2(0, 0);
        }
        if (PlayerPrefs.HasKey("18"))
        {
            santa.transform.position = respawnPoint18.transform.position;
            rb.velocity = new Vector2(0, 0);
        }
        if (PlayerPrefs.HasKey("19"))
        {
            santa.transform.position = respawnPoint19.transform.position;
            rb.velocity = new Vector2(0, 0);
        }
        if (PlayerPrefs.HasKey("20"))
        {
            santa.transform.position = respawnPoint20.transform.position;
            rb.velocity = new Vector2(0, 0);
        }
        if (PlayerPrefs.HasKey("21"))
        {
            santa.transform.position = respawnPoint21.transform.position;
            rb.velocity = new Vector2(0, 0);
        }
        if (PlayerPrefs.HasKey("22"))
        {
            santa.transform.position = respawnPoint22.transform.position;
            rb.velocity = new Vector2(0, 0);
        }
        if (PlayerPrefs.HasKey("23"))
        {
            santa.transform.position = respawnPoint23.transform.position;
            rb.velocity = new Vector2(0, 0);
        }
        if (PlayerPrefs.HasKey("24"))
        {
            santa.transform.position = respawnPoint24.transform.position;
            rb.velocity = new Vector2(0, 0);
        }
        if (PlayerPrefs.HasKey("25"))
        {
            santa.transform.position = respawnPoint25.transform.position;
            rb.velocity = new Vector2(0, 0);
        }
        if (PlayerPrefs.HasKey("26"))
        {
            santa.transform.position = respawnPoint26.transform.position;
            rb.velocity = new Vector2(0, 0);
        }
        if (PlayerPrefs.HasKey("27"))
        {
            santa.transform.position = respawnPoint27.transform.position;
            rb.velocity = new Vector2(0, 0);
        }
        if (PlayerPrefs.HasKey("28"))
        {
            santa.transform.position = respawnPoint28.transform.position;
            rb.velocity = new Vector2(0, 0);
        }
        if (PlayerPrefs.HasKey("29"))
        {
            santa.transform.position = respawnPoint29.transform.position;
            rb.velocity = new Vector2(0, 0);
        }
        if (PlayerPrefs.HasKey("30"))
        {
            santa.transform.position = respawnPoint30.transform.position;
            rb.velocity = new Vector2(0, 0);
        }
        if (PlayerPrefs.HasKey("31"))
        {
            santa.transform.position = respawnPoint31.transform.position;
            rb.velocity = new Vector2(0, 0);
        }
        if (PlayerPrefs.HasKey("32"))
        {
            santa.transform.position = respawnPoint32.transform.position;
            rb.velocity = new Vector2(0, 0);
        }
        if (PlayerPrefs.HasKey("33"))
        {
            santa.transform.position = respawnPoint33.transform.position;
            rb.velocity = new Vector2(0, 0);
        }
        if (PlayerPrefs.HasKey("34"))
        {
            santa.transform.position = respawnPoint34.transform.position;
            rb.velocity = new Vector2(0, 0);
        }
        if (PlayerPrefs.HasKey("35"))
        {
            santa.transform.position = respawnPoint35.transform.position;
            rb.velocity = new Vector2(0, 0);
        }
    }

}
