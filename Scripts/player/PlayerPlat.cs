using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlat : MonoBehaviour
{
    MoviNew12 movi;
    Movement movement;
    public GameObject movingPlatform;
    public bool onPlatform = false;

    void Start()
    {
        movi = movingPlatform.GetComponent<MoviNew12>();
        movement = GetComponent<Movement>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Goblin")
        {
            onPlatform = true;
            StartCoroutine(NotPlat());
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "MP")
        {
            if (movi.isPaused == false && onPlatform == true)
            {
                movement.moveSpeed = 16.3f;
                movement.jumpPower = 35.4f;
            }
        }
    }
    IEnumerator NotPlat()
    {
        yield return new WaitForSeconds(1.5f);
        onPlatform = false;
    }
}
