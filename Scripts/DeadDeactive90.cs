using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadDeactive90 : MonoBehaviour
{
    LifeLev90 life;
    public GameObject lifeCanvas;
    public GameObject enemies;
    void Start()
    {
        life = lifeCanvas.GetComponent<LifeLev90>();
    }

    void Update()
    {
        if (life.lives == 0)
        {
            enemies.SetActive(false);
        }
    }
}
