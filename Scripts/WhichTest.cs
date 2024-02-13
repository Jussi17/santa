using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WhichTest : MonoBehaviour
{
    whichPlayer which;
    public GameObject whichObject;
    private Image image;
    void Start()
    {
        which = whichObject.GetComponent<whichPlayer>();
    }


    void Update()
    {
        if (which.liikkuu)
        {
            GetComponent<Image>().color = Color.red;
        }
        if (which.liikkuu == false)
        {
            GetComponent<Image>().color = Color.green;
        }
    }
}
