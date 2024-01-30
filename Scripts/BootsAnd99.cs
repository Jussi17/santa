using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BootsAnd99 : MonoBehaviour
{
    public GameObject CanvasLife;

    public GameObject NinetyLivesImage;
    public Button ninetyButton;

    public GameObject BootsGameObject;
    public Image bootImage;

    public GameObject SpringGameObject;
    public Image springImage;

    Life life;

    private void Start()
    {
        life = CanvasLife.GetComponent<Life>();
    }

    void Update()
    {
        if (!PlayerPrefs.HasKey("NinetyNine"))
        {
            NinetyLivesImage.SetActive(false);
            ninetyButton.enabled = false;
        }
        if (PlayerPrefs.HasKey("NinetyNine"))
        {
            NinetyLivesImage.SetActive(true);
            ninetyButton.enabled = true;
        }
        if (PlayerPrefs.HasKey("LifeYes"))
        {
            NinetyLivesImage.GetComponent<Image>().color = Color.green;
        }
        if (!PlayerPrefs.HasKey("LifeYes"))
        {
            NinetyLivesImage.GetComponent<Image>().color = Color.red;
        }

        if (!PlayerPrefs.HasKey("SpeedBoots"))
        {
            BootsGameObject.SetActive(false);
        }
        if (PlayerPrefs.HasKey("SpeedBoots"))
        {
            BootsGameObject.SetActive(true);
        }
        if (PlayerPrefs.HasKey("SpeedYes"))
        {
            bootImage.color = Color.green;
        }
        if (!PlayerPrefs.HasKey("SpeedYes"))
        {
            bootImage.color = Color.red;
        }

        if (!PlayerPrefs.HasKey("JumpBoots"))
        {
            SpringGameObject.SetActive(false);
        }
        if (PlayerPrefs.HasKey("JumpBoots"))
        {
            SpringGameObject.SetActive(true);
        }
        if (PlayerPrefs.HasKey("JumpYes"))
        {
            springImage.color = Color.green;
        }
        if (!PlayerPrefs.HasKey("JumpYes"))
        {
            springImage.color = Color.red;
        }
    }
    public void OnNinetyButtonClick()
    {
        if (!PlayerPrefs.HasKey("LifeYes"))
        {
            PlayerPrefs.SetString("LifeYes", "LifeYes");
            Debug.Log("LifeOff");
        }
        else
        {
            PlayerPrefs.DeleteKey("LifeYes");
            Debug.Log("LifeYes");
            if (PlayerPrefs.GetString("Difficulty") == "Easy")
            {
                life.lives = 5;
                life.lifeText.text = "x " + life.lives.ToString();
            }

            if (PlayerPrefs.GetString("Difficulty") == "Normal")
            {
                life.lives = 3;
                life.lifeText.text = "x " + life.lives.ToString();
            }
            if (PlayerPrefs.GetString("Difficulty") == "Hard")
            {
                life.lives = 2;
                life.lifeText.text = "x " + life.lives.ToString();
            }
            if (PlayerPrefs.GetString("Difficulty") == "Brutal")
            {
                life.lives = 1;
                life.lifeText.text = "x " + life.lives.ToString();
            }
        }
    }
    public void OnBootsButtonClick()
    {
        if (!PlayerPrefs.HasKey("SpeedYes"))
        {
            PlayerPrefs.SetString("SpeedYes", "SpeedYes");
        }
        else
        {
            PlayerPrefs.DeleteKey("SpeedYes");
        }
    }
    public void OnSpringButtonClick()
    {
        if (!PlayerPrefs.HasKey("JumpYes"))
        {
            PlayerPrefs.SetString("JumpYes", "JumpYes");
        }
        else
        {
            PlayerPrefs.DeleteKey("JumpYes");
        }
    }
}
