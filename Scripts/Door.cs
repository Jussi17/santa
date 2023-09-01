using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour
{
    public Renderer oviRenderer;
    public BoxCollider2D bx;
    public EdgeCollider2D ec;
    public CapsuleCollider2D cp;
    public Renderer locke;
    private bool hasPlayed = false;
    private Animator anim;

    [SerializeField] private AudioSource lockSound;

    private void Start()
    {
        oviRenderer.enabled = true;
        bx.enabled = true;
        ec.enabled = true;
        cp.enabled = true;
        locke.enabled = true;
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Key")
        {
            if (!hasPlayed)
            {
                lockSound.Play();
                hasPlayed = true;
            }
            
            StartCoroutine(DoorOpen());
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Key")
        {
            if (!hasPlayed)
            {
                lockSound.Play();              
                hasPlayed = true;
            }

            StartCoroutine(DoorOpen());
        }
    }
    IEnumerator DoorOpen()
    {
        yield return new WaitForSeconds(0.3f);
        anim.SetTrigger("open");
        locke.enabled = false;
        ec.enabled = false;
        bx.enabled = false;
        cp.enabled = false;
        yield return new WaitForSeconds(0.7f);
        oviRenderer.enabled = false;
      
        
    }
    

}