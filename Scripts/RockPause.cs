using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockPause : MonoBehaviour
{
    [SerializeField] private AudioSource rock1;
    [SerializeField] private AudioSource rock2;
    [SerializeField] private AudioSource rock3;
    public GameObject pausePanel;

    void Update()
    {
        if (pausePanel.activeInHierarchy)
        {
            rock1.Pause();
            rock2.Pause();
            rock3.Pause();
        }
    }
}
