using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPlayer : MonoBehaviour
{
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            StartCoroutine(Bounce(-Vector2.up));
        }
    }
    private IEnumerator Bounce(Vector2 up)
    {
        float dashDistance = 4f;
        float dashDuration = 0.15f;
        float elapsedTime = 0f;
        while (elapsedTime < dashDuration)
        {
            float distanceToMove = dashDistance * Time.deltaTime / dashDuration;
            transform.Translate(up * distanceToMove);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
    }
}
