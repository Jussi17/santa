using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallBall : MonoBehaviour
{
    [SerializeField] private AudioSource fallSound;
    private bool hasDropped = false;
    public GameObject snowBall;

    void Start()
    {
        //snowBall.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && !hasDropped)
        {
            snowBall.SetActive(true);
            hasDropped = true;
            fallSound.Play();
            StartCoroutine(BallDrop());
        }
    }

    IEnumerator BallDrop()
    {
        yield return new WaitForSeconds(2.5f);
        hasDropped = false;
    }
}
