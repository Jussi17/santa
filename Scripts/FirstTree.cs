using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstTree : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject box;
    [SerializeField] private AudioSource ohnoSound;
    void Start()
    {
        rb.gravityScale = 0;
    }

    void Update()
    {
        if (PlayerPrefs.HasKey("BoxPois"))
        {
            box.SetActive(false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && !PlayerPrefs.HasKey("BoxPois"))
        {
            rb.gravityScale = 1;
            StartCoroutine(BoxOff());
        }
    }
    IEnumerator BoxOff()
    {
        yield return new WaitForSeconds(1);
        ohnoSound.Play();
        yield return new WaitForSeconds(2);
        PlayerPrefs.SetString("BoxPois", "BoxPois");
    }
}
