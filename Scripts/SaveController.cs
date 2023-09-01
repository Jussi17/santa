using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")|| other.CompareTag("Reindeer") || other.CompareTag("Sleigh"))
        {
            if (!PlayerPrefs.HasKey("Cutti"))
            {
                string activeScene = SceneManager.GetActiveScene().name;
                PlayerPrefs.SetString("LevelSaved", activeScene);
                Debug.Log("Save");
            }         
        }
    }
}
