using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LahjaSakki34 : MonoBehaviour
{
    private SpriteRenderer sprite;
    public GameObject selitysCanvas;
    public GameObject controlCanvas;
    public GameObject dashButton;
    public GameObject players;
    public GameObject playersGetUps;
    public GameObject playersRein;
    private CapsuleCollider2D bx;
    public GameObject timeline;
    private BoxCollider2D boxCollider;

    void Start()
    {
        selitysCanvas.SetActive(false);
        playersGetUps.SetActive(false);
        bx = GetComponent<CapsuleCollider2D>();
        sprite = GetComponent<SpriteRenderer>();   
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            dashButton.SetActive(false);
            players.SetActive(false);
            playersGetUps.SetActive(true);
            boxCollider.enabled = false;  
            bx.enabled = false;
            timeline.SetActive(true);
            StartCoroutine(UudetHahmot());
        }
    }

    IEnumerator UudetHahmot() 
    {
        yield return new WaitForSeconds(1.1f);
        controlCanvas.SetActive(false);
        selitysCanvas.SetActive(true);
        playersGetUps.SetActive(false);
        playersRein.SetActive(true);
        sprite.enabled = false;
    }
}
