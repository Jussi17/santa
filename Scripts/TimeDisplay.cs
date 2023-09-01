using UnityEngine;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour
{
    public Text timePlayedText;

    private void Start()
    {
        float timePlayed = PlayerPrefs.GetFloat("TimePlayed", 0f);
        string timeString = FormatTime(timePlayed);
        timePlayedText.text = "Time played: " + timeString;
    }

    private string FormatTime(float time)
    {
        int hours = Mathf.FloorToInt(time / 3600f);
        int minutes = Mathf.FloorToInt((time - hours * 3600f) / 60f);
        int seconds = Mathf.FloorToInt(time - hours * 3600f - minutes * 60f);
        return string.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);
    }
}