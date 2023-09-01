using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageColor : MonoBehaviour
{
    public Image image;
    void Start()
    {
        image.GetComponent<Image>().color = Color.red;
    }

    public void OnButtonClick()
    {
        image.GetComponent<Image>().color = Color.green;
    }
}
