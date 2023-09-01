using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree61 : MonoBehaviour
{
    public Rigidbody2D puurb1;
    public Rigidbody2D puurb2;
    public Rigidbody2D puurb3;
    public GameObject edge1;
    public GameObject edge2;
    public GameObject edge3;
    [SerializeField] private AudioSource treeSound;
    private bool kaatunut = false;
    void Start()
    {
        puurb1.gravityScale = 0;
        puurb2.gravityScale = 0;
        puurb3.gravityScale = 0;
        edge1.SetActive(false);
        edge2.SetActive(false);
        edge3.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && !kaatunut)
        {
            puurb1.gravityScale = 3f;
            puurb2.gravityScale = 2f;
            puurb3.gravityScale = 1.2f;
            edge1.SetActive(true);
            edge2.SetActive(true);
            edge3.SetActive(true);
            StartCoroutine(VolaPuu());
        }
    }
    IEnumerator VolaPuu()
    {
        yield return new WaitForSeconds(0.6f);
        treeSound.Play();
        kaatunut = true;
    }
}
