using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaavaChase : MonoBehaviour
{
    public GameObject chaseLava;
    [SerializeField] private AudioSource fireSound;
    void Start()
    {
        chaseLava.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Kuus")
        {
            fireSound.Play();
            chaseLava.SetActive(true);
            StartCoroutine(LavaBack());
        }
    }
    IEnumerator LavaBack()
    {
        yield return new WaitForSeconds(9f);
        chaseLava.SetActive(false);
    }
}
