using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets;
using UnityStandardAssets.CrossPlatformInput;

public class Movement3 : MonoBehaviour
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
    private bool canRunSound = true;
    private bool cpSoundPlayed = false;

    [SerializeField] float jumpPower = 500f;
    private TrailRenderer trailRenderer;
    private bool grounded;
    public float dashDistance = 15f;
    public bool isDashing;
    public float dashCoolDown = 1f;
    private float dashRate;

    RaycastHit2D dashCheckHit;
    public float dashingDistance = 3.5f;
    public bool slowDash = false;
    [SerializeField] LayerMask dashLayer;

    [SerializeField] LayerMask groundLayer;
    private CapsuleCollider2D boxCollider;

    private int jumps = 2;
    public int jumpsLeft;
    private bool canJump;
    private bool jumping;
    float jumpTimeExtension = 0.3f;
    public float jumpCondition = 0;

    [Header("Audio")]
    [SerializeField] private AudioSource jumpSound;
    [SerializeField] private AudioSource dashSound;
    [SerializeField] private AudioSource blackBoxSound;
    [SerializeField] private AudioSource runSound;

    public float ballDistance = 0.3f;
    public bool isBallPushing = false;
    public bool isBallTouching = false;
    RaycastHit2D ballCheckHit;
    [SerializeField] LayerMask ballLayer;

    public GameObject dashButton;
    private bool onEdge;
    public Transform edgeCheck;

    private bool onSlopeRunning = false;
    private bool onSlopeRunningLeft = false;
    FacingLeft fl;
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
            fl = redSanta.GetComponent<FacingLeft>();
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            redSanta.SetActive(false);
            pinkSanta.SetActive(true);
            blueSanta.SetActive(false);
            orangeSanta.SetActive(false);
            greenSanta.SetActive(false);
            purpleSanta.SetActive(false);
            fl = pinkSanta.GetComponent<FacingLeft>();
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            blueSanta.SetActive(true);
            redSanta.SetActive(false);
            pinkSanta.SetActive(false);
            orangeSanta.SetActive(false);
            greenSanta.SetActive(false);
            purpleSanta.SetActive(false);
            fl = blueSanta.GetComponent<FacingLeft>();
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            blueSanta.SetActive(false);
            redSanta.SetActive(false);
            pinkSanta.SetActive(false);
            orangeSanta.SetActive(true);
            greenSanta.SetActive(false);
            purpleSanta.SetActive(false);
            fl = orangeSanta.GetComponent<FacingLeft>();
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            blueSanta.SetActive(false);
            redSanta.SetActive(false);
            pinkSanta.SetActive(false);
            orangeSanta.SetActive(false);
            greenSanta.SetActive(true);
            purpleSanta.SetActive(false);
            fl = greenSanta.GetComponent<FacingLeft>();
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            blueSanta.SetActive(false);
            redSanta.SetActive(false);
            pinkSanta.SetActive(false);
            orangeSanta.SetActive(false);
            greenSanta.SetActive(false);
            purpleSanta.SetActive(true);
            fl = purpleSanta.GetComponent<FacingLeft>();
        }

    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        respawn = GetComponent<Respawn>();
        boxCollider = GetComponent<CapsuleCollider2D>();
        localScale = transform.localScale;
        trailRenderer = GetComponent<TrailRenderer>();
        moveSpeed = 5f;
        if (fl.isOn)
        {
            dirX = -0.0000001f;
        }
    }
    void Update()
    {
        anim.SetBool("running", dirX > 0.01f && grounded && !ballCheckHit && !onSlopeRunning && !onSlopeRunningLeft || dirX < -0.01f && grounded && !ballCheckHit && !onSlopeRunning && !onSlopeRunningLeft);
        anim.SetBool("runup", dirX != 0 && grounded && onSlopeRunning && !ballCheckHit);
        anim.SetBool("upleft", dirX != 0 && grounded && onSlopeRunningLeft && !ballCheckHit);
        anim.SetBool("grounded", isGrounded() && grounded);
        anim.SetBool("push", isBallPushing && isBallTouching && dirX != 0);

        CheckIfCanJump();

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
            

            if (!facingRight)
            {
                if (CrossPlatformInputManager.GetButtonDown("Dash") && Time.time > dashRate)
                {
                    trailRenderer.emitting = true;
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
                    if (!dashCheckHit)
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
            else if (facingRight)
            {
                if (CrossPlatformInputManager.GetButtonDown("Dash") && Time.time > dashRate)
                {
                    trailRenderer.emitting = true;
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
                    if (!dashCheckHit)
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

    IEnumerator Dashi()
    {
        yield return new WaitForSeconds(0.6f);
        dashi = false;
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
    private void FixedUpdate()
    {    
        rb.velocity = new Vector2(dirX, rb.velocity.y);

        if (facingRight)
        {
            dashCheckHit = Physics2D.Raycast(transform.position, new Vector2(dashingDistance, 0.6f), dashingDistance, dashLayer);
            Debug.DrawRay(transform.position, new Vector2(dashingDistance, 0.6f), Color.red);
            dashCheckHit = Physics2D.Raycast(transform.position, new Vector2(dashingDistance, -0.8f), dashingDistance, dashLayer);
            Debug.DrawRay(transform.position, new Vector2(dashingDistance, -0.8f), Color.red);
            ballCheckHit = Physics2D.Raycast(transform.position, new Vector2(ballDistance, 0.2f), ballDistance, ballLayer);
            Debug.DrawRay(transform.position, new Vector2(ballDistance, 0.2f), Color.red);
        }
        else
        {
            dashCheckHit = Physics2D.Raycast(transform.position, new Vector2(-dashingDistance, 0.6f), dashingDistance, dashLayer);
            Debug.DrawRay(transform.position, new Vector2(-dashingDistance, 0.6f), Color.red);
            dashCheckHit = Physics2D.Raycast(transform.position, new Vector2(-dashingDistance, -0.6f), dashingDistance, dashLayer);
            Debug.DrawRay(transform.position, new Vector2(-dashingDistance, -0.6f), Color.red);
            ballCheckHit = Physics2D.Raycast(transform.position, new Vector2(-ballDistance, 0.2f), ballDistance, ballLayer);
            Debug.DrawRay(transform.position, new Vector2(-ballDistance, 0.2f), Color.red);
        }

        if (ballCheckHit && isGrounded() && dirX != 0 && rb.velocity.y <= 0)
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
            dashButton.SetActive(false);
            StartCoroutine(venaus());
        }

        if (col.gameObject.tag == "Blackbox" )
        {
            rb.AddForce(Vector2.right * 25000f);   
            blackBoxSound.Play();
        }
        if (col.gameObject.tag == "Bopen")
        {
            runSound.Pause();
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Lava")
        {
            anim.SetTrigger("die");
            dashButton.SetActive(false);
            StartCoroutine(venaus());
        }
        if (collision.gameObject.tag == "Blackbox")
        {
            rb.AddForce(Vector2.right * 25000f);
            blackBoxSound.Play();
        }

        if (collision.gameObject.tag == "MovingPlatform")
        {
            transform.parent = collision.transform;
            moveSpeed = 5.6f;
            jumpPower = 14f;
        }
            

    }

    IEnumerator venaus()
    {
        yield return new WaitForSeconds(0.16f);
        transform.position = respawn.currentCheckpoint.transform.position;
        yield return new WaitForSeconds(0.46f);
        dashButton.SetActive(true);
    }
    IEnumerator CpSoundi()
    {
        yield return new WaitForSeconds(5);
        cpSoundPlayed = false;
    }

    IEnumerator StopEmitting()
    {
        yield return new WaitForSeconds(0.3f);
        trailRenderer.emitting = false;
    }

    IEnumerator RunAgain()
    {
        yield return new WaitForSeconds(2.5f);
        canRunSound = true;
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
            StartCoroutine(BackToNormal());
        }

        if (collision.gameObject.tag == "Ball")
        {
            anim.SetTrigger("jump");
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
}
