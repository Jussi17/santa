using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateVolcano : MonoBehaviour
{
    public GameObject kaytava;
    public GameObject volcano;
    public GameObject black;
    public GameObject black1;
    public BoxCollider2D bx;
    public GameObject kuusi;
    public GameObject kuusi1;
    public GameObject caveDoor;

    public GameObject temp1;
    public GameObject temp2;
    public GameObject temp3;
    public GameObject temp4;
    public GameObject volc1;

    public Animator anim;
    public SpriteRenderer checkiSprite;

    public GameObject caveSprite;

    private void Start()
    {
        caveSprite.SetActive(false);
        kaytava.SetActive(false);
        volcano.SetActive(true);
        black.SetActive(false);
        black1.SetActive(false);
        bx.enabled = false;
        volc1.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            anim.SetBool("eka", false);
            kaytava.SetActive(true);
            volcano.SetActive(false);
            black.SetActive(true);
            black1.SetActive(true);
            bx.enabled = true;
            volc1.SetActive(true);
            temp1.SetActive(false);
            temp2.SetActive(false);
            temp3.SetActive(false);
            temp4.SetActive(false);
            kuusi.SetActive(false);
            kuusi1.SetActive(false);
            caveSprite.SetActive(true);
            StartCoroutine(CeivDoor());
        }
    }

    IEnumerator CeivDoor()
    {
        yield return new WaitForSeconds(0.06f);
        checkiSprite.enabled = false;
        caveDoor.SetActive(false);
    }
}
