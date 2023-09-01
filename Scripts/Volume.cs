using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    public Text volText;
    private bool canChangeColor = true;

    void Start()
    {
        if (!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
        }
        else
        {
            Load();
        }
    }

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        volText.color = Color.green;
        Save();
        if (canChangeColor)
        {
            StartCoroutine(textBack());
        }
    
    }

    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }
    IEnumerator textBack()
    {
        canChangeColor = false;
        yield return new WaitForSeconds(2);
        canChangeColor = true;
        volText.color = Color.white;
    }
}
