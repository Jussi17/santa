using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogSleep : MonoBehaviour
{
    [SerializeField] private AudioSource sleepSound;
    public GameObject sleepDog;
    public GameObject wakeDog;
    public GameObject standDog;
    private bool hasWaken = false;
    private bool canSleep = false;
    public Animator anim;
    public int times = 0;
    void Start()
    {
        sleepDog.SetActive(true);
        wakeDog.SetActive(false);
        standDog.SetActive(false);
        anim.enabled = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && times < 2)
        {
            if (!hasWaken)
            {
                times++;
                wakeDog.SetActive(true);
                sleepDog.SetActive(false);
                hasWaken = true;
                StartCoroutine(WakeUp());
            }
        }
        if (collision.gameObject.tag == "Player" && times == 2)
        {
            times++;
            wakeDog.SetActive(false);
            sleepDog.SetActive(false);
            standDog.SetActive(true);
            anim.enabled = true;
        }
    }
    IEnumerator WakeUp()
    {
        yield return new WaitForSeconds(1.25f);
        canSleep = true;
        sleepDog.SetActive(true);
        wakeDog.SetActive(false);
        if (canSleep)
        {
            sleepSound.Play();
            canSleep = false;
        }              
        yield return new WaitForSeconds(5.2f);
        hasWaken = false;
        canSleep = true;
    }
}
