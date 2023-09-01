using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CutSpeed : MonoBehaviour
{
    public Image buttonImage;
    public Sprite pauseImage;
    public Sprite playImage;

    private void Update()
    {
        if (Time.timeScale < 1)
        {
            buttonImage.sprite = playImage;
        }
        else
        {
            buttonImage.sprite = pauseImage;
        }
    }
    public void OnPausePlayClick()
    {
        if (Time.timeScale >= 1)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
    public void OnDoubleSpeedClick()
    {
        Time.timeScale = 2.35f;
    }
}
