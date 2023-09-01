using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundRolling : MonoBehaviour
{
    [SerializeField] private AudioSource rollSound;
    public GameObject Ball;
    private Rigidbody2D rb;
    private bool touchGround;
    RaycastHit2D ballCheckHit;
    private float groundDistance = 3.5f;
    private float yDistance = -2.5f;
    [SerializeField] LayerMask groundLayer;
    Life life;
    public GameObject lifeCanvas;
    public GameObject pauseCanvas;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        life = lifeCanvas.GetComponent<Life>();
    }

    void Update()
    {
        if (rb.velocity.x < 0.5f && rb.velocity.x > -0.5f)
        {
            rollSound.enabled = false;
        }
        else if (rb.velocity.x > 1 && rb.velocity.x < 2 && touchGround || rb.velocity.x < -1 && rb.velocity.x > -2 && touchGround)
        {
            rollSound.enabled = true;
            rollSound.volume = 0.09f;
            if (!rollSound.isPlaying)
            {
                rollSound.Play();
            }        
        }
        else if (rb.velocity.x >= 2 && touchGround || rb.velocity.x <= -2 && touchGround)
        {
            rollSound.enabled = true;
            rollSound.volume = 0.18f;
            if (!rollSound.isPlaying)
            {
                rollSound.Play();
            }
        }
        if (!touchGround)
        {
            rollSound.enabled = false;
        }
        if (ballCheckHit)
        {
            touchGround = true;
        }
        if (!ballCheckHit)
        {
            touchGround = false;
        }
        if (life.lives == 0)
        {
            Ball.SetActive(false);
        }
        if (pauseCanvas.activeInHierarchy)
        {
            rollSound.enabled = false;
        }
        if (!pauseCanvas.activeInHierarchy && touchGround)
        {
            rollSound.enabled = true;
        }
    }
    private void FixedUpdate()
    {
        ballCheckHit = Physics2D.Raycast(transform.position, new Vector2(groundDistance, yDistance), groundDistance, groundLayer);
        Debug.DrawRay(transform.position, new Vector2(groundDistance, yDistance), Color.red);
    }
}
