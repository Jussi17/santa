using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private bool keepTiming;
    public int timer;
    [SerializeField] public Text timerText;

    void Start()
    {
        if (keepTiming)
        {
            timer = 0;
        }
        
    }

    void StopTimer()
    {
        keepTiming = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Goal" || collision.gameObject.tag == "Player")
        {
            StopTimer();
        }
    }

    void Update()
    {
            timer = ((int)Time.timeSinceLevelLoad);
            timerText.text = timer.ToString();

            if (Time.timeSinceLevelLoad > 900)
            {
                StopTimer();
            }
    }
}
