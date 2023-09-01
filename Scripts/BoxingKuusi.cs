using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxingKuusi : MonoBehaviour
{
    public GameObject boxingGlove;
    private BoxCollider2D bx;
    [SerializeField] private AudioSource hitSound;
    [SerializeField] private AudioSource laughSound;
    [SerializeField] private AudioSource painSound;
    void Start()
    {
        boxingGlove.SetActive(false);
        bx = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        if (PlayerPrefs.HasKey("Boxing"))
        {
            boxingGlove.SetActive(false);
            bx.enabled = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            boxingGlove.SetActive(true);
            hitSound.Play();
            StartCoroutine(GloveOff());
        }
    }
    IEnumerator GloveOff()
    {
        yield return new WaitForSeconds(0.2f);
        painSound.Play();
        yield return new WaitForSeconds(0.3f);
        boxingGlove.SetActive(false);
        PlayerPrefs.SetString("Boxing", "Boxing");
        yield return new WaitForSeconds(1f);
        laughSound.Play();
    }
}
