using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SecurityBack : MonoBehaviour
{
    public GameObject securityButton;
    void Start()
    {
        securityButton.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Reindeer" || collision.gameObject.tag == "Sleigh")
        {
            StartCoroutine(ShowBack());
        }
    }
    IEnumerator ShowBack()
    {
        yield return new WaitForSeconds(9.2f);
        securityButton.SetActive(true);
    }
    public void OnSecurityClick()
    {
        SceneManager.LoadScene("OverLevel1", LoadSceneMode.Single);
    }
}
