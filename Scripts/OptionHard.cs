using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionHard : MonoBehaviour
{
    public GameObject HardPlats;

    void Update()
    {
        if (PlayerPrefs.HasKey("ExtraHelp"))
        {
            HardPlats.SetActive(false);
        }
    }
}
