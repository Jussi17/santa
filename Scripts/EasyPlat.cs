using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyPlat : MonoBehaviour
{
    public GameObject easyPlats;

    void Update()
    {
        if (!PlayerPrefs.HasKey("ExtraHelp"))
        {
            easyPlats.SetActive(false);
        }
    }
}
