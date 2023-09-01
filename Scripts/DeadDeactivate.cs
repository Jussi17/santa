using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadDeactivate : MonoBehaviour
{
    Life life;
    public GameObject lifeCanvas;
    public GameObject enemies;
    void Start()
    {
        life = lifeCanvas.GetComponent<Life>();
    }

    void Update()
    {
        if (life.lives == 0)
        {
            enemies.SetActive(false);
        }
    }
}
