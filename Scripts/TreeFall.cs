using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeFall : MonoBehaviour
{
    private Animator anim;
    public GameObject kuusiFall;
    public GameObject kuusiFelt;

    void Start()
    {
        anim = GetComponent<Animator>();
        kuusiFelt.SetActive(false);
    }

    void Update()
    {
        if (PlayerPrefs.HasKey("TreeFall") && PlayerPrefs.HasKey("LevelComplete16"))
        {
            kuusiFelt.SetActive(true);
            kuusiFall.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && !PlayerPrefs.HasKey("LevelComplete16"))
        {
            anim.SetBool("fall", true);
            StartCoroutine(ChangeKuusi());           
        }
    }
    IEnumerator ChangeKuusi()
    {
        yield return new WaitForSeconds(1.2f);
        PlayerPrefs.SetString("TreeFall", "TreeFall");
    }
}
