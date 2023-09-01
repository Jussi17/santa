using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;

public class Movement7 : MonoBehaviour
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
    [SerializeField] LayerMask groundLayer;
    private bool canPlay = false;
    public Renderer santaRenderer;
    public TrailRenderer cannonTrail;
    private int onkoNega = 0;
    private bool cpSoundPlayed = false;

    private BoxCollider2D boxCollider;
    public bool grounded;
    public Transform groundCheck;
    private float slopeFriction = 0.1f;
    private bool canRunSound = true;

    [Header("Dashing")]
    private TrailRenderer trailRenderer;
    public float dashDistance = 15f;
    public bool isDashing;
    public float dashCoolDown = 1f;
    private float dashRate;

    RaycastHit2D dashCheckHit;
    public float dashingDistance = 3.5f;
    public bool slowDash = false;
    [SerializeField] LayerMask dashLayer;

    public GameObject canvas;

    [Header("Jumping")]
    [SerializeField] float jumpPower = 13.3f;
    private int jumps = 2;
    public int jumpsLeft;
    private bool canJump;
    public bool jumping;
    float jumpTimeExtension = 0.3f;
    public float jumpCondition = 0;

    [Header("Sliding")]
    public BoxCollider2D slideCollider;
    public float slideSpeed = 5f;
    public bool isSliding = false;
    [SerializeField] ParticleSystem particleSlide;

    [Header("WallJump")]
    public float wallJumpTime = 0.3f;
    public float wallSlideSpeed = -3f;
    public float wallDistance = 0.3f;
    public bool isWallSliding = false;
    RaycastHit2D wallCheckHit;
    float jumpTime;
    [SerializeField] LayerMask wallLayer;
    public float wallCoolDown = 2;
    private float nextWallJumpTime = 0;

    [Header("Audio")]
    [SerializeField] private AudioSource jumpSound;
    [SerializeField] private AudioSource dashSound;
    [SerializeField] private AudioSource slideSound;
    [SerializeField] private AudioSource disSound;
    [SerializeField] private AudioSource negativeSound;
    [SerializeField] private AudioSource scarySound;
    [SerializeField] private AudioSource runSound;

    public GameObject dashButton;
    public GameObject slideButton;
    public ParticleSystem breath;
    public ParticleSystem breathLeft;
    private bool canBreath = true;
    public float cannonDistance = 0.3f;
    private bool isCannonPushing = false;
    RaycastHit2D cannonCheckHit;
    [SerializeField] LayerMask cannonLayer;
    private bool onEdge;
    public Transform edgeCheck;
    private bool isInSlideZone = false;
    private bool dashBlock = false;
    public bool slidi = false;
    public bool dashi = false;

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
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            redSanta.SetActive(false);
            pinkSanta.SetActive(true);
            blueSanta.SetActive(false);
            orangeSanta.SetActive(false);
            greenSanta.SetActive(false);
            purpleSanta.SetActive(false);
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            redSanta.SetActive(false);
            pinkSanta.SetActive(false);
            blueSanta.SetActive(true);
            orangeSanta.SetActive(false);
            greenSanta.SetActive(false);
            purpleSanta.SetActive(false);
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            redSanta.SetActive(false);
            pinkSanta.SetActive(false);
            blueSanta.SetActive(false);
            orangeSanta.SetActive(true);
            greenSanta.SetActive(false);
            purpleSanta.SetActive(false);
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            redSanta.SetActive(false);
            pinkSanta.SetActive(false);
            blueSanta.SetActive(false);
            orangeSanta.SetActive(false);
            greenSanta.SetActive(true);
            purpleSanta.SetActive(false);
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            redSanta.SetActive(false);
            pinkSanta.SetActive(false);
            blueSanta.SetActive(false);
            orangeSanta.SetActive(false);
            greenSanta.SetActive(false);
            purpleSanta.SetActive(true);
        }
    }


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        respawn = GetComponent<Respawn>();
        boxCollider = GetComponent<BoxCollider2D>();
        localScale = transform.localScale;
        trailRenderer = GetComponent<TrailRenderer>();
        moveSpeed = 5f;
        trailRenderer.emitting = false;
    }
    void Update()
    {
        anim.SetBool("running", dirX != 0 && grounded && !isCannonPushing);
        anim.SetBool("grounded", isGrounded() && grounded && !wallCheckHit && !isWallSliding);
        anim.SetBool("wallslide", wallCheckHit || isWallSliding);
        anim.SetBool("push", isCannonPushing && dirX != 0);
        //anim.SetBool("fall", !grounded && rb.velocity.y < -7 && falling && !wallCheckHit);

        CheckIfCanJump();

        if (Input.touchCount > 0)
        {
            dirX = CrossPlatformInputManager.GetAxisRaw("Horizontal") * moveSpeed;

            //if (Time.time > nextWallJumpTime)
            {
                if (CrossPlatformInputManager.GetButtonDown("Jump") || isWallSliding && CrossPlatformInputManager.GetButtonDown("Jump"))
                {
                    if (isSliding == true)
                    {
                        anim.SetBool("slide", false);
                    }
                    Jump();
                        nextWallJumpTime = Time.time + wallCoolDown;
                        if (canJump)
                        {
                            jumpSound.Play();
                        }



                }
            }
            


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

            if (!facingRight)
            {
                if (CrossPlatformInputManager.GetButtonDown("Dash") && Time.time > dashRate)
                {
                    if (!slidi)
                    {
                        if (dashBlock == false)
                        {
                            trailRenderer.emitting = true;
                        }
                        if (dashCheckHit)
                        {
                            isDashing = true;
                            dashi = true;
                            slowDash = true;
                            dashRate = Time.time + dashCoolDown;
                            dashSound.pitch = 0.7f;
                            dashSound.Play();
                            anim.SetTrigger("slowdash");
                            StartCoroutine(Dashi());
                            StartCoroutine(DashSlow(-Vector2.right));
                            StartCoroutine(StopEmitting());
                        }
                        if (dashBlock == true)
                        {
                            isDashing = true;
                            dashi = true;
                            slowDash = true;
                            dashRate = Time.time + dashCoolDown;
                            dashSound.pitch = 0.7f;
                            dashSound.Play();
                            anim.SetTrigger("slowdash");
                            StartCoroutine(Dashi());
                            StartCoroutine(DashSlow(-Vector2.right));
                            StartCoroutine(StopEmitting());
                        }
                        if (!dashCheckHit && dashBlock == false)
                        {
                            isDashing = true;
                            dashi = true;
                            slowDash = false;
                            dashRate = Time.time + dashCoolDown;
                            dashSound.pitch = 1f;
                            dashSound.Play();
                            anim.SetTrigger("dashing");
                            StartCoroutine(Dashi());
                            StartCoroutine(Dash(-Vector2.right));
                            StartCoroutine(StopEmitting());
                        }
                    }
                }
            }
            else if (facingRight)
            {
                if (CrossPlatformInputManager.GetButtonDown("Dash") && Time.time > dashRate)
                {
                    if (!slidi)
                    {
                        if (dashBlock == false)
                        {
                            trailRenderer.emitting = true;
                        }

                        if (dashCheckHit)
                        {
                            isDashing = true;
                            dashi = true;
                            slowDash = true;
                            dashRate = Time.time + dashCoolDown;
                            dashSound.pitch = 0.7f;
                            dashSound.Play();
                            anim.SetTrigger("slowdash");
                            StartCoroutine(Dashi());
                            StartCoroutine(StopEmitting());
                            StartCoroutine(DashSlow(Vector2.right));
                        }
                        if (dashBlock == true)
                        {
                            isDashing = true;
                            dashi = true;
                            slowDash = true;
                            dashRate = Time.time + dashCoolDown;
                            dashSound.pitch = 0.7f;
                            dashSound.Play();
                            anim.SetTrigger("slowdash");
                            StartCoroutine(Dashi());
                            StartCoroutine(StopEmitting());
                            StartCoroutine(DashSlow(Vector2.right));
                        }
                        if (!dashCheckHit && dashBlock == false)
                        {
                            isDashing = true;
                            dashi = true;
                            slowDash = false;
                            dashRate = Time.time + dashCoolDown;
                            dashSound.pitch = 1f;
                            dashSound.Play();
                            anim.SetTrigger("dashing");
                            StartCoroutine(Dashi());
                            StartCoroutine(StopEmitting());
                            StartCoroutine(Dash(Vector2.right));
                        }
                    }
                }
            }
        }
        if (!isSliding)
        {
            if (CrossPlatformInputManager.GetButtonDown("Slide"))
            {
                slidi = true;
                StartCoroutine(Slidi());
                slideSound.Play();
                Slide();
            }
        }
        grounded = Physics2D.OverlapCircle(groundCheck.position, 0.15f, groundLayer);
        onEdge = Physics2D.OverlapCircle(edgeCheck.position, 0.15f, groundLayer);
        if (dirX == 0 && canBreath)
        {
            StartCoroutine(Breathing());
        }
        if (dirX != 0)
        {
            breath.Stop();
            canBreath = true;
        }
        if (grounded)
        {
            jumping = false;
            jumpCondition = jumpTimeExtension;
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
    IEnumerator Slidi()
    {
        yield return new WaitForSeconds(0.9f);
        slidi = false;
        isSliding = false;
    }

    IEnumerator Dashi()
    {
        yield return new WaitForSeconds(0.6f);
        dashi = false;
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
        NormalizeSlope();

        if (facingRight)
        {
            dashCheckHit = Physics2D.Raycast(transform.position, new Vector2(dashingDistance, 0.6f), dashingDistance, dashLayer);
            Debug.DrawRay(transform.position, new Vector2(dashingDistance, 0.6f), Color.red);
            dashCheckHit = Physics2D.Raycast(transform.position, new Vector2(dashingDistance, -0.6f), dashingDistance, dashLayer);
            Debug.DrawRay(transform.position, new Vector2(dashingDistance, -0.6f), Color.red);
            wallCheckHit = Physics2D.Raycast(transform.position, new Vector2(wallDistance, 0.3f), wallDistance, wallLayer);
            Debug.DrawRay(transform.position, new Vector2(wallDistance, 0.3f), Color.blue);
            cannonCheckHit = Physics2D.Raycast(transform.position, new Vector2(cannonDistance, 0.2f), cannonDistance, cannonLayer);
            Debug.DrawRay(transform.position, new Vector2(cannonDistance, 0.2f), Color.green);
        }
        else
        {
            dashCheckHit = Physics2D.Raycast(transform.position, new Vector2(-dashingDistance, 0.6f), dashingDistance, dashLayer);
            Debug.DrawRay(transform.position, new Vector2(-dashingDistance, 0.6f), Color.red);
            dashCheckHit = Physics2D.Raycast(transform.position, new Vector2(-dashingDistance, -0.6f), dashingDistance, dashLayer);
            Debug.DrawRay(transform.position, new Vector2(-dashingDistance, -0.6f), Color.red);
            wallCheckHit = Physics2D.Raycast(transform.position, new Vector2(-wallDistance, 0.3f), wallDistance, wallLayer);
            Debug.DrawRay(transform.position, new Vector2(-wallDistance, 0.3f), Color.blue);
            cannonCheckHit = Physics2D.Raycast(transform.position, new Vector2(-cannonDistance, 0.2f), cannonDistance, cannonLayer);
            Debug.DrawRay(transform.position, new Vector2(-cannonDistance, 0.2f), Color.green);
        }

        if (wallCheckHit && !isGrounded() && dirX != 0 && rb.velocity.y < 0)
        {
            isWallSliding = true;
            canJump = true;
            jumpTime = Time.time + wallJumpTime;
        }
        else if (jumpTime < Time.time)
        {
            isWallSliding = false;
        }

        if (isWallSliding)
        {
            rb.velocity = new Vector2(rb.velocity.x, Mathf.Clamp(rb.velocity.y, wallSlideSpeed, float.MaxValue));
            jumpsLeft = jumps - 1;
            canJump = true;
        }
        if (wallCheckHit)
        {
            canJump = true;
            anim.SetBool("grounded", false);
        }
        if (cannonCheckHit && isGrounded() && dirX != 0 && rb.velocity.y <= 0)
        {
            isCannonPushing = true;
        }
        if (!cannonCheckHit)
        {
            isCannonPushing = false;
        }
    }

    private void Slide()
    {
        if (isGrounded())
        {
            particleSlide.Play();
        }

        isSliding = true;
        anim.SetBool("slide", true);
        boxCollider.enabled = false;
        slideCollider.enabled = true;

        if (dirX < 0)
        {
            rb.AddForce(Vector2.left * slideSpeed);
        }
        else if (dirX > 0)
        {
            rb.AddForce(Vector2.right * slideSpeed);
        }
        StartCoroutine(StopSlide());
    }

    private IEnumerator StopSlide()
    {
        yield return new WaitForSeconds(0.9f);

        if (!isInSlideZone)
        {
            anim.Play("idle");
            anim.SetBool("slide", false);
            boxCollider.enabled = true;
            slideCollider.enabled = false;
            isSliding = false;
        }
        grounded = true;
    }
    private IEnumerator Dash(Vector2 direction)
    {
        float dashDistance = 4f;
        float dashDuration = 0.15f;
        float elapsedTime = 0f;
        while (elapsedTime < dashDuration)
        {
            float distanceToMove = dashDistance * Time.deltaTime / dashDuration;
            transform.Translate(direction * distanceToMove);
            elapsedTime += Time.deltaTime;
            yield return null;
            StartCoroutine(OffEmit());
        }
    }
    private IEnumerator DashSlow(Vector2 direction)
    {
        float dashDistance = 1f;
        float dashDuration = 0.15f;
        float elapsedTime = 0f;
        while (elapsedTime < dashDuration)
        {
            float distanceToMove = dashDistance * Time.deltaTime / dashDuration;
            transform.Translate(direction * distanceToMove);
            elapsedTime += Time.deltaTime;
            yield return null;
            StartCoroutine(OffEmit());
        }
    }

    IEnumerator OffEmit()
    {
        yield return new WaitForSeconds(0.3f);
        trailRenderer.emitting = false;
    }
    IEnumerator StopEmitting()
    {
        yield return new WaitForSeconds(0.3f);
        trailRenderer.emitting = false;
    }

    void Jump()
    {
        jumping = true;
        if (canJump)
        {
            anim.SetTrigger("jump");
            canPlay = true;
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            jumpsLeft--;
        }
        if (wallCheckHit)
        {
            if (facingRight)
            {
                jumpsLeft = 1;
                rb.velocity = new Vector2(rb.velocity.x, jumpPower * 1.3f);
                if (localScale.x > 0)
                {
                    rb.AddForce(Vector2.left * 1200f * 1.3f);
                }

            }
            if (!facingRight)
            {
                jumpsLeft = 1;
                rb.velocity = new Vector2(rb.velocity.x, jumpPower * 1.3f);
                if (localScale.x < 0)
                {
                    rb.AddForce(Vector2.right * 1200f * 1.3f);
                }
            }
        }
        else if (isWallSliding)
        {
            if (facingRight)
            {
                jumpsLeft = 1;
                rb.velocity = new Vector2(rb.velocity.x, jumpPower * 1.3f);
                if (localScale.x > 0)
                {
                    rb.AddForce(Vector2.left * 1200f * 1.3f);
                }
            }
            if (!facingRight)
            {
                jumpsLeft = 1;
                rb.velocity = new Vector2(rb.velocity.x, jumpPower * 1.3f);
                if (localScale.x < 0)
                {
                    rb.AddForce(Vector2.right * 1200f * 1.3f);
                }
            }
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
        else if (isWallSliding)
        {
            canJump = true;
            canPlay = true;
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

    public bool isGrounded()
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
            dashButton.SetActive(false);
            slideButton.SetActive(false);
            StartCoroutine(venaus());
        }

        if (col.gameObject.tag == "Cannon")
        {
            santaRenderer.enabled = false;
            StartCoroutine(Tykki());
        }
        if (col.gameObject.tag == "Sleigh")
        {
            localScale.y = -0.3f;
            rb.gravityScale = -3;
            jumpPower = -13.3f;
            if (onkoNega < 7)
            {
                negativeSound.Play();
                onkoNega++;
            }
        }
        if (col.gameObject.tag == "Block")
        {
            scarySound.Play();
            canvas.SetActive(false);
            StartCoroutine(BackToNormal());
        }
        if (col.gameObject.tag == "Bopen")
        {
            runSound.Pause();
        }
        if (col.gameObject.tag == "MP")
        {
            isInSlideZone = true;
            anim.SetBool("slide", true);
            slideCollider.enabled = true;
            boxCollider.enabled = false;
            AnimatorStateInfo stateInfo = anim.GetCurrentAnimatorStateInfo(0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Lava")
        {
            anim.SetTrigger("die");
            dashButton.SetActive(false);
            slideButton.SetActive(false);
            StartCoroutine(venaus());
        }
        if (collision.gameObject.tag == "Puu")
        {
            if (CrossPlatformInputManager.GetButtonDown("Dash"))
            {
                if (!facingRight)
                {
                    dashSound.pitch = 0.3f;
                    rb.AddForce(Vector2.left * 1f);
                }
                if (facingRight)
                {
                    dashSound.pitch = 0.3f;
                    rb.AddForce(Vector2.right * 1f);
                }
            }

        }
        if (collision.gameObject.tag == "Boxing")
        {
            rb.AddForce(Vector2.left * 105000f);
        }

        if (collision.gameObject.tag == "Disappear")
        {
            disSound.Play();
        }

        if (collision.gameObject.tag == "MovingPlatform")
        {
            transform.parent = collision.transform;
            moveSpeed = 5.6f;
            jumpPower = 14f;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Sleigh")
        {
            localScale.y = 0.3f;
            rb.gravityScale = 1f;
            jumpPower = 8f;
            StartCoroutine(OffGreen());
        }
        if (collision.gameObject.tag == "MP")
        {
            isInSlideZone = false;
            AnimatorStateInfo stateInfo = anim.GetCurrentAnimatorStateInfo(0);
            boxCollider.enabled = true;
            slideCollider.enabled = false;
            anim.SetBool("slide", false);
        }
        if (collision.gameObject.tag == "GameController")
        {
            dashBlock = false;
        }
        if (collision.gameObject.tag == "Bird")
        {
            dashBlock = false;
        }
    }

    IEnumerator CpSoundi()
    {
        yield return new WaitForSeconds(5);
        cpSoundPlayed = false;
    }

    IEnumerator PalaaNorm()
    {
        yield return new WaitForSeconds(1.2f);
        Time.timeScale = 1;
    }

    IEnumerator RunAgain()
    {
        yield return new WaitForSeconds(2.5f);
        canRunSound = true;
    }

    IEnumerator BackToNormal()
    {
        yield return new WaitForSeconds(3.5f);
        canvas.SetActive(true);
    }

    IEnumerator OffGreen()
    {
        yield return new WaitForSeconds(0.45f);
        jumpPower = 13.3f;
        rb.gravityScale = 3;
    }


    IEnumerator venaus()
    {
        yield return new WaitForSeconds(0.16f);
        transform.position = respawn.currentCheckpoint.transform.position;
        yield return new WaitForSeconds(0.46f);
        dashButton.SetActive(true);
        slideButton.SetActive(true);
    }

    IEnumerator Dash(float direction)
    {
        isDashing = true;
        rb.velocity = new Vector2(rb.velocity.x, 0f);
        rb.AddForce(new Vector2(dashDistance * direction, 0f), ForceMode2D.Impulse);
        float gravity = rb.gravityScale;
        rb.gravityScale = 0;
        yield return new WaitForSeconds(0.2f);
        isDashing = false;
        rb.gravityScale = gravity;
        grounded = true;
    }

    IEnumerator Tykki()
    {
        yield return new WaitForSeconds(0.99f);
        santaRenderer.enabled = true;
        yield return new WaitForSeconds(0.01f);
        cannonTrail.emitting = true;
        rb.AddForce(new Vector2(85000f, 80f));
        Time.timeScale = 0.7f;
        yield return new WaitForSeconds(0.5f);
        cannonTrail.emitting = false;
        Time.timeScale = 1f;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "MovingPlatform")
        {
            transform.parent = null;
            StartCoroutine(BackToNormal3());
        }


        if (collision.gameObject.tag == "Ball")
        {
            anim.SetTrigger("jump");
            jumpsLeft = 1;
        }
        if (collision.gameObject.tag == "DARig")
        {
            StartCoroutine(PalaaNorm());
        }
    }
    IEnumerator BackToNormal3()
    {
        yield return new WaitForSeconds(0.4f);
        moveSpeed = 5;
        jumpPower = 13.3f;
    }
    void NormalizeSlope()
    {
        if (isGrounded())
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up, 1f, groundLayer);

            if (hit.collider != null && Mathf.Abs(hit.normal.x) > 0.1f)
            {
                Rigidbody2D rb = GetComponent<Rigidbody2D>();
                rb.velocity = new Vector2(rb.velocity.x - (hit.normal.x * slopeFriction), rb.velocity.y);

                Vector3 pos = transform.position;
                pos.y += -hit.normal.x * Mathf.Abs(rb.velocity.x) * Time.deltaTime * (rb.velocity.x - hit.normal.x > 0 ? 1 : -1);
                transform.position = pos;
            }
        }
    }
    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "GameController" && facingRight)
        {
            dashBlock = true;
        }
        if (col.gameObject.tag == "GameController" && !facingRight)
        {
            dashBlock = false;
        }
        if (col.gameObject.tag == "Bird" && !facingRight)
        {
            dashBlock = true;
        }
        if (col.gameObject.tag == "Bird" && facingRight)
        {
            dashBlock = false;
        }
    }

}

