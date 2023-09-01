using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxResp : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject laatikko;
    public GameObject boxes;
    [SerializeField] private Transform box;
    [SerializeField] private Transform respawnPoint;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (laatikko.activeInHierarchy)
        {
            StartCoroutine(BoxPoijes());
        }
    }
    IEnumerator BoxPoijes()
    {
        yield return new WaitForSeconds(30);
        box.transform.position = respawnPoint.transform.position;
        rb.velocity = new Vector2(0, 0);
        yield return new WaitForSeconds(1);
        boxes.SetActive(false);
    }
}
