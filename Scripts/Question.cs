using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question : MonoBehaviour
{
    public GameObject question;
    void Start()
    {
        question.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Eka")
        {
            question.SetActive(true);
            StartCoroutine(QuesPois());
        }
        if (col.gameObject.tag == "Slow")
        {
            question.SetActive(false);
        }
    }
    IEnumerator QuesPois()
    {
        yield return new WaitForSeconds(3);
        question.SetActive(false);
    }
}
