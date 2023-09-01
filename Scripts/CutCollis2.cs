using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutCollis2 : MonoBehaviour
{
    public Renderer rend;
    public BoxCollider2D bx;
    public CircleCollider2D cc;
   
    private void Start()
    {
        rend.enabled = true;
        bx.enabled = true;
        cc.enabled = true;
    }

    private void Update()
    {
        if (PlayerPrefs.HasKey("LevelComplete7"))
        {
            Destroy(bx);
            Destroy(rend);
            Destroy(cc);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && Time.timeSinceLevelLoad > 1f)
        {
            if (PlayerPrefs.HasKey("Upgraded"))
            {
                SceneManager.LoadScene("Cut2-3", LoadSceneMode.Single);
            }
            if (!PlayerPrefs.HasKey("Upgraded"))
            {
                SceneManager.LoadScene("Vali2-3", LoadSceneMode.Single);
            }
        }

    }
}
