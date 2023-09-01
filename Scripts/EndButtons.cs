using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndButtons : MonoBehaviour
{
    public Button tryAgainButton;
    public Button backButton;
    private bool isClicked = false;

    public void OnTryAgainClick()
    {
        if (!isClicked)
        {
            tryAgainButton.GetComponent<Image>().color = Color.green;
            isClicked = true;
        }
        
    }
    public void OnBackClick()
    {
        if (!isClicked)
        {
            backButton.GetComponent<Image>().color = Color.green;
            isClicked = true;
        }
        
    }
}
