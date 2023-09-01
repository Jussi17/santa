using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavingUI : MonoBehaviour
{
    public GameObject uiObject;

    private void Start()
    {
        uiObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Reindeer"|| collision.gameObject.tag == "Sleigh")
        {
            uiObject.SetActive(true);
            StartCoroutine(venaaTovi());
        }
    }

    IEnumerator venaaTovi()
    {
        yield return new WaitForSeconds(3);
        Destroy(uiObject);
        //Destroy(gameObject);
    }
}
