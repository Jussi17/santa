using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UfoWait : MonoBehaviour
{
    [SerializeField] private AudioSource ufoSound;
    public GameObject ufo;
    public GameObject canvas;
    public GameObject canvasHome;
    private bool hasPlayed = false;

    void Start()
    {
        ufo.SetActive(false);
    }


    void Update()
    {
        if (PlayerPrefs.HasKey("LevelComplete21") && !PlayerPrefs.HasKey("UfoVeks"))
        {
            if (!hasPlayed)
            {                
                ufo.SetActive(true);               
                hasPlayed = true;
                StartCoroutine(UfoPois());
            }
        }
    }
    IEnumerator UfoPois()
    {
        yield return new WaitForSeconds(2.4f);
        canvas.SetActive(false);
        canvasHome.SetActive(false);
        ufoSound.Play();
        yield return new WaitForSeconds(2.6f);
        ufo.SetActive(false);
        canvas.SetActive(true);
        canvasHome.SetActive(true);
        PlayerPrefs.SetString("UfoVeks", "UfoVeks");
    }
}
