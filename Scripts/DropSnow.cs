using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropSnow : MonoBehaviour
{
    [SerializeField] private AudioSource evilLaugh;
    public GameObject snowBall;
    private bool hasLaughed = false;
    void Start()
    {
        snowBall.SetActive(false);
    }

    void Update()
    {
        if (PlayerPrefs.HasKey("LevelComplete13") && !PlayerPrefs.HasKey("SnowDrop"))
        {
            StartCoroutine(DroppaaSnow());
        }
    }
    IEnumerator DroppaaSnow()
    {
        yield return new WaitForSeconds(2.65f);
        snowBall.SetActive(true);
        yield return new WaitForSeconds(1f);
        if (!hasLaughed)
        {
            evilLaugh.Play();
            hasLaughed = true;
        }
        
        PlayerPrefs.SetString("SnowDrop","SnowDrop");
    }
}
