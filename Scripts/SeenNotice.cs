using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class SeenNotice : MonoBehaviour
{
    public GameObject NoticePanel;

    public void Start()
    {
        NoticePanel.SetActive(false);
    }

    public void Update()
    {
        if (PlayerPrefs.HasKey("LevelComplete") && !PlayerPrefs.HasKey("SeenNotice"))
        {
            if (PlayerPrefs.HasKey("UnlockedPink") && PlayerPrefs.HasKey("UnlockedOrange") && PlayerPrefs.HasKey("UnlockedPurple"))
            {
                if (!PlayerPrefs.HasKey("NewGame"))
                {
                    NoticePanel.SetActive(true);
                }
                

            }
        }
    }

    public void OnOkClick()
    {
        PlayerPrefs.SetString("SeenNotice", "SeenNotice");
        NoticePanel.SetActive(false);
    }
}
