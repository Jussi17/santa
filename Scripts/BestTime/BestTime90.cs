using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestTime90 : MonoBehaviour
{
    private Timer3 timer;
    public Text bestTimeText;
    private float recordTime = 999.99f;
    CandyCane candyCane;
    public GameObject Candy;

    void Start()
    {
        candyCane = Candy.GetComponent<CandyCane>();
        timer = GetComponent<Timer3>();

        if (PlayerPrefs.HasKey("BestTime90"))
        {
            recordTime = PlayerPrefs.GetFloat("BestTime90");
        }

        bestTimeText.text = "Best Time: " + recordTime.ToString("f2");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (candyCane.foundCandy)
            {
                if (timer != null && timer.timer < recordTime)
                {
                    recordTime = timer.timer;
                    PlayerPrefs.SetFloat("BestTime90", recordTime);
                    PlayerPrefs.Save();
                    bestTimeText.text = "Best Time: " + recordTime.ToString("f2");
                    if (recordTime < 189f)
                    {
                        bestTimeText.color = Color.green;
                    }
                }
            }
            else
            {
                Debug.Log("Ei karkkia");
            }
         
        }
    }
}
