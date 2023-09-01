using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacingLeft : MonoBehaviour
{
    public bool isOn;
    private Animator anim;
    public bool alaJuokse;
    void Awake()
    {
        anim = GetComponent<Animator>();
        if (PlayerPrefs.HasKey("9") || PlayerPrefs.HasKey("10") || PlayerPrefs.HasKey("11") || PlayerPrefs.HasKey("12") || PlayerPrefs.HasKey("13") || PlayerPrefs.HasKey("14") || PlayerPrefs.HasKey("15")  || PlayerPrefs.HasKey("21") || PlayerPrefs.HasKey("22") || PlayerPrefs.HasKey("23") || PlayerPrefs.HasKey("29") || PlayerPrefs.HasKey("30") || PlayerPrefs.HasKey("31") || PlayerPrefs.HasKey("32") || PlayerPrefs.HasKey("33") || PlayerPrefs.HasKey("34") || PlayerPrefs.HasKey("35"))
        {
            isOn = true;
        }
        if (PlayerPrefs.HasKey("UfoRight"))
        {
            isOn = false;
        }
        
        StartCoroutine(OffOn());
    }
    IEnumerator OffOn()
    {
        yield return new WaitForSeconds(0.05f);
        isOn = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {    
        if (collision.gameObject.tag == "Bopen")
        {
            alaJuokse = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bopen")
        {
            alaJuokse = false;
        }
    }
}
