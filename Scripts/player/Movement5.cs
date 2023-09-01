using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;

public class Movement5 : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    private float moveSpeed;
    private float dirX;
    private bool facingRight = true;
    private Vector3 localScale;
    public Respawn respawn;
    public Transform groundCheck;

    [SerializeField] float jumpPower = 700f;
    private TrailRenderer trailRenderer;
    private bool grounded;

    public float dashDistance = 15f;
    bool isDashing;
    public float dashCoolDown = 1f;
    private float dashRate;

    [SerializeField] LayerMask groundLayer;
    private BoxCollider2D boxCollider;
    private bool canPlay = false;

    public int jumps = 2;
    private int jumpsLeft;
    private bool canJump;

    public BoxCollider2D slideCollider;
    public float slideSpeed = 5f;
    public bool isSliding = false;
    [SerializeField] ParticleSystem particleSlide;

    [Header("Audio")]
    [SerializeField] private AudioSource jumpSound;
    [SerializeField] private AudioSource dashSound;
    [SerializeField] private AudioSource slideSound;
    [SerializeField] private AudioSource lavaSound;
    [SerializeField] private AudioSource disSound;
    [SerializeField] private AudioSource cpSound;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        respawn = GetComponent<Respawn>();
        boxCollider = GetComponent<BoxCollider2D>();
        localScale = transform.localScale;
        trailRenderer = GetComponent<TrailRenderer>();
        moveSpeed = 5f;
    }
    void Update()
    {
        anim.SetBool("running", dirX != 0 && isGrounded());
        anim.SetBool("grounded", isGrounded() && grounded);

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
            CheckIfCanJump();

            if (!facingRight)
            {
                if (CrossPlatformInputManager.GetButtonDown("Dash") && Time.time > dashRate)
                {
                    dashRate = Time.time + dashCoolDown;
                    dashSound.Play();
                    isDashing = true;
                    rb.AddForce(Vector2.left * dashDistance);
                    anim.SetTrigger("dashing");

                    trailRenderer.emitting = true;
                    isDashing = false;
                }
            }
            else if (facingRight)
            {
                if (CrossPlatformInputManager.GetButtonDown("Dash") && Time.time > dashRate)
                {
                    dashRate = Time.time + dashCoolDown;
                    dashSound.Play();
                    isDashing = true;
                    rb.AddForce(Vector2.right * dashDistance);
                    anim.SetTrigger("dashing");

                    trailRenderer.emitting = true;
                    isDashing = false;
                }
            }
            if (CrossPlatformInputManager.GetButtonDown("Slide"))
            {
                slideSound.Play();
                Slide();
            }
        }
        grounded = Physics2D.OverlapCircle(groundCheck.position, 0.15f, groundLayer);
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX, rb.velocity.y);
    }

    private void Slide()
    {
        particleSlide.Play();
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
        StartCoroutine("stopSlide");
    }

    IEnumerator stopSlide()
    {
        yield return new WaitForSeconds(0.9f);
        anim.Play("idle");
        anim.SetBool("slide", false);
        boxCollider.enabled = true;
        slideCollider.enabled = false;
        isSliding = false;
        grounded = true;
    }

    void Jump()
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
        if (col.gameObject.tag == "Checkpoint")
        {
            cpSound.Play();
        }
        if (col.gameObject.tag == "Lava")
        {
            anim.SetTrigger("die");
            lavaSound.Play();
            StartCoroutine(venaus());
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Lava")
        {
            anim.SetTrigger("die");
            lavaSound.Play();
            StartCoroutine(venaus());
        }

        if (collision.gameObject.tag == "Ball")
        {
            canJump = true;
        }

        if (collision.gameObject.tag == "Disappear")
        {
            disSound.Play();
        }

        if (collision.gameObject.tag == "MovingPlatform")
            transform.parent = collision.transform;

        else
            transform.parent = null;

    }

    
    IEnumerator venaus()
    {
        yield return new WaitForSeconds(0.32f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
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

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "MovingPlatform")
            transform.parent = null;
    }
}

