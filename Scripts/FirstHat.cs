using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstHat : MonoBehaviour
{
    public GameObject hat;
    public GameObject hatSnowman;
    public Animator animHat;
    public GameObject snowman;
    [SerializeField] private AudioSource dashSound;
    private bool hasPlayed = false;
    private bool hasWinked = false;
    private bool hasTurned = false;
    public Animator anim;
    public int times = 0;
    public SpriteRenderer arm;
    private bool hasSaluted = false;

    void Start()
    {
        animHat.enabled = false;
        hatSnowman.SetActive(false);
    }

    private void Update()
    {
        if (times == 2 && !hasSaluted)
        {
            hasSaluted = true;
            anim.SetBool("salute", true);
            StartCoroutine(HandsOff());
        }
    }
    IEnumerator HandsOff()
    {
        yield return new WaitForSeconds(1.6f);
        anim.SetBool("salute", false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && times < 3)
        {
            if (!hasPlayed)
            {
                times++;
                dashSound.Play();
                hasPlayed = true;
                animHat.enabled = true;
                StartCoroutine(VoiceBack());
            }
        }
    }
    IEnumerator VoiceBack()
    {
        yield return new WaitForSeconds(1.15f);
        hatSnowman.SetActive(true);
        hat.SetActive(false);
        //hat.transform.parent = snowman.transform;
        if (!hasWinked)
        {
            snowman.transform.Rotate(0, 180, 0);
            yield return new WaitForSeconds(0.2f);
            anim.SetBool("wink", true);
            hasWinked = true;
        }
        if (times == 1)
        {
            yield return new WaitForSeconds(0.55f);
            anim.SetBool("wink", false);
        }  
        yield return new WaitForSeconds(1.5f);   
        if (!hasTurned)
        {
            snowman.transform.Rotate(0, 180, 0);
            hasTurned = true;
        }
        hasPlayed = false;
    }

}
