using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;

public class SleighMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] public float sleighSpeed = 170f;
    private Animator anim;
    public GameObject redSanta;
    public GameObject pinkSanta;
    public GameObject blueSanta;
    public GameObject orangeSanta;
    public GameObject greenSanta;
    public GameObject purpleSanta;

    private Vector3 localScale;
    public RespawnReki respawn;
    private bool canRunSound = true;

    [SerializeField] float jumpPower = 700f;
    private bool grounded;
    public bool showGrounded;
    public Transform groundCheck;

    [SerializeField] LayerMask groundLayer;
    private BoxCollider2D boxCollider;
    private CircleCollider2D circleCollider;
    [SerializeField] ParticleSystem particleSystem;

    [Header("Coyote Time")]
    [SerializeField] private float coyoteTime; 
    private float coyoteCounter;

    [Header("Multiple Jumps")]
    [SerializeField] private int extraJumps;
    private int jumpCounter;

    [SerializeField] private AudioSource runSound;
    [SerializeField] private AudioSource lavaSound;
    HealthReki health;

    private void Awake()
    {
        if (PlayerPrefs.HasKey("SantaRed"))
        {
            redSanta.SetActive(true);
            pinkSanta.SetActive(false);
            blueSanta.SetActive(false);
            orangeSanta.SetActive(false);
            greenSanta.SetActive(false);
            purpleSanta.SetActive(false);
            health = redSanta.GetComponent<HealthReki>();
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            redSanta.SetActive(false);
            pinkSanta.SetActive(true);
            blueSanta.SetActive(false);
            orangeSanta.SetActive(false);
            greenSanta.SetActive(false);
            purpleSanta.SetActive(false);
            health = pinkSanta.GetComponent<HealthReki>();
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            redSanta.SetActive(false);
            pinkSanta.SetActive(false);
            blueSanta.SetActive(true);
            orangeSanta.SetActive(false);
            greenSanta.SetActive(false);
            purpleSanta.SetActive(false);
            health = blueSanta.GetComponent<HealthReki>();
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            redSanta.SetActive(false);
            pinkSanta.SetActive(false);
            blueSanta.SetActive(false);
            orangeSanta.SetActive(true);
            greenSanta.SetActive(false);
            purpleSanta.SetActive(false);
            health = orangeSanta.GetComponent<HealthReki>();
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            redSanta.SetActive(false);
            pinkSanta.SetActive(false);
            blueSanta.SetActive(false);
            orangeSanta.SetActive(false);
            greenSanta.SetActive(true);
            purpleSanta.SetActive(false);
            health = greenSanta.GetComponent<HealthReki>();
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            redSanta.SetActive(false);
            pinkSanta.SetActive(false);
            blueSanta.SetActive(false);
            orangeSanta.SetActive(false);
            greenSanta.SetActive(false);
            purpleSanta.SetActive(true);
            health = purpleSanta.GetComponent<HealthReki>();
        }
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        respawn = GetComponent<RespawnReki>();
        circleCollider = GetComponent<CircleCollider2D>();
        localScale = transform.localScale;
    }
    void Update()
    {
        if (Input.touchCount > 0)
        {
            var x = CrossPlatformInputManager.GetAxis("Horizontal") * Time.deltaTime * 150f;
            var z = CrossPlatformInputManager.GetAxis("Vertical") * Time.deltaTime * 3f;
            transform.Rotate(0, 0, -x);
            transform.Translate(0, 0, 0);

            if (CrossPlatformInputManager.GetButtonDown("Jump") && isGrounded())
            {
                jumpCounter--;
                Jump();
            }

            if (isGrounded())
            {
                coyoteCounter = coyoteTime; 
                jumpCounter = extraJumps;
            }
            else
            {
                coyoteCounter -= Time.deltaTime;
            }
        }

        showGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.15f, groundLayer);

        if (isGrounded() && canRunSound)
        {
            runSound.Play();
            canRunSound = false;
            StartCoroutine(RunAgain());
        }
        if (!isGrounded())
        {
            runSound.Stop();
            canRunSound = true;
        }
        if (health.dead)
        {
            sleighSpeed = 170f;
        }
        if (sleighSpeed >= 220)
        {
            runSound.pitch = 1.35f;
        }
        if (sleighSpeed < 220)
        {
            runSound.pitch = 1;
        }
    }

    private void FixedUpdate()
    {
        if (rb.velocity.x >= 0 && rb.velocity.y >= 0 && isGrounded())
        {
            rb.AddForce(Vector2.right * sleighSpeed * 1.3f);
        }

        if (rb.velocity.x <= 0 && rb.velocity.y >= 0 && isGrounded())
        {
            rb.AddForce(Vector2.right * sleighSpeed * 1.3f);
        }

        if (!isGrounded())
        {
            rb.AddForce(Vector2.right * sleighSpeed / 1.5f);
        }

        if (rb.velocity.y <= 0)
        {
            rb.AddForce(Vector2.right * sleighSpeed * 1.3f);
        }
        if (rb.velocity.x == 0)
        {
            rb.AddForce(Vector2.right * sleighSpeed * 1.3f);
        }
        if (rb.velocity.y == 0)
        {
            rb.AddForce(Vector2.right * sleighSpeed * 1.3f);
        }
    }

    void Jump()
    {
        if (coyoteCounter <= 0 && jumpCounter <= 0) return;

        if (isGrounded())
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        else
        {
            if (coyoteCounter > 0)
                rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            else
            {
                if (jumpCounter > 0) 
                {
                    rb.velocity = new Vector2(rb.velocity.x, jumpPower);
                    jumpCounter--;
                }
            }
        }
        coyoteCounter = 0;
    }


    private bool isGrounded()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(circleCollider.bounds.center, circleCollider.bounds.size, 0, Vector2.down, 0.1f, groundLayer);
        return raycastHit.collider != null;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Goal")
        {
            gameObject.SetActive(false);
        }
        if (col.gameObject.tag == "Checkpoint")
        {
        }
        if (col.gameObject.tag == "Lava")
        {
            lavaSound.Play();
            StartCoroutine(venaus());
        }
        if (col.gameObject.tag == "Fast")
        {
            sleighSpeed = sleighSpeed + 15;
        }
        if (col.gameObject.tag == "Slow")
        {
            if (sleighSpeed > 50)
            {
                sleighSpeed = sleighSpeed - 20;
            }        
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded = true;
            particleSystem.Play();
        }

        if (collision.gameObject.tag == "Lava")
        {
            lavaSound.Play();
            StartCoroutine(venaus());
        }

        if (collision.gameObject.tag == "Ball")
        {
            rb.AddForce(Vector2.up * sleighSpeed *100f);
            rb.AddForce(Vector2.right * sleighSpeed * 50f);
        }
        if (collision.gameObject.tag == "Cam")
        {
            rb.AddForce(Vector2.up * sleighSpeed * 48f);
            rb.AddForce(Vector2.right * sleighSpeed * 30f);
        }
        if (collision.gameObject.tag == "DARig")
        {
            rb.AddForce(Vector2.right * sleighSpeed * 34f);
        }

    }

    IEnumerator venaus()
    {
        yield return new WaitForSeconds(0.1f);
        transform.position = respawn.currentCheckpoint.transform.position;
    }
    IEnumerator RunAgain()
    {
        yield return new WaitForSeconds(15.265f);
        canRunSound = true;
    }
}
