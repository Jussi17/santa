using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poles : MonoBehaviour
{
    public GameObject pole;
    public GameObject pole1;
    public GameObject pole2;
    public GameObject pole4;
    public GameObject pole5;
    public GameObject pole6;
    public GameObject pole8;
    public GameObject pole9;
    public GameObject pole10;
    public GameObject pole12;
    public GameObject pole13;
    public GameObject pole14;
    public GameObject pole16;
    public GameObject pole17;
    public GameObject pole18;
    public GameObject pole20;
    public GameObject pole21;
    public GameObject pole22;
    public GameObject pole24;
    public GameObject pole25;
    public GameObject pole26;
    public GameObject pole28;
    public GameObject pole29;
    public GameObject pole30;
    void Update()
    {
        if (PlayerPrefs.HasKey("LevelComplete"))
        {
            pole.SetActive(false);
        }
        if (PlayerPrefs.HasKey("LevelComplete1"))
        {
            pole1.SetActive(false);
        }
        if (PlayerPrefs.HasKey("LevelComplete2"))
        {
            pole2.SetActive(false);
        }
        if (PlayerPrefs.HasKey("LevelComplete4"))
        {
            pole4.SetActive(false);
        }
        if (PlayerPrefs.HasKey("LevelComplete5"))
        {
            pole5.SetActive(false);
        }
        if (PlayerPrefs.HasKey("LevelComplete6"))
        {
            pole6.SetActive(false);
        }
        if (PlayerPrefs.HasKey("LevelComplete8"))
        {
            pole8.SetActive(false);
        }
        if (PlayerPrefs.HasKey("LevelComplete9"))
        {
            pole9.SetActive(false);
        }
        if (PlayerPrefs.HasKey("LevelComplete10"))
        {
            pole10.SetActive(false);
        }
        if (PlayerPrefs.HasKey("LevelComplete12"))
        {
            pole12.SetActive(false);
        }
        if (PlayerPrefs.HasKey("LevelComplete13"))
        {
            pole13.SetActive(false);
        }
        if (PlayerPrefs.HasKey("LevelComplete14"))
        {
            pole14.SetActive(false);
        }
        if (PlayerPrefs.HasKey("LevelComplete16"))
        {
            pole16.SetActive(false);
        }
        if (PlayerPrefs.HasKey("LevelComplete17"))
        {
            pole17.SetActive(false);
        }
        if (PlayerPrefs.HasKey("LevelComplete18"))
        {
            pole18.SetActive(false);
        }
        if (PlayerPrefs.HasKey("LevelComplete20"))
        {
            pole20.SetActive(false);
        }
        if (PlayerPrefs.HasKey("LevelComplete21"))
        {
            pole21.SetActive(false);
        }
        if (PlayerPrefs.HasKey("LevelComplete22"))
        {
            pole22.SetActive(false);
        }
        if (PlayerPrefs.HasKey("LevelComplete24"))
        {
            pole24.SetActive(false);
        }
        if (PlayerPrefs.HasKey("LevelComplete25"))
        {
            pole25.SetActive(false);
        }
        if (PlayerPrefs.HasKey("LevelComplete26"))
        {
            pole26.SetActive(false);
        }
        if (PlayerPrefs.HasKey("LevelComplete28"))
        {
            pole28.SetActive(false);
        }
        if (PlayerPrefs.HasKey("LevelComplete29"))
        {
            pole29.SetActive(false);
        }
        if (PlayerPrefs.HasKey("LevelComplete30"))
        {
            pole30.SetActive(false);
        }
    }
}
