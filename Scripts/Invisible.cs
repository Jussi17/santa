using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invisible : MonoBehaviour
{
    [SerializeField] private AudioSource appearSound;
    private SpriteRenderer puu;
    private bool hasAppeared = false;
    public BoxCollider2D bx;
    void Start()
    {
        puu = GetComponent<SpriteRenderer>();
        puu.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && !hasAppeared)
        {
            puu.enabled = true;
            hasAppeared = true;
            bx.enabled = false;
            appearSound.Play();
        }
    }
}
