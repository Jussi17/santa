using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestTime42 : MonoBehaviour
{
    private Timer3 timer;
    public Text bestTimeText;
    private float recordTime = 999.99f;

    void Start()
    {
        timer = GetComponent<Timer3>();

        if (PlayerPrefs.HasKey("BestTime42"))
        {
            recordTime = PlayerPrefs.GetFloat("BestTime42");
        }

        bestTimeText.text = "Best Time: " + recordTime.ToString("f2");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Reindeer"))
        {
            if (timer != null && timer.timer < recordTime)
            {
                recordTime = timer.timer;
                PlayerPrefs.SetFloat("BestTime42", recordTime);
                PlayerPrefs.Save();
                bestTimeText.text = "Best Time: " + recordTime.ToString("f2");
                if (recordTime < 120f)
                {
                    bestTimeText.color = Color.green;
                }
            }
        }
    }
}
