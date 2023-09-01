using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SemiLevelController : MonoBehaviour
{
    private int nextSceneLoad;

    void Start()
    {
        nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Sleigh")
        {
            StartCoroutine(Odotus());           
        }
    }

    IEnumerator Odotus()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(nextSceneLoad);
    }

}
