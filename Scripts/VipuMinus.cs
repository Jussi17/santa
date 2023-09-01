using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VipuMinus : MonoBehaviour
{
    public Renderer rendDisappear;
    public BoxCollider2D bxDisappear;
    private Animator anim;
    [SerializeField] AudioSource audio;
    private bool isHit = false;

    void Start()
    {
        rendDisappear.enabled = true;
        bxDisappear.enabled = true;
        anim = GetComponent<Animator>();
        //anim.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Sleigh")
        {
            if (!isHit)
            {
                audio.Play();
                isHit = true;
            }
            
            anim.SetTrigger("vipu");
            //anim.enabled = true;
            StartCoroutine(Esiin());
        }
    }
    IEnumerator Esiin()
    {
        yield return new WaitForSeconds(0.3f);
        rendDisappear.enabled = false;
        bxDisappear.enabled = false;
        yield return new WaitForSeconds(2.2f);
        isHit = false;
        //anim.enabled = false;
        rendDisappear.enabled = true;
        bxDisappear.enabled = true;
    }

}
