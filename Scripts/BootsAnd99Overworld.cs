using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BootsAnd99Overworld : MonoBehaviour
{
    public GameObject NinetyLivesImage;
    public Button ninetyButton;

    public GameObject BootsGameObject;
    public Image bootImage;

    public GameObject SpringGameObject;
    public Image springImage;


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
