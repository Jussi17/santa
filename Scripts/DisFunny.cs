using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisFunny : MonoBehaviour
{
    [SerializeField] private AudioSource evilLaugh;
    public GameObject dis;
    public GameObject block;
    private bool hasLaughed = false;

    void Update()
    {
        if (PlayerPrefs.HasKey("JokeOver"))
        {
            dis.SetActive(true);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && !PlayerPrefs.HasKey("JokeOver"))
        {        
            StartCoroutine(FunnyJoke());
        }
    }
    IEnumerator FunnyJoke()
    {
        yield return new WaitForSeconds(0.35f);
        dis.SetActive(false);
        block.SetActive(false);
        yield return new WaitForSeconds(0.55f);
        if (!hasLaughed)
        {
            evilLaugh.Play();
            hasLaughed = true;
        }     
        yield return new WaitForSeconds(2.3f);
        dis.SetActive(true);
        block.SetActive(true);
        PlayerPrefs.SetString("JokeOver","JokeOver");
    }
}
