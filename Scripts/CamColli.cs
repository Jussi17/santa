using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamColli : MonoBehaviour
{
    private GameObject shine;
    public GameObject shineRed;
    public GameObject shinePink;
    public GameObject shineBlue;
    public GameObject shineOrange;
    public GameObject shineGreen;
    public GameObject shinePurple;
    void Start()
    {
        if (PlayerPrefs.HasKey("SantaRed"))
        {
            shine = shineRed;
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            shine = shinePink;
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            shine = shineBlue;
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            shine = shineOrange;
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            shine = shineGreen;
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            shine = shinePurple;
        }
        shine.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Puu")
        {
            shine.SetActive(true);
            StartCoroutine(OffShine());
        }
    }
    IEnumerator OffShine()
    {
        yield return new WaitForSeconds(0.27f);
        shine.SetActive(false);
    }
}
