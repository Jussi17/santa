using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiEasy : MonoBehaviour
{
    public GameObject platForm;
    void Update()
    {
        if (PlayerPrefs.HasKey("ExtraHelp"))
        {
            platForm.SetActive(false);
        }
    }
}
