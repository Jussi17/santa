using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxesOn : MonoBehaviour
{
    public GameObject boxes;
    [SerializeField] private AudioSource clickSound;
    private bool canClick = true;
    public SpriteRenderer circle;

    private void Start()
    {
        boxes.SetActive(false);
        circle.color = Color.green;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && canClick)
        {
            boxes.SetActive(true);
            canClick = false;
            clickSound.Play();
            circle.color = Color.red;
            StartCoroutine(CanClick());
        }
    }
    IEnumerator CanClick()
    {
        yield return new WaitForSeconds(31.3f);
        canClick = true;
        circle.color = Color.green;
    }
}
