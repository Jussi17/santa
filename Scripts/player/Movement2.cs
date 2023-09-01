using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets;
using UnityStandardAssets.CrossPlatformInput;

public class Movement2 : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    public GameObject redSanta;
    public GameObject pinkSanta;
    public GameObject blueSanta;
    public GameObject orangeSanta;
    public GameObject greenSanta;
    public GameObject purpleSanta;
    private float moveSpeed;
    private float dirX;
    private bool facingRight = true;
    private Vector3 localScale;
    public Respawn respawn;
    public Transform groundCheck;
    private bool canPlay = false;
    
    private Health health;

    float minTimeDiff = 1f;
    float lastTimecalled;

    [SerializeField] float jumpPower = 700f;
    private bool grounded;
    private bool cpSoundPlayed = false;

    [SerializeField] LayerMask groundLayer;
    private CapsuleCollider2D boxCollider;

    private int jumps = 2;
    private bool onSpeed = false;
    public int jumpsLeft = 2;
    private bool canJump;
    float jumpTimeExtension = 0.3f;
    public float jumpCondition = 0;
    public bool jumping;

    private bool canRunSound = true;
    private TrailRenderer trailRenderer;

    [Header("Audio")]
    [SerializeField] private AudioSource jumpSound;
    [SerializeField] private AudioSource stoolSound;
    
    [SerializeField] private AudioSource runSound;
    [SerializeField] ParticleSystem particleSnow;

    public float ballDistance = 0.3f;
    public bool isBallPushing = false;
    public bool isBallTouching = false;
    RaycastHit2D ballCheckHit;
    [SerializeField] LayerMask ballLayer;
    public ParticleSystem breath;
    public ParticleSystem breathLeft;
    private bool canBreath = true;
    private bool onEdge;
    public Transform edgeCheck;

    private bool onSlopeRunning = false;
    private bool onSlopeRunningLeft = false;

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
            blueSanta.SetActive(false);
            pinkSanta.SetActive(true);
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
        boxCollider = GetComponent<CapsuleCollider2D>();
        localScale = transform.localScale;
        moveSpeed = 5f;
        trailRenderer = GetComponent<TrailRenderer>();

    }
    void Update()
    {

        anim.SetBool("running", dirX != 0 && grounded && !ballCheckHit && !onSlopeRunning && !onSlopeRunningLeft);
        anim.SetBool("runup", dirX != 0 && grounded && onSlopeRunning && !ballCheckHit);
        anim.SetBool("upleft", dirX != 0 && grounded && onSlopeRunningLeft && !ballCheckHit);
        anim.SetBool("grounded", isGrounded() && grounded);
        anim.SetBool("push", isBallPushing && isBallTouching && dirX != 0);

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

        grounded = Physics2D.OverlapCircle(groundCheck.position, 0.15f, groundLayer);
        onEdge = Physics2D.OverlapCircle(edgeCheck.position, 0.15f, groundLayer);

        if (isGrounded() && dirX != 0 && canRunSound)
        {
            runSound.Play();
            canRunSound = false;
            if (ballCheckHit)
            {
                runSound.pitch = 0.7f;
            }
            if (!ballCheckHit)
            {
                runSound.pitch = 1f;
            }
            StartCoroutine(RunAgain());
        }
        if (!isGrounded() || dirX == 0)
        {
            runSound.Stop();
            canRunSound = true;
        }

        if (health.dead)
        {
            onSpeed = false;
            moveSpeed = 5;
        }
        if (dirX == 0 && canBreath)
        {
            StartCoroutine(Breathing());
        }
        if (dirX != 0)
        {
            breath.Stop();
            canBreath = true;
        }
        if (isGrounded())
        {
            jumpCondition = jumpTimeExtension;
            jumping = false;
            if (CrossPlatformInputManager.GetButtonDown("Jump"))
            {
                jumping = true;
            }
        }
        if (jumping)
        {
            jumpCondition = jumpTimeExtension;
        }
        if (!grounded && !jumping)
        {
            if (jumpCondition > 0)
            {
                jumpCondition -= Time.deltaTime;
                if (jumpCondition < 0)
                {
                    if (jumpsLeft > 1)
                    {
                        jumpsLeft = 1;
                    }              
                }
            }
        }

        if (grounded && !onEdge && dirX == 0 && rb.velocity.y == 0)
        {
            anim.SetBool("edge", true);
        }
        if (onEdge || dirX != 0 || rb.velocity.y != 0)
        {
            anim.SetBool("edge", false);
        }
    }

    IEnumerator Breathing()
    {
        yield return new WaitForSeconds(1.5f);
        if (dirX == 0 && canBreath)
        {
            if (facingRight)
            {
                canBreath = false;
                yield return new WaitForSeconds(1);
                breath.Play();
                yield return new WaitForSeconds(2.5f);
                canBreath = true;
            }
            if (!facingRight)
            {
                canBreath = false;
                yield return new WaitForSeconds(1);
                breathLeft.Play();
                yield return new WaitForSeconds(2.5f);
                canBreath = true;
            }
        }
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX, rb.velocity.y);

        if (facingRight)
        {
            ballCheckHit = Physics2D.Raycast(transform.position, new Vector2(ballDistance, 0.2f), ballDistance, ballLayer);
            Debug.DrawRay(transform.position, new Vector2(ballDistance, 0.2f), Color.red);
        }
        else
        {
            ballCheckHit = Physics2D.Raycast(transform.position, new Vector2(-ballDistance, 0.2f), ballDistance, ballLayer);
            Debug.DrawRay(transform.position, new Vector2(-ballDistance, 0.2f), Color.red);
        }

        if (ballCheckHit && isGrounded() && dirX != 0 && rb.velocity.y < 10 && rb.velocity.y > -10)
        {
            isBallPushing = true;
        }
        if (!ballCheckHit)
        {
            isBallPushing = false;
        }
    }

    void Jump()
    {
        jumping = true;
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
        if (isGrounded() && rb.velocity.y < 0.01 && grounded)
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

    private bool isGrounded()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0, Vector2.down, 0.1f, groundLayer);
        return raycastHit.collider != null;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Goal")
        {
            gameObject.SetActive(false);
        }
        if (col.gameObject.tag == "Checkpoint" && !cpSoundPlayed)
        {
            cpSoundPlayed = true;
            StartCoroutine(CpSoundi());
        }
        if (col.gameObject.tag == "Lava")
        {
            anim.SetTrigger("die");
            moveSpeed = 5;
            onSpeed = false;
            StartCoroutine(venaus());
        }
        if (col.gameObject.tag == "Snowball")
        {
            particleSnow.Play();
        }
        if (col.gameObject.tag == "Kolme")
        {
            rb.AddForce(Vector2.right * 43500f);
            trailRenderer.emitting = true;
            stoolSound.Play();
            StartCoroutine(PoistoPyrsto());
        }
        if (col.gameObject.tag == "Bopen")
        {
            runSound.Pause();
        }
        if (col.gameObject.tag == "Seiska")
        {
            onSpeed = true;
            moveSpeed = 11.5f;
        }
        if (col.gameObject.tag == "Stool")
        {
            if (lastTimecalled + minTimeDiff < Time.time)
            {
                StartCoroutine(Ylos());
            }
            lastTimecalled = Time.time;
        }
        if (col.gameObject.tag == "Slope")
        {
            if (dirX > 0.3f || dirX < -0.3f)
            {
                onSlopeRunning = true;
            }
        }
        if (col.gameObject.tag == "Slope20")
        {
            if (dirX > 0.3f || dirX < -0.3f)
            {
                onSlopeRunningLeft = true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Slope")
        {
            onSlopeRunning = false;
        }
        if (collision.gameObject.tag == "Slope20")
        {
            onSlopeRunningLeft = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Lava")
        {
            anim.SetTrigger("die");
            onSpeed = false;
            StartCoroutine(venaus());
        }
        if (collision.gameObject.tag == "Stool")
        {
            if (lastTimecalled + minTimeDiff < Time.time)
            {
                StartCoroutine(Ylos());
            }
            lastTimecalled = Time.time;
        }

        if (collision.gameObject.tag == "MovingPlatform")
        {
            transform.parent = collision.transform;
            if (!onSpeed)
            {
                moveSpeed = 5.6f;
                jumpPower = 14f;
            }      
        }
            
    }

    IEnumerator Ylos()
    {
        yield return new WaitForSeconds(0.3f);
        stoolSound.Play();
        rb.AddForce(Vector2.up * 1200f);
        anim.SetTrigger("stool");
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

    IEnumerator PoistoPyrsto()
    {
        yield return new WaitForSeconds(1);
        trailRenderer.emitting = false;
    }

    IEnumerator venaus()
    {
        yield return new WaitForSeconds(0.17f);
        transform.position = respawn.currentCheckpoint.transform.position;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Rounded")
        {
            isBallTouching = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "MovingPlatform")
        {
            transform.parent = null;
            if (!onSpeed)
            {
                StartCoroutine(BackToNormal());
            }      
        }

        if (collision.gameObject.tag == "Ball")
        {
            anim.SetTrigger("jump");
            jumpsLeft = 1;
        }
        if (collision.gameObject.tag == "Stool")
        {
            jumpsLeft = 1;
        }
        if (collision.gameObject.tag == "Rounded")
        {
            anim.SetBool("push", false);
            isBallTouching = false;
        }
    }
    IEnumerator BackToNormal()
    {
        yield return new WaitForSeconds(0.4f);
        moveSpeed = 5;
        jumpPower = 13.3f;
    }
}
