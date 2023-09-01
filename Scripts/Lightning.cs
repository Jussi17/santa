using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightning : MonoBehaviour
{
    public SpriteRenderer lightning;
    public GameObject kokoLight;

    private void Start()
    {
        lightning = kokoLight.GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        if (!PlayerPrefs.HasKey("Salama1"))
        {
            lightning.enabled = false;
        }
        if (PlayerPrefs.HasKey("Salama1") && !PlayerPrefs.HasKey("Salama"))
        {
            lightning.enabled = true;
        }
        if (PlayerPrefs.HasKey("Salama"))
        {
            lightning.enabled = false;
        }
    }
}
