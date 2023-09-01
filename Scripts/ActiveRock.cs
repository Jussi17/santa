using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveRock : MonoBehaviour
{
    public GameObject blokkeri;
    public SpriteRenderer valo;
    [SerializeField] private AudioSource warnSound;
    private BoxCollider2D bx;
    private bool isHit = false;

    private void Start()
    {
        bx = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && !isHit)
        {
            warnSound.Play();
            valo.color = Color.green;
            blokkeri.SetActive(false);
            bx.enabled = false;
            isHit = true;
            StartCoroutine(BakkiiTaas());
        }
    }

    IEnumerator BakkiiTaas()
    {
        yield return new WaitForSeconds(3);       
        blokkeri.SetActive(true);   
        yield return new WaitForSeconds(3);
        bx.enabled = true;
        valo.color = Color.red;
        isHit = false;
    }
}
