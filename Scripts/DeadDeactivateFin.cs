using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadDeactivateFin : MonoBehaviour
{
    LifeFinale life;
    public GameObject lifeCanvas;
    public GameObject enemies;
    void Start()
    {
        life = lifeCanvas.GetComponent<LifeFinale>();
    }

    void Update()
    {
        if (life.lives == 0)
        {
            enemies.SetActive(false);
        }
    }
}
