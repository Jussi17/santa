using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runaway : EnemyDamage
{
    [SerializeField] private float speed;
    [SerializeField] private float range;
    [SerializeField] private float checkDelay;
    [SerializeField] LayerMask playerLayer;
    private float checkTimer;
    private Vector3 destination;
    private bool hasPlayed = false;

    public Renderer birdRend;
    public CircleCollider2D coll;
    public Rigidbody2D rb;
    private Animator anim;
    public GameObject key;

    public GameObject reindeer;
    public GameObject reindeerPink;
    public GameObject reindeerBlue;
    public GameObject reindeerOrange;
    public GameObject reindeerGreen;
    public GameObject reindeerPurple;

    private bool attacking;

    private Vector3[] directions = new Vector3[4];

    [SerializeField] private AudioSource birdSound;

    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        birdRend.enabled = true;
        coll.enabled = true;

        if (PlayerPrefs.HasKey("SantaPink"))
        {
            reindeer = reindeerPink;
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            reindeer = reindeerBlue;
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            reindeer = reindeerOrange;
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            reindeer = reindeerGreen;
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            reindeer = reindeerPurple;
        }
    }

    private void OnEnable()
    {     
        Stop();
    }

    private void Update()
    {
        if (attacking)
        {           
            transform.Translate(-destination * Time.deltaTime * speed);
        }
        else
        {
            checkTimer += Time.deltaTime;
            if (checkTimer > checkDelay)
                CheckForPlayer();
        }

    }

    private void CheckForPlayer()
    {
        CalculateDirections();

        for (int i = 0; i < directions.Length; i++)
        {
            Debug.DrawRay(transform.position, directions[i], Color.red);
            RaycastHit2D hit = Physics2D.Raycast(transform.position, directions[i], range, playerLayer);

            if (hit.collider != null & !attacking)
            {
                attacking = true;
                destination = directions[i];
                checkTimer = 0;
            }
        }
    }
    private void CalculateDirections()
    {
        directions[0] = transform.right * range;
        directions[1] = -transform.right * range;
        directions[2] = transform.up * range;
        directions[3] = -transform.up * range;
    }

    private void Stop()
    {
        destination = transform.position;
        attacking = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Reindeer" || collision.gameObject.tag == "Player")
        {
            if (!hasPlayed)
            {
                birdSound.Play();
                hasPlayed = true;
            }
            rb.gravityScale = 1f;
            anim.SetTrigger("die");
            destination = -transform.up;
            key.transform.parent = null;
            key.transform.parent = reindeer.transform;
            key.transform.localPosition = new Vector3(0.3f, 0.2f, 0);
            StartCoroutine(Katoa());
        }
    }

    IEnumerator Katoa()
    {
        yield return new WaitForSeconds(2.1f);
        birdRend.enabled = false;
        coll.enabled = false; 

    }
}