using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivOffSet : MonoBehaviour
{
    public NewCamera cam;
    public GameObject g;
    public GameObject spike;
    public GameObject spike2;
    public GameObject spike3;
    public GameObject spike4;
    public GameObject spike5;
    public GameObject spike6;
    public GameObject craft;


    void Start()
    {
        cam = g.GetComponent<NewCamera>();
        spike.SetActive(false);
        spike2.SetActive(false);
        spike3.SetActive(false);
        spike4.SetActive(false);
        spike5.SetActive(false);
        spike6.SetActive(false);
        craft.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Sleigh")
        {
            cam.offset = -10f;
            spike.SetActive(true);
            StartCoroutine(Bolssonit());
        }
    }
    IEnumerator Bolssonit()
    {
        yield return new WaitForSeconds(1);
        spike2.SetActive(true);
        yield return new WaitForSeconds(1.2f);
        spike3.SetActive(true);
        yield return new WaitForSeconds(0.8f);
        spike4.SetActive(true);
        yield return new WaitForSeconds(1.05f);
        spike5.SetActive(true);
        yield return new WaitForSeconds(1.10f);
        spike6.SetActive(true);
        yield return new WaitForSeconds(1.2f);
        craft.SetActive(true);

    }

}
