using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavingUImap : MonoBehaviour
{
    public GameObject uiObject;

    private void Start()
    {
        uiObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            uiObject.SetActive(true);
            StartCoroutine(venaaTovi());
        }
    }

    IEnumerator venaaTovi()
    {
        yield return new WaitForSeconds(5.3f);
        Destroy(uiObject);
        //Destroy(gameObject);
    }
}
