using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyDis : MonoBehaviour
{
    [SerializeField] private AudioSource evilLaugh;
    public BoxCollider2D bx;
    public CapsuleCollider2D bx1;
    public GameObject mapButton;

    private void Start()
    {
        bx = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        if (PlayerPrefs.HasKey("CandyOff"))
        {
            bx.enabled = false;
            bx1.enabled = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerPrefs.SetString("CandyOff", "CandyOff");
            evilLaugh.Play();
            mapButton.SetActive(true);
        }
    }
}
