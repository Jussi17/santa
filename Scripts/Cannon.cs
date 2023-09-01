using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public Renderer fire;
    public GameObject Player;
    public GameObject PlayerPink;
    public GameObject PlayerBlue;
    public GameObject PlayerOrange;
    public GameObject PlayerGreen;
    public GameObject PlayerPurple;
    public GameObject Kanuuna;
    private float bounce = 20000f;
    private float upBOunce = 10f;
    private bool hasPlayed = false;
    public BoxCollider2D bxPoint;
    public CapsuleCollider2D capPoint;
    public EdgeCollider2D edPoint;
    public PolygonCollider2D poly;
    [SerializeField] private AudioSource cannonSound;
    [SerializeField] private AudioSource colSound;
    Vector3 localScale;

    private Rigidbody2D rb;
    [SerializeField] private Transform tykki;
    [SerializeField] private Transform respawnPoint;


    private void Awake()
    {
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            Player = PlayerPink;
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            Player = PlayerBlue;
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            Player = PlayerOrange;
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            Player = PlayerGreen;
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            Player = PlayerPurple;
        }
    }

    private void Start()
    {
        fire.enabled = false;
        bxPoint.enabled = false;
        capPoint.enabled = false;
        edPoint.enabled = false;
        poly.enabled = true;
        rb = GetComponent<Rigidbody2D>();
        localScale = transform.localScale;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
                bxPoint.enabled = true;
                capPoint.enabled = true;
                edPoint.enabled = true;
                fire.enabled = true;
                Player.transform.position = new Vector2(Kanuuna.transform.position.x, Kanuuna.transform.position.y);
                StartCoroutine(Ammu());
        }

        IEnumerator Ammu()
        {
                yield return new WaitForSeconds(1f);
                cannonSound.Play();
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * bounce, ForceMode2D.Impulse);
                fire.enabled = false;
                bxPoint.enabled = false;
                capPoint.enabled = false;
                edPoint.enabled = false;
                //collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bounce, ForceMode2D.Impulse);
            
        }

        if (collision.gameObject.tag == "Lava")
        {
            tykki.transform.position = new Vector3(respawnPoint.transform.position.x, respawnPoint.transform.position.y, respawnPoint.transform.position.z);
            rb.velocity = new Vector2(0, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Grab")
        {
            localScale.x = -1;
            transform.localScale = localScale;
            if (!hasPlayed)
            {
                colSound.Play();
                hasPlayed = true;
                StartCoroutine(VolatKaakosta());
            }
        }

    }
    IEnumerator VolatKaakosta()
    {
        yield return new WaitForSeconds(6);
        hasPlayed = false;
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            poly.enabled = true;
        }
        else
        {
            poly.enabled = false;
        }
    }
}
