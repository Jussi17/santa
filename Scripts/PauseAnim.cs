using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseAnim : MonoBehaviour
{
    private Animator anim;
    public GameObject pauseCanvas;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (pauseCanvas.activeInHierarchy)
        {
            anim.enabled = true;
        }
        if (!pauseCanvas.activeInHierarchy)
        {
            anim.enabled = false;
        }
    }
}
