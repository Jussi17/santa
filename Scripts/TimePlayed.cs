using UnityEngine;

public class TimePlayed : MonoBehaviour
{
    private float startTime;
    public float timePlayed;

    private void Start()
    {
        startTime = PlayerPrefs.GetFloat("StartTime", Time.time);
        timePlayed = PlayerPrefs.GetFloat("TimePlayed", 0f);
    }

    private void Update()
    {
        timePlayed += Time.deltaTime;
        string timeString = FormatTime(timePlayed);
        PlayerPrefs.SetString("TimePlayed", timeString);
    }
    private string FormatTime(float time)
    {
        int hours = Mathf.FloorToInt(time / 3600f);
        int minutes = Mathf.FloorToInt((time - hours * 3600f) / 60f);
        int seconds = Mathf.FloorToInt(time - hours * 3600f - minutes * 60f);
        return string.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);
    }

    private void OnDisable()
    {
        PlayerPrefs.SetFloat("StartTime", startTime);
        PlayerPrefs.SetFloat("TimePlayed", timePlayed);
        PlayerPrefs.Save();
    }
}
