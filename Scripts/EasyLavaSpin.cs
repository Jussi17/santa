using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyLavaSpin : MonoBehaviour
{
    public GameObject easyPlat;
    public GameObject easyPlat1;
    public bool lavaTouch = false;
    public Animator anim1;
    public Animator anim2;

    private void Start()
    {
        easyPlat.SetActive(false);
        easyPlat1.SetActive(false);
        anim1.enabled = false;
        anim2.enabled = false;
    }
    private void Update()
    {
        if (PlayerPrefs.HasKey("ExtraHelp"))
        {
            if (lavaTouch == true)
            {
                easyPlat.SetActive(true);
                easyPlat1.SetActive(true);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Rounded")
        {
            lavaTouch = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Rounded")
        {
            lavaTouch = false;
            anim1.enabled = true;
            anim2.enabled = true;
            StartCoroutine(EasyVeks());
        }
    }
    IEnumerator EasyVeks()
    {
        yield return new WaitForSeconds(2);
        anim1.enabled = false;
        anim2.enabled = false;
        easyPlat.SetActive(false);
        easyPlat1.SetActive(false);
    }
}
