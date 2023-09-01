using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceMoving : MonoBehaviour
{
    private Animator anim;
    public GameObject cloudWold;
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    public Transform platform;
    public Transform wolf;
    private bool isActive = false;
    Health health;
    public GameObject red;
    public GameObject pink;
    public GameObject blue;
    public GameObject orange;
    public GameObject green;
    public GameObject purple;
    [SerializeField] private Transform PlatForm;
    [SerializeField] private Transform respawnPoint;
    [SerializeField] private Transform Wolf;
    [SerializeField] private Transform respawnWolf;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        cloudWold.SetActive(false);
        if (PlayerPrefs.HasKey("SantaRed"))
        {
            health = red.GetComponent<Health>();
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            health = pink.GetComponent<Health>();
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            health = blue.GetComponent<Health>();
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            health = orange.GetComponent<Health>();
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            health = green.GetComponent<Health>();
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            health = purple.GetComponent<Health>();
        }
    }
    private void Update()
    {
        if (isActive)
        {
            if (health.dead)
            {
                PlatForm.transform.position = respawnPoint.transform.position;
                Wolf.transform.position = respawnWolf.transform.position;             
                cloudWold.SetActive(false);
                anim.SetBool("move", false);
                isActive = false;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Reindeer")
        {
            isActive = true;
            anim.SetBool("move", true);
            cloudWold.SetActive(true);
        }
    }
}
