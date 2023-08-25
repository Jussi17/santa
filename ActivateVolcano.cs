using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateVolcano : MonoBehaviour
{
    public GameObject kaytava;
    public GameObject volcano;
    public BoxCollider2D bx;
    public GameObject caveDoor;

    public GameObject back1;
    public GameObject back2;
    public GameObject back3;

    public GameObject temp1;
    public GameObject temp2;
    public GameObject temp3;
    public GameObject temp4;
    public GameObject volc1;
    public GameObject kuusi1;
    public GameObject kuusi2;
    public GameObject moon;
    public GameObject checkPoint;
    public GameObject sumu;

    public GameObject caveSprite;
    private void Start()
    {
        kaytava.SetActive(true);
        volcano.SetActive(false);
        bx.enabled = false;
        volc1.SetActive(true);
        temp1.SetActive(false);
        temp2.SetActive(false);
        temp3.SetActive(false);
        temp4.SetActive(false);
        kuusi1.SetActive(false);
        kuusi2.SetActive(false);
        back1.SetActive(false);
        back2.SetActive(false);
        back3.SetActive(false);
        checkPoint.SetActive(false);
        sumu.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            kaytava.SetActive(false);
            volcano.SetActive(true);
            bx.enabled = true;
            volc1.SetActive(false);
            temp1.SetActive(true);
            temp2.SetActive(true);
            temp3.SetActive(true);
            temp4.SetActive(true);
            kuusi1.SetActive(true);
            kuusi2.SetActive(true);
            back1.SetActive(true);
            back2.SetActive(true);
            back3.SetActive(true);
            moon.SetActive(false);
            checkPoint.SetActive(true);
            sumu.SetActive(true);
            caveSprite.SetActive(false);
        }
    }
}
