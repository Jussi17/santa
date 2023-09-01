using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThemeDif : MonoBehaviour
{
    public Image backImage;
    public Text easyText;
    public Text normalText;
    public Text hardText;
    public Text brutalText;
    public Text backText;
    public Text outfitsText;
    void Start()
    {
        if (PlayerPrefs.HasKey("SantaRed"))
        {
            backImage.color = Color.red;
            easyText.color = Color.red;
            normalText.color = Color.red;
            hardText.color = Color.red;
            brutalText.color = Color.red;
            backText.color = Color.red;
            outfitsText.color = Color.red;
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            backImage.color = new Color(0.9339623f, 0.6643468f, 0.6643468f, 1);
            easyText.color = new Color(1, 0.5226f, 0.5226f, 1);
            normalText.color = new Color(1, 0.5226f, 0.5226f, 1);
            hardText.color = new Color(1, 0.5226f, 0.5226f, 1);
            brutalText.color = new Color(1, 0.5226f, 0.5226f, 1);
            backText.color = new Color(1, 0.5226f, 0.5226f, 1);
            outfitsText.color = new Color(1, 0.5226f, 0.5226f, 1);
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            backImage.color = Color.blue;
            easyText.color = Color.blue;
            normalText.color = Color.blue;
            hardText.color = Color.blue;
            brutalText.color = Color.blue;
            backText.color = Color.blue;
            outfitsText.color = Color.blue;
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            backImage.color = new Color(1, 0.4721608f, 0, 1);
            easyText.color = new Color(1, 0.4721608f, 0, 1);
            normalText.color = new Color(1, 0.4721608f, 0, 1);
            hardText.color = new Color(1, 0.4721608f, 0, 1);
            brutalText.color = new Color(1, 0.4721608f, 0, 1);
            backText.color = new Color(1, 0.4721608f, 0, 1);
            outfitsText.color = new Color(1, 0.4721608f, 0, 1);
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            backImage.color = new Color(0.6713271f, 0.8396226f, 0.2487184f, 1);
            easyText.color = new Color(0.2814712f, 0.5471698f, 0, 1);
            normalText.color = new Color(0.2814712f, 0.5471698f, 0, 1);
            hardText.color = new Color(0.2814712f, 0.5471698f, 0, 1);
            brutalText.color = new Color(0.2814712f, 0.5471698f, 0, 1);
            backText.color = new Color(0.2814712f, 0.5471698f, 0, 1);
            outfitsText.color = new Color(0.2814712f, 0.5471698f, 0, 1);
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            backImage.color = new Color(0.8679245f, 0.02783903f, 0.7530679f, 1);
            easyText.color = new Color(0.6792453f, 0, 0.516282f, 1);
            normalText.color = new Color(0.6792453f, 0, 0.516282f, 1);
            hardText.color = new Color(0.6792453f, 0, 0.516282f, 1);
            brutalText.color = new Color(0.6792453f, 0, 0.516282f, 1);
            backText.color = new Color(0.6792453f, 0, 0.516282f, 1);
            outfitsText.color = new Color(0.6792453f, 0, 0.516282f, 1);
        }
    }
    private void Update()
    {
        if (PlayerPrefs.HasKey("SantaRed"))
        {
            backImage.color = Color.red;
            easyText.color = Color.red;
            normalText.color = Color.red;
            hardText.color = Color.red;
            brutalText.color = Color.red;
            backText.color = Color.red;
            outfitsText.color = Color.red;
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            backImage.color = new Color(0.9339623f, 0.6643468f, 0.6643468f, 1);
            easyText.color = new Color(1, 0.5226f, 0.5226f, 1);
            normalText.color = new Color(1, 0.5226f, 0.5226f, 1);
            hardText.color = new Color(1, 0.5226f, 0.5226f, 1);
            brutalText.color = new Color(1, 0.5226f, 0.5226f, 1);
            backText.color = new Color(1, 0.5226f, 0.5226f, 1);
            outfitsText.color = new Color(1, 0.5226f, 0.5226f, 1);
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            backImage.color = Color.blue;
            easyText.color = Color.blue;
            normalText.color = Color.blue;
            hardText.color = Color.blue;
            brutalText.color = Color.blue;
            backText.color = Color.blue;
            outfitsText.color = Color.blue;
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            backImage.color = new Color(1, 0.4721608f, 0, 1);
            easyText.color = new Color(1, 0.4721608f, 0, 1);
            normalText.color = new Color(1, 0.4721608f, 0, 1);
            hardText.color = new Color(1, 0.4721608f, 0, 1);
            brutalText.color = new Color(1, 0.4721608f, 0, 1);
            backText.color = new Color(1, 0.4721608f, 0, 1);
            outfitsText.color = new Color(1, 0.4721608f, 0, 1);
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            backImage.color = new Color(0.6713271f, 0.8396226f, 0.2487184f, 1);
            easyText.color = new Color(0.2814712f, 0.5471698f, 0, 1);
            normalText.color = new Color(0.2814712f, 0.5471698f, 0, 1);
            hardText.color = new Color(0.2814712f, 0.5471698f, 0, 1);
            brutalText.color = new Color(0.2814712f, 0.5471698f, 0, 1);
            backText.color = new Color(0.2814712f, 0.5471698f, 0, 1);
            outfitsText.color = new Color(0.2814712f, 0.5471698f, 0, 1);
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            backImage.color = new Color(0.8679245f, 0.02783903f, 0.7530679f, 1);
            easyText.color = new Color(0.6792453f, 0, 0.516282f, 1);
            normalText.color = new Color(0.6792453f, 0, 0.516282f, 1);
            hardText.color = new Color(0.6792453f, 0, 0.516282f, 1);
            brutalText.color = new Color(0.6792453f, 0, 0.516282f, 1);
            backText.color = new Color(0.6792453f, 0, 0.516282f, 1);
            outfitsText.color = new Color(0.6792453f, 0, 0.516282f, 1);
        }
    }
}
