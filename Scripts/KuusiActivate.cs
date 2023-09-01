using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KuusiActivate : MonoBehaviour
{
    [SerializeField] private AudioSource kuusiSound;
    public GameObject theKuusi;
    public Animator anim;
    private BoxCollider2D bx;
    void Start()
    {
        anim.enabled = false;
        bx = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        if (PlayerPrefs.HasKey("KuusiOff"))
        {
            theKuusi.SetActive(false);
            bx.enabled = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (!PlayerPrefs.HasKey("KuusiOff"))
            {
                anim.enabled = true;
                kuusiSound.Play();
                StartCoroutine(AnimOff());
            }  
        }
    }

    IEnumerator AnimOff()
    {
        yield return new WaitForSeconds(1.8f);
        theKuusi.SetActive(false);
        anim.enabled = false;
        PlayerPrefs.SetString("KuusiOff", "KuusiOff");
    }
}
