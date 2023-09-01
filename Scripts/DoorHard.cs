using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorHard : MonoBehaviour
{
    public Renderer oviRenderer;
    public BoxCollider2D bx;
    public CapsuleCollider2D cp;
    public Renderer locke;
    public GameObject lava;


    void Start()
    {
        oviRenderer.enabled = true;
        bx.enabled = true;
        cp.enabled = true;
        locke.enabled = true;
        lava.SetActive(true);
    }


    void Update()
    {
            if (PlayerPrefs.HasKey("Finaali"))
            {
                oviRenderer.enabled = false;
                bx.enabled = false;
                cp.enabled = false;
                locke.enabled = false;
                lava.SetActive(false);
            }
    }
}
