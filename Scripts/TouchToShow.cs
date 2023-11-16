using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchToShow : MonoBehaviour
{
    public Text skipText;
    public Image speedImage;
    public Image stopImage;

    public Button skipButton;
    public Button speedButton;
    public Button stopButton;


    private void Start()
    {
        skipText.enabled = false;
        speedImage.enabled = false;
        stopImage.enabled = false;

        skipButton.enabled = false;
        speedButton.enabled = false;
        stopButton.enabled = false;
    }

    public void OnScreenClick()
    {
        skipText.enabled = true;
        speedImage.enabled = true;
        stopImage.enabled = true;

        skipButton.enabled = true;
        speedButton.enabled = true;
        stopButton.enabled = true;
    }
}
