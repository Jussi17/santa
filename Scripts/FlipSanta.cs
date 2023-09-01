using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlipSanta : MonoBehaviour
{
    public GameObject red;
    public GameObject pink;
    public GameObject blue;
    public GameObject orange;
    public GameObject green;
    public GameObject purple;
    public GameObject goblin;
    [SerializeField] private AudioSource hohoSound;
    [SerializeField] private AudioSource grrSound;
    [SerializeField] private AudioSource ufoSound;
    [SerializeField] private AudioSource painSound;
    [SerializeField] private AudioSource sjSound;
    [SerializeField] private AudioSource coolSound;
    [SerializeField] private AudioSource sataSound;
    [SerializeField] private AudioSource sleighSound;
    [SerializeField] private AudioSource timeSound;
    private bool canPlay = true;
    private bool canUfopush = true;
    private bool canLaugh = true;
    private bool canPain = true;
    private bool canSjSound = true;
    private bool canCoolSound = true;
    private bool canSata = true;
    private bool canSleigh = true;
    private bool canTime = true;
    public GameObject sataButton;

    private void Start()
    {
        sataButton.SetActive(false);
    }
    private void Update()
    {
        if (PlayerPrefs.HasKey("Sata"))
        {
            sataButton.SetActive(true);
        }
    }
    public void OnFlipClick()
    {
        if (PlayerPrefs.HasKey("SantaRed"))
        {
            red.transform.Rotate(0, 180, 0);
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            pink.transform.Rotate(0, 180, 0);
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            blue.transform.Rotate(0, 180, 0);
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            orange.transform.Rotate(0, 180, 0);
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            green.transform.Rotate(0, 180, 0);
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            purple.transform.Rotate(0, 180, 0);
        }
        if (canLaugh)
        {
            hohoSound.Play();
            canLaugh = false;
            StartCoroutine(CanLaughAgain());
        }
    }
    IEnumerator CanLaughAgain()
    {
        yield return new WaitForSeconds(7);
        canLaugh = true;
    }
    public void OnSataClick()
    {
        if (canSata)
        {
            sataSound.Play();
            canSata = false;
            StartCoroutine(Satasia());
        }
    }
    public void OnSleighClick()
    {
        if (canSleigh)
        {
            sleighSound.Play();
            canSleigh = false;
            StartCoroutine(Kelkka());
        }
    }
    IEnumerator Kelkka()
    {
        yield return new WaitForSeconds(10);
        canSleigh = true;
    }
    IEnumerator Satasia()
    {
        yield return new WaitForSeconds(7);
        canSata = true;
    }
    public void OnCoolClick()
    {
        if (canCoolSound)
        {
            coolSound.Play();
            canCoolSound = false;
            StartCoroutine(CoolAgain());
        }
    }
    IEnumerator CoolAgain()
    {
        yield return new WaitForSeconds(6);
        canCoolSound = true;
    }
    public void OnSantaJourneyClick()
    {
        if (canSjSound)
        {
            sjSound.Play();
            canSjSound = false;
            StartCoroutine(CanSantaAgain());
        }
    }
    IEnumerator CanSantaAgain()
    {
        yield return new WaitForSeconds(5);
        canSjSound = true;
    }
    public void OnPainClick()
    {
        if (canPain)
        {
            painSound.Play();
            canPain = false;
            StartCoroutine(SattuuTaas());
        }
    }
    IEnumerator SattuuTaas()
    {
        yield return new WaitForSeconds(8);
        canPain = true;
    }
    public void OnTimeClick()
    {
        if (canTime)
        {
            timeSound.Play();
            canTime = false;
            StartCoroutine(KelloTaas());
        }
    }
    IEnumerator KelloTaas()
    {
        yield return new WaitForSeconds(8);
        canTime = true;
    }
    public void OnGrrClick()
    {
        if (canPlay)
        {
            grrSound.Play();
            canPlay = false;
            StartCoroutine(GrrSoundiTaas());
        }       
    }
    public void OnUfoClick()
    {
        if (canUfopush)
        {
            ufoSound.Play();
            canUfopush = false;
            StartCoroutine(UfoaTaas());
        }
    }
    IEnumerator UfoaTaas()
    {
        yield return new WaitForSeconds(12);
        canUfopush = true;
    }
    IEnumerator GrrSoundiTaas()
    {
        yield return new WaitForSeconds(12);
        canPlay = true;
    }
}
