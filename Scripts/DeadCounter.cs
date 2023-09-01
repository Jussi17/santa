using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeadCounter : MonoBehaviour
{
    public int deaths = 0;
    [SerializeField] public Text deadText;

    void Start()
    {
        deaths = PlayerPrefs.GetInt("deaths");
        deadText.text = "" + PlayerPrefs.GetInt("deaths", deaths);
    }

    void Update()
    {
        PlayerPrefs.SetInt("deaths", deaths);
        deadText.text = " " + PlayerPrefs.GetInt("deaths", deaths);
        if (deaths > 99999)
        {
            PlayerPrefs.SetInt("deaths", deaths);
            deadText.text = "99999+";
        }
    }
}
