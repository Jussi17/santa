using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KuusiRed : MonoBehaviour
{
    [SerializeField] private AudioSource evilLaughSound;
    private Animator anim;
    private BoxCollider2D bx;
    public GameObject vanhaKuusi;
    public GameObject uusiKuusi;
    public GameObject redEffect;

    void Start()
    {
        anim = GetComponent<Animator>();
        bx = GetComponent<BoxCollider2D>();
        anim.enabled = false;
        uusiKuusi.SetActive(false);
        redEffect.SetActive(false);
    }

    void Update()
    {
        if (PlayerPrefs.HasKey("KuusiChange"))
        {
            uusiKuusi.SetActive(true);
            vanhaKuusi.SetActive(false);
            bx.enabled = false;
            redEffect.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && !PlayerPrefs.HasKey("KuusiChange"))
        {
            anim.enabled = true;
            redEffect.SetActive(true);
            evilLaughSound.Play();
            bx.enabled = false;
            StartCoroutine(ChangeKuusi());
        }
    }
    IEnumerator ChangeKuusi()
    {
        yield return new WaitForSeconds(4f);
        PlayerPrefs.SetString("KuusiChange", "KuusiChange");
    }
}
