using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageOutfits : MonoBehaviour
{
    public Image image;
    void Start()
    {
        if (PlayerPrefs.HasKey("SantaRed"))
        {
            image.color = Color.red;
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            image.color = new Color(1, 0.5226f, 0.5226f, 1);
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            image.color = Color.blue;
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            image.color = new Color(1, 0.4721608f, 0, 1);
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            image.color = new Color(0.2814712f, 0.5471698f, 0, 1);
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            image.color = new Color(0.6792453f, 0, 0.516282f, 1);
        }
    }

    void Update()
    {
        if (PlayerPrefs.HasKey("SantaRed"))
        {
            image.color = Color.red;

        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            image.color = new Color(0.9339623f, 0.6643468f, 0.6643468f, 1);
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            image.color = Color.blue;
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            image.color = new Color(1, 0.4721608f, 0, 1);
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            image.color = new Color(0.6713271f, 0.8396226f, 0.2487184f, 1);
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            image.color = new Color(0.8679245f, 0.02783903f, 0.7530679f, 1);
        }
    }
}
