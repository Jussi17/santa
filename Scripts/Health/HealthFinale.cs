using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthFinale : MonoBehaviour
{
    [Header("Health")]
    [SerializeField] public float startingHealth;
    public float currentHealth;
    private Animator anim;
    public bool dead = false;
    public bool neverDie = true;
    private bool canTakeDamage = true;
    public Movement7 movement;
    public Respawn respawn;
    public Hearth hearth;
    private SpriteRenderer spriteRend;

    [Header("Components")]
    [SerializeField] private Behaviour[] components;
    [SerializeField] private AudioSource hurtSound;
    [SerializeField] private AudioSource deadSound;
    [SerializeField] private AudioSource hearthSound;

    [SerializeField] private GameObject leftButton;
    [SerializeField] private GameObject rightButton;
    [SerializeField] private GameObject jumpButton;

    public DeadCounter deadCounter;
    public GameObject red;
    public GameObject pink;
    public GameObject blue;
    public GameObject orange;
    public GameObject green;
    public GameObject purple;
    public GameObject lifeCanvas;
    LifeFinale life;

    private bool canRise = true;
    private bool isTouchingLava = false;

    private void Awake()
    {
        hearth = GetComponent<Hearth>();
        respawn = GetComponent<Respawn>();
        movement = GetComponent<Movement7>();
        anim = GetComponent<Animator>();
        spriteRend = GetComponent<SpriteRenderer>();
        life = lifeCanvas.GetComponent<LifeFinale>();
    }

    private void Start()
    {
        if (PlayerPrefs.GetString("Difficulty") == "Easy")
        {
            currentHealth = 4;
            startingHealth = 4;
        }
        if (PlayerPrefs.GetString("Difficulty") == "Normal")
        {
            currentHealth = 3;
            startingHealth = 3;
        }
        else if (PlayerPrefs.GetString("Difficulty") == "Hard")
        {
            currentHealth = 1.5f;
            startingHealth = 1.5f;
        }
        else if (PlayerPrefs.GetString("Difficulty") == "Brutal")
        {
            currentHealth = 0.5f;
            startingHealth = 0.5f;
        }
        if (PlayerPrefs.HasKey("SantaRed"))
        {
            deadCounter = red.GetComponent<DeadCounter>();
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            deadCounter = pink.GetComponent<DeadCounter>();
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            deadCounter = blue.GetComponent<DeadCounter>();
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            deadCounter = orange.GetComponent<DeadCounter>();
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            deadCounter = green.GetComponent<DeadCounter>();
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            deadCounter = purple.GetComponent<DeadCounter>();
        }
    }

    private void Update()
    {
        dead = currentHealth <= 0;
        if (dead)
        {
            if (canRise == true)
            {
                deadCounter.deaths++;
            }
            canRise = false;
            leftButton.SetActive(false);
            rightButton.SetActive(false);
            jumpButton.SetActive(false);
            neverDie = false;
            if (!isTouchingLava)
            {
                anim.SetTrigger("die");
            }

            if (life.lives != 1 || life.lives != 0)
            {
                deadSound.Play();
            }
            if (life.lives == 1)
            {
                Destroy(deadSound);
            }
            transform.position = respawn.currentCheckpoint.transform.position;
            if (PlayerPrefs.GetString("Difficulty") == "Easy")
            {
                currentHealth = 4;
            }
            if (PlayerPrefs.GetString("Difficulty") == "Normal")
            {
                currentHealth = 3;
            }
            else if (PlayerPrefs.GetString("Difficulty") == "Hard")
            {
                currentHealth = 1.5f;
            }
            else if (PlayerPrefs.GetString("Difficulty") == "Brutal")
            {
                currentHealth = 0.5f;
                Destroy(deadSound);
            }
            StartCoroutine(Heltti());
        }
    }

    public void TakeDamage(float _damage)
    {
        if (canTakeDamage)
        {
            currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

            if (currentHealth > 0)
            {
                hurtSound.Play();
                canTakeDamage = false;
                StartCoroutine(Invunerability());
            }
        }
    }


    public void AddHealth(float _value)
    {
        if (PlayerPrefs.GetString("Difficulty") == "Easy")
        {
            currentHealth = Mathf.Clamp(currentHealth + _value, 0, startingHealth);
        }
        if (PlayerPrefs.GetString("Difficulty") == "Normal")
        {
            currentHealth = Mathf.Clamp(currentHealth + _value, 0, startingHealth);
        }
        else if (PlayerPrefs.GetString("Difficulty") == "Hard")
        {
            currentHealth = Mathf.Clamp(currentHealth + _value / 2, 0, startingHealth);
        }
        else if (PlayerPrefs.GetString("Difficulty") == "Brutal")
        {
            currentHealth = Mathf.Clamp(currentHealth + _value, 0, startingHealth);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Hearth")
        {
            hearthSound.Play();
            if (PlayerPrefs.GetString("Difficulty") == "Easy")
            {
                currentHealth = currentHealth + 1;
            }
            if (PlayerPrefs.GetString("Difficulty") == "Normal")
            {
                currentHealth = currentHealth + 1;
            }
            else if (PlayerPrefs.GetString("Difficulty") == "Hard")
            {
                currentHealth = currentHealth + 0.5f;
            }
            else if (PlayerPrefs.GetString("Difficulty") == "Brutal")
            {
                currentHealth = currentHealth + 0.25f;
            }
        }
        if (collision.gameObject.tag == "Lava")
        {
            isTouchingLava = true;
            currentHealth = 0;
            neverDie = false;
            StartCoroutine(Heltti());
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Lava")
        {
            isTouchingLava = true;
            currentHealth = 0;
            neverDie = false;
            StartCoroutine(Heltti());
        }
    }

    IEnumerator Heltti()
    {
        canTakeDamage = false;
        canRise = true;
        yield return new WaitForSeconds(0.62f);
        isTouchingLava = false;
        leftButton.SetActive(true);
        rightButton.SetActive(true);
        jumpButton.SetActive(true);
        anim.ResetTrigger("die");
        if (PlayerPrefs.GetString("Difficulty") == "Easy")
        {
            currentHealth = 4;
        }
        if (PlayerPrefs.GetString("Difficulty") == "Normal")
        {
            currentHealth = 3;
        }
        else if (PlayerPrefs.GetString("Difficulty") == "Hard")
        {
            currentHealth = 1.5f;
        }
        else if (PlayerPrefs.GetString("Difficulty") == "Brutal")
        {
            currentHealth = 0.5f;
        }
        yield return new WaitForSeconds(0.5f);
        canTakeDamage = true;
    }

    IEnumerator Invunerability()
    {
        spriteRend.color = new Color(1, 0, 0, 1.0f);
        yield return new WaitForSeconds(0.75f);
        spriteRend.color = Color.white;
        canTakeDamage = true;
    }

    private void Deactivate()
    {
        gameObject.SetActive(false);
    }

    public void RespawnPoint()
    {
        AddHealth(startingHealth);
        anim.ResetTrigger("die");
        anim.Play("Idle");

        //Activate all attached component classes
        foreach (Behaviour component in components)
            component.enabled = true;
    }
}
