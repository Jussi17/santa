using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ninninehandler : MonoBehaviour
{
    public GameObject ninetyNine;
    void Update()
    {
        if (PlayerPrefs.HasKey("NinetyNine"))
        {
            StartCoroutine("PoisNine");
            
        }
    }
    IEnumerator PoisNine()
    {
        yield return new WaitForSeconds(4.5f);
        ninetyNine.SetActive(false);
    }
}
