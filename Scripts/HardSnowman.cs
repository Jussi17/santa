using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardSnowman : MonoBehaviour
{
    private Animator anim;
    public GameObject AxeObject;
    Axe axe;
    void Start()
    {
        anim = GetComponent<Animator>();
        axe = AxeObject.GetComponent<Axe>();
    }


    void Update()
    {
        if (axe.isDown == true)
        {
            StartCoroutine(AloitaAnim());          
        }
    }
    IEnumerator AloitaAnim()
    {
        yield return new WaitForSeconds(0.5f);
        anim.SetBool("move",true);
        yield return new WaitForSeconds(0.5f);
    }

}
