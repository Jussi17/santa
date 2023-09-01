using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowLevel : MonoBehaviour
{
    void Start()
    {
        PlayerPrefs.GetInt("LevelCompleted");
        Debug.Log(PlayerPrefs.GetInt("LevelCompleted"));
    }


}
