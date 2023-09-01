using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaughTree : MonoBehaviour
{
    public GameObject laughFace;
    [SerializeField] private AudioSource laugh;
    [SerializeField] private AudioSource goAway;
    public int hitCounter;
    private bool hasLaughed = false;
    void Start()
    {
        laughFace.SetActive(false);
        hitCounter = 0;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Reindeer" && !hasLaughed && hitCounter == 0)
        {
            laughFace.SetActive(true);
            hitCounter++;
            hasLaughed = true;
            laugh.Play();
            StartCoroutine(FaceOff());
        }
        if (collision.gameObject.tag == "Reindeer" && !hasLaughed && hitCounter == 1)
        {
            hitCounter++;
            hasLaughed = true;
            goAway.Play();
        }
    }
    IEnumerator FaceOff()
    {
        yield return new WaitForSeconds(4.17f);
        laughFace.SetActive(false);
        yield return new WaitForSeconds(0.15f);
        hasLaughed = false;
    }
}
