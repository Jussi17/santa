using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GobBino : MonoBehaviour
{
    [SerializeField] private AudioSource ufoSound;
    public GameObject goblin;
    public GameObject ufo;
    public GameObject ufoRise;
    private BoxCollider2D bx;

    void Start()
    {
        goblin.SetActive(false);
        ufo.SetActive(false);
        ufoRise.SetActive(false);
        bx = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        if (PlayerPrefs.HasKey("LevelComplete2") && !PlayerPrefs.HasKey("LevelComplete3"))
        {
            goblin.SetActive(true);
            ufo.SetActive(true);
        }
        if (PlayerPrefs.HasKey("LevelComplete3"))
        {
            goblin.SetActive(false);
            ufo.SetActive(false);
            bx.enabled = false;
            if (!PlayerPrefs.HasKey("UfoRise"))
            {
                ufoRise.SetActive(true);
                PlayerPrefs.SetString("UfoRise","UfoRise");
                StartCoroutine(UfoRisePois());
            }
        }
    }
    IEnumerator UfoRisePois()
    {
        yield return new WaitForSeconds(3f);
        ufoSound.Play();
        yield return new WaitForSeconds(3f);
        ufoRise.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            goblin.transform.Rotate(0f, 180f, 0f);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            goblin.transform.Rotate(0f, 180f, 0f);
        }
    }
}
