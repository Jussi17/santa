using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageToRed : MonoBehaviour
{
    public Image image;

    public void onButtonClick()
    {
        image.GetComponent<Image>().color = Color.red;
    }
  
}
