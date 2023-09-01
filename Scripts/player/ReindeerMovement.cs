using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;

public class ReindeerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    public GameObject redSanta;
    public GameObject pinkSanta;
    public GameObject blueSanta;
    public GameObject orangeSanta;
    public GameObject greenSanta;
    public GameObject purpleSanta;
    public GameObject wolf;
    public GameObject runWolf;
    public GameObject runWolf2;
    public GameObject attackWolf;
    public GameObject lastWolf;
    public float barkRate = 2f;
    float nextBarkTime = 0f;

    [SerializeField]LayerMask groundLayer;
    private BoxCollider2D boxCollider;
    public Transform groundCheck;

    [SerializeField] float jumpPower = 700f;
    private int jumps = 1;
    public int jumpsLeft;

    private bool canJump;
    private bool canPlay = false;
    private bool canRunSound = true;
    private bool cpSoundPlayed = false;
    private bool canBark = true;

    private float moveSpeed;
    private float dirX;
    private bool facingRight = true;
    private Vector3 localScale;
    
    public Respawn respawn;
    public Transform key;
    [SerializeField] ParticleSystem particleSnow;
    public GameObject canvasBlack;

    [SerializeField] private AudioSource lavaSound;
    [SerializeField] private AudioSource jumpSound;
    [SerializeField] private AudioSource dogSound;
    [SerializeField] private AudioSource shortDogSound;
    [SerializeField] private AudioSource waterSound;
    [SerializeField] private AudioSource runSound;
    Health health;

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
            health = redSanta.GetComponent<Health>();
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            redSanta.SetActive(false);
            pinkSanta.SetActive(true);
            blueSanta.SetActive(false);
            orangeSanta.SetActive(false);
            greenSanta.SetActive(false);
            purpleSanta.SetActive(false);
            health = pinkSanta.GetComponent<Health>();
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            redSanta.SetActive(false);
            pinkSanta.SetActive(false);
            blueSanta.SetActive(true);
            orangeSanta.SetActive(false);
            greenSanta.SetActive(false);
            purpleSanta.SetActive(false);
            health = blueSanta.GetComponent<Health>();
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            redSanta.SetActive(false);
            pinkSanta.SetActive(false);
            blueSanta.SetActive(false);
            orangeSanta.SetActive(true);
            greenSanta.SetActive(false);
            purpleSanta.SetActive(false);
            health = orangeSanta.GetComponent<Health>();
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            redSanta.SetActive(false);
            pinkSanta.SetActive(false);
            blueSanta.SetActive(false);
            orangeSanta.SetActive(false);
            greenSanta.SetActive(true);
            purpleSanta.SetActive(false);
            health = greenSanta.GetComponent<Health>();
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            redSanta.SetActive(false);
            pinkSanta.SetActive(false);
            blueSanta.SetActive(false);
            orangeSanta.SetActive(false);
            greenSanta.SetActive(false);
            purpleSanta.SetActive(true);
            health = purpleSanta.GetComponent<Health>();
        }

    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        respawn = GetComponent<Respawn>();
        boxCollider = GetComponent<BoxCollider2D>();
        localScale = transform.localScale;       
        moveSpeed = 7.2f;
        runWolf.SetActive(false);
        runWolf2.SetActive(false);
        attackWolf.SetActive(false);
        lastWolf.SetActive(false);
        canvasBlack.SetActive(false);
    }
    void Update()
    {
        anim.SetBool("grounded", isGrounded());
        anim.SetBool("run", dirX != 0 && isGrounded());

        if (Input.touchCount > 0)
        {
            dirX = CrossPlatformInputManager.GetAxisRaw("Horizontal") * moveSpeed;

            if (CrossPlatformInputManager.GetButtonDown("Jump"))
            {
                if (canPlay == true)
                {
                    jumpSound.Play();
                    Jump();
                }
            }
        }
            CheckIfCanJump();
        if (isGrounded() && dirX != 0 && canRunSound)
        {
            runSound.Play();
            canRunSound = false;
            StartCoroutine(RunAgain());
        }
        if (!isGrounded() || dirX == 0)
        {
            runSound.Stop();
            canRunSound = true;
        }
        if (health.dead)
        {
            lastWolf.SetActive(false);
        }
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX, rb.velocity.y);
    }

    private void LateUpdate()
    {
        if (dirX > 0)
            facingRight = true;
        else if (dirX < 0)
            facingRight = false;

        if (((facingRight) && (localScale.x < 0)) || ((!facingRight) && (localScale.x > 0)))
            localScale.x *= -1;

        transform.localScale = localScale;

    }

    private void Jump()
    {
        if (canJump)
        {
            canPlay = true;
            anim.SetTrigger("jump");
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            jumpsLeft--;
        }
    }
    private void CheckIfCanJump()
    {
        if (isGrounded() && rb.velocity.y < 0.01)
        {
            jumpsLeft = jumps;
        }

        if (jumpsLeft <= 0)
        {
            canJump = false;
            canPlay = false;
        }

        else
        {
            canJump = true;
            canPlay = true;
        }
    }

    private bool isGrounded()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0, Vector2.down, 0.1f, groundLayer);
        return raycastHit.collider != null;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Checkpoint" && !cpSoundPlayed)
        {
            cpSoundPlayed = true;
            StartCoroutine(CpSoundi());
        }
        if (col.gameObject.tag == "Goal")
        {
            gameObject.SetActive(false);
        }
        if (col.gameObject.tag == "Snowball")
        {
            particleSnow.Play();
        }
        if (col.gameObject.tag == "Helicopter")
        {
            wolf.SetActive(false);
        }
        if (col.gameObject.tag == "Lava")
        {
            lavaSound.Play();
            StartCoroutine(venaus());
        }
        if (col.gameObject.tag == "Cam")
        {       
            runWolf.SetActive(true);
            if (Time.time > nextBarkTime)
            {
                dogSound.Play();
                nextBarkTime = Time.time + 4f / barkRate;
            }
        }
        if (col.gameObject.tag == "Ice")
        {                   
            runWolf2.SetActive(true);
            if (Time.time > nextBarkTime)
            {
                dogSound.Play();
                nextBarkTime = Time.time + 4f / barkRate;
            }
        }
        if (col.gameObject.tag == "Grab" && canBark)
        {
            attackWolf.SetActive(true);
            if (Time.time > nextBarkTime)
            {
                shortDogSound.Play();
                nextBarkTime = Time.time + 4f / barkRate;
            }
            canBark = false;
            StartCoroutine(Poistu());
        }
        if (col.gameObject.tag == "DARig")
        {
            lastWolf.SetActive(true);
        }
        if (col.gameObject.tag == "Goblin")
        {
            lastWolf.SetActive(false);
        }
        if (col.gameObject.tag == "Blackbox")
        {
            waterSound.Play();
            canvasBlack.SetActive(true);
            StartCoroutine(AlustaTaas());            
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Lava")
        {
            lavaSound.Play();
            StartCoroutine(venaus());
        }

        if (collision.gameObject.tag == "MovingPlatform")
            transform.parent = collision.transform;
        else
            transform.parent = null;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "MovingPlatform")
        {
            transform.parent = null;
        }
    }

    IEnumerator Poistu()
    {
        yield return new WaitForSeconds(4f);
        canBark = true;
        attackWolf.SetActive(false);
    }
    IEnumerator CpSoundi()
    {
        yield return new WaitForSeconds(5);
        cpSoundPlayed = false;
    }

    IEnumerator RunAgain()
    {
        yield return new WaitForSeconds(2.5f);
        canRunSound = true;
    }

    IEnumerator AlustaTaas()
    {
        yield return new WaitForSeconds(1.4f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    IEnumerator venaus()
    {
        yield return new WaitForSeconds(0.1f);
        transform.position = respawn.currentCheckpoint.transform.position;
    }
}
