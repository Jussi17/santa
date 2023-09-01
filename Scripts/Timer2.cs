using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer2 : MonoBehaviour
{
    private bool keepTiming = true;
    public int timer;
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
            timer = ((int)Time.timeSinceLevelLoad);
            timerText.text = timer.ToString();

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
        if (collision.CompareTag("Player"))
        {
            StopTimer();
        }
    }


}
