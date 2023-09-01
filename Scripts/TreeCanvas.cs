using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeCanvas : MonoBehaviour
{
    public GameObject treeCanvas;
    [SerializeField] private AudioSource hurrySound;
    private bool hasShowed = false;
    public Animator anim;
    void Start()
    {
        treeCanvas.SetActive(false);
        anim.enabled = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && !hasShowed)
        {
            treeCanvas.SetActive(true);
            hurrySound.Play();
            hasShowed = true;
            anim.enabled = true;
            StartCoroutine(CanvasVecca());
        }
    }
    IEnumerator CanvasVecca()
    {
        yield return new WaitForSeconds(3.5f);
        treeCanvas.SetActive(false);
        anim.enabled = false;
    }
}
