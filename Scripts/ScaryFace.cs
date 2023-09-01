using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaryFace : MonoBehaviour
{
    public GameObject scaryActive;
    [SerializeField] private AudioSource scarySound;
    public GameObject scaryFace;
    private bool canLaugh = true;
 
    void Start()
    {
        scaryFace.SetActive(false);
    }

    void Update()
    {
        if (PlayerPrefs.HasKey("ScaryOff"))
        {
            scaryFace.SetActive(false);
            scaryActive.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (!PlayerPrefs.HasKey("ScaryOff"))
            {
                if (canLaugh)
                {
                    scarySound.Play();
                }            
                StartCoroutine(OffScary());
            }     
        }
    }

    IEnumerator OffScary()
    {
        yield return new WaitForSeconds(0.6f);
        scaryFace.SetActive(true);
        canLaugh = false;
        yield return new WaitForSeconds(2.94f);
        PlayerPrefs.SetString("ScaryOff", "ScaryOff");
    }
}
