using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal5 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            StartCoroutine(venaaTovi());
        }
    }
    IEnumerator venaaTovi()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Cut5-6", LoadSceneMode.Single);
    }

}
