using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisaBx : MonoBehaviour
{
    [SerializeField] private AudioSource warnSound;
    public Renderer renderer;
    public BoxCollider2D bx;
    private bool hasDis = false;
    public GameObject deactKuusi;
    public GameObject boxes;
    Lv51Deact lv;

    private void Start()
    {
        lv = deactKuusi.GetComponent<Lv51Deact>();
    }

    private void Update()
    {
        if (hasDis)
        {
            renderer.enabled = true;
            bx.enabled = true;
        }
        if (lv.boxesOff)
        {
            Destroy(boxes);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            warnSound.Play();
            StartCoroutine(Wait());
        }
    }


    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.5f);
        hasDis = false;
        renderer.enabled = false;
        bx.enabled = false;
        yield return new WaitForSeconds(3.5f);
        hasDis = true;
    }
}

