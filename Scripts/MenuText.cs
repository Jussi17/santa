using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuText : MonoBehaviour
{
    public Text playText;
    public Text continueText;
    public Text optionsText;
    public Text quitText;
  
    void Start()
    {
        if (PlayerPrefs.HasKey("SantaRed"))
        {
            playText.color = Color.red;
            continueText.color = Color.red;
            optionsText.color = Color.red;
            quitText.color = Color.red;
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            playText.color = new Color(1, 0.5226f, 0.5226f, 1);
            continueText.color = new Color(1, 0.5226f, 0.5226f, 1);
            optionsText.color = new Color(1, 0.5226f, 0.5226f, 1);
            quitText.color = new Color(1, 0.5226f, 0.5226f, 1);
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            playText.color = Color.blue;
            continueText.color = Color.blue;
            optionsText.color = Color.blue;
            quitText.color = Color.blue;
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            playText.color = new Color(1, 0.4721608f, 0, 1);
            continueText.color = new Color(1, 0.4721608f, 0, 1);
            optionsText.color = new Color(1, 0.4721608f, 0, 1);
            quitText.color = new Color(1, 0.4721608f, 0, 1);
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            playText.color = new Color(0.2814712f, 0.5471698f, 0, 1);
            continueText.color = new Color(0.2814712f, 0.5471698f, 0, 1);
            optionsText.color = new Color(0.2814712f, 0.5471698f, 0, 1);
            quitText.color = new Color(0.2814712f, 0.5471698f, 0, 1);

        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            playText.color = new Color(0.6792453f, 0, 0.516282f, 1);
            continueText.color = new Color(0.6792453f, 0, 0.516282f, 1);
            optionsText.color = new Color(0.6792453f, 0, 0.516282f, 1);
            quitText.color = new Color(0.6792453f, 0, 0.516282f, 1);
        }
    }
}
