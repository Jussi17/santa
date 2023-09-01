using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UfoKuusi : MonoBehaviour
{
    [SerializeField] private AudioSource scarySound;
    [SerializeField] private AudioSource mainMusic;
    public GameObject ufo;
    private BoxCollider2D bx;
    public GameObject canvas;
    public GameObject canvasHome;
    public Animator anim;
    void Start()
    {
        ufo.SetActive(false);
        bx = GetComponent<BoxCollider2D>();
        anim.enabled = false;
    }

    void Update()
    {
        if (PlayerPrefs.HasKey("UfoGone"))
        {
            ufo.SetActive(false);
            bx.enabled = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            mainMusic.Pause();
            ufo.SetActive(true);
            scarySound.Play();
            canvas.SetActive(false);
            canvasHome.SetActive(false);
            StartCoroutine(UfoPois());
        }
    }
    IEnumerator UfoPois()
    {
        yield return new WaitForSeconds(3.5f);
        canvas.SetActive(true);
        canvasHome.SetActive(true);
        yield return new WaitForSeconds(1f);
        anim.enabled = true;
        yield return new WaitForSeconds(1.5f);
        PlayerPrefs.SetString("UfoGone", "UfoGone");
        mainMusic.Play();
    }
}
