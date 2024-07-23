using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeBlack : MonoBehaviour
{
    public GameObject blackCanvas;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Reindeer" || collision.gameObject.tag == "Sleigh")
        {
            StartCoroutine(Feidaa());
        }
    }
    IEnumerator Feidaa()
    {
        yield return new WaitForSeconds(3.5f);
        blackCanvas.SetActive(true);
    }
}
