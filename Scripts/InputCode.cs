using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputCode : MonoBehaviour
{
    public Button green;
    public Button yellow;
    public Button red;
    public Button blue;

    public GameObject greenImage;
    public GameObject yellowImage;
    public GameObject redImage;
    public GameObject blueImage;

    public int numero = 0;
    public Text congText;

    private bool greenTrue = false;
    private bool yellowTrue = false;
    private bool redTrue = false;
    private bool blueTrue = false;

    public Button codeButton;

    public GameObject resetButton;

    private void Start()
    {
        congText.enabled = false;
    }

    private void Update()
    {
        if (numero == 6)
        {
            PlayerPrefs.SetString("Upgraded", "Upgraded");
            congText.enabled = true;
            greenImage.SetActive(false);
            yellowImage.SetActive(false);
            redImage.SetActive(false);
            blueImage.SetActive(false);
            resetButton.SetActive(false);
        }
        if (PlayerPrefs.HasKey("Upgraded"))
        {
            codeButton.enabled = false;
        }
    }

    public void OnGreenClick()
    {
        if (!greenTrue && yellowTrue == true && redTrue == true && blueTrue == true)
        {
            numero++;
        }
        else
        {
            numero = 0;
        }
        greenTrue = true;
    }
    public void OnYellowClick()
    {
        if(!greenTrue && !redTrue && !blueTrue && !yellowTrue)
        {
            numero++;
        }
        else
        {
            numero = 0;
        }
        yellowTrue = true;
    }
    public void OnRedClick()
    {
        if (redTrue == true)
        {
            if (numero == 5)
            {
                numero++;
            }
            else
            {
                numero = 0;
            }
        }

        if (!redTrue)
        {
            if (yellowTrue == true && !blueTrue && !greenTrue && !redTrue)
            {
                numero++;
            }
            else
            {
                numero = 0;
            }
        }
    
        redTrue = true;
    }
    public void OnBlueClick()
    {
        if (blueTrue == true)
        {
            if (numero == 3 && yellowTrue == true && redTrue == true && !greenTrue)
            {
                numero++;
            }
            else
            {
                numero = 0;
            }
        }

        if (blueTrue == false)
        {
            if (numero == 2 && yellowTrue == true && redTrue == true && !greenTrue)
            {
                numero++;
                blueTrue = true;
            }
            else
            {
                numero = 0;
            }
        }


    }

    public void OnResetClick()
    {
        greenTrue = false;
        yellowTrue = false;
        redTrue = false;
        blueTrue = false;
        numero = 0;
    }
}
