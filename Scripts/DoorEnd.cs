using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DoorEnd : MonoBehaviour
{
    public Renderer oviRenderer;
    public BoxCollider2D bx;
    public CapsuleCollider2D cp;
    public Renderer locke;
    public GameObject giftImage;
    public GameObject numberImage;
    public GameObject lava;
    [SerializeField] private AudioSource doorSound;
    private bool hasPlayed = false;


    private void Start()
    {
        oviRenderer.enabled = true;
        bx.enabled = true;
        cp.enabled = true;
        locke.enabled = true;
        giftImage.SetActive(true);
        numberImage.SetActive(true);
        lava.SetActive(true);
    }

    private void Update()
    {
        if (PlayerPrefs.HasKey("Gift1") && PlayerPrefs.HasKey("Gift2") && PlayerPrefs.HasKey("Gift3") && PlayerPrefs.HasKey("Gift4") && PlayerPrefs.HasKey("Gift5") && PlayerPrefs.HasKey("Gift6") && PlayerPrefs.HasKey("Gift7") && PlayerPrefs.HasKey("Gift8") && PlayerPrefs.HasKey("Gift9") && PlayerPrefs.HasKey("Gift10") && PlayerPrefs.HasKey("Gift11") && PlayerPrefs.HasKey("Gift12") && PlayerPrefs.HasKey("Gift13") && PlayerPrefs.HasKey("Gift14") && PlayerPrefs.HasKey("Gift15") && PlayerPrefs.HasKey("Gift16") && PlayerPrefs.HasKey("Gift17") && PlayerPrefs.HasKey("Gift18") && PlayerPrefs.HasKey("Gift19") && PlayerPrefs.HasKey("Gift20") && PlayerPrefs.HasKey("Gift21") && PlayerPrefs.HasKey("Gift22") && PlayerPrefs.HasKey("Gift23") && PlayerPrefs.HasKey("Gift24") && PlayerPrefs.HasKey("Gift25") && PlayerPrefs.HasKey("Gift26") && PlayerPrefs.HasKey("Gift27") && PlayerPrefs.HasKey("Gift28") && PlayerPrefs.HasKey("Gift29") && PlayerPrefs.HasKey("Gift30") && PlayerPrefs.HasKey("Gift31") && PlayerPrefs.HasKey("Gift32") && PlayerPrefs.HasKey("Gift33") && PlayerPrefs.HasKey("Gift34") && PlayerPrefs.HasKey("Gift35") && PlayerPrefs.HasKey("Gift36") && PlayerPrefs.HasKey("Gift37") && PlayerPrefs.HasKey("Gift38") && PlayerPrefs.HasKey("Gift39") && PlayerPrefs.HasKey("Gift40") && PlayerPrefs.HasKey("Gift41") && PlayerPrefs.HasKey("Gift42") && PlayerPrefs.HasKey("Gift43") && PlayerPrefs.HasKey("Gift44") && PlayerPrefs.HasKey("Gift45") && PlayerPrefs.HasKey("Gift46") && PlayerPrefs.HasKey("Gift47") && PlayerPrefs.HasKey("Gift48"))
        {
            oviRenderer.enabled = false;
            bx.enabled = false;
            cp.enabled = false;
            locke.enabled = false;
            giftImage.SetActive(false);
            numberImage.SetActive(false);
            lava.SetActive(false);
            StartCoroutine(Soundi());
       
        }       
    }

    IEnumerator Soundi()
    {
        yield return new WaitForSeconds(1f);
        if (!hasPlayed && !PlayerPrefs.HasKey("Soinut"))
        {
            doorSound.Play();
            hasPlayed = true;
            PlayerPrefs.SetString("Soinut", "Soinut");
        }
    }
}