using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer3 : MonoBehaviour
{
    private bool keepTiming = true;
    public float timer;
    [SerializeField] public Text timerText;

    void Start()
    {
        if (keepTiming)
        {
            timer = 0;
        }

    }
    void Update()
    {
        if (keepTiming)
        {
            timer = ((float)Time.timeSinceLevelLoad);
            timerText.text = ("Time: ")+timer.ToString("f2");

            if (Time.timeSinceLevelLoad > 900)
            {
                StopTimer();
            }
        }

    }

    void StopTimer()
    {
        keepTiming = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") || collision.CompareTag("Reindeer") || collision.CompareTag("Sleigh"))
        {
            StopTimer();
        }
    }


}
