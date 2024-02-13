using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterBall : MonoBehaviour
{
    private SpriteRenderer sprite;
    private bool onWater = false;
    public GameObject waterEffect;
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    
    void Update()
    {
        if (onWater)
        {
            sprite.color = new Color(0.2130295f, 0.3955168f, 0.4150943f, 1);
        }
        if (!onWater)
        {
            sprite.color = Color.white;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Viisi")
        {
            onWater = true;
            waterEffect.SetActive(true);
            StartCoroutine(PoisEfekti());
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Viisi")
        {
            onWater = false;
            waterEffect.SetActive(true);
            StartCoroutine(PoisEfekti());
        }
    }
    IEnumerator PoisEfekti()
    {
        yield return new WaitForSeconds(0.52f);
        waterEffect.SetActive(false);
    }
}
