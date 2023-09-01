using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelCoinBuy : MonoBehaviour
{
    public GameObject panelCoinBuy;
    [SerializeField] private AudioSource music;
    private bool eiResetoi = false;

    void Update()
    {
        if (panelCoinBuy.activeInHierarchy)
        {
            eiResetoi = true;
        }
        if (!panelCoinBuy.activeInHierarchy && eiResetoi)
        {
            eiResetoi = false;
            OnAudioReset();
            if (music.isPlaying == false)
            {
                music.Play();
            }
        }
    }

    public void OnAudioReset()
    {
        AudioSettings.Reset(AudioSettings.GetConfiguration());
    }
}
