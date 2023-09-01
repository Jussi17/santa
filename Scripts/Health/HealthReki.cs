using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthReki : MonoBehaviour
{
    [Header("Health")]
    [SerializeField] public float startingHealth;
    public float currentHealth;
    public bool dead = false;
    public bool neverDie = true;
    private bool canTakeDamage = true;
    public Movement2 movement;
    public RespawnReki respawn;
    public Hearth hearth;

    [Header("iFrames")]  //Kun pelaaja menett‰‰ healthia
    [SerializeField] private float iFramesDuration;
    [SerializeField] private float numberOffFlashes;
    private SpriteRenderer spriteRend;

    [Header("Components")]
    [SerializeField] private Behaviour[] components;
    [SerializeField] private AudioSource hurtSound;
    [SerializeField] private AudioSource deadSound;
    [SerializeField] private AudioSource hearthSound;

    public DeadCounter deadCounter;
    public GameObject red;
    public GameObject pink;
    public GameObject blue;
    public GameObject orange;
    public GameObject green;
    public GameObject purple;
    public GameObject lifeCanvas;
    LifeReki life;

    private void Awake()
    {
        hearth = GetComponent<Hearth>();
        respawn = GetComponent<RespawnReki>();
        movement = GetComponent<Movement2>();
        spriteRend = GetComponent<SpriteRenderer>();
        life = lifeCanvas.GetComponent<LifeReki>();
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
            deadCounter.deaths++;
            neverDie = false;
            transform.position = respawn.currentCheckpoint.transform.position;
            if (life.lives != 1 || life.lives != 0)
            {
                deadSound.Play();
            }
            if (life.lives == 1)
            {
                Destroy(deadSound);
            }
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
                deadSound.Play();
            }
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
                StartCoroutine(Invunerability());
            }
        }
    }
    public void AddHealth(float _value)  //Jos annetaan pelaajalle mahdollisuus ker‰t‰ syd‰mi‰?
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
            currentHealth = Mathf.Clamp(currentHealth + _value / 4, 0, startingHealth);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Hearth")
        {
            hearthSound.Play();
            currentHealth++;
            startingHealth++;
        }
        if (collision.gameObject.tag == "Lava")
        {
            neverDie = false;
            currentHealth = 0;
            StartCoroutine(Heltti());
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Lava")
        {
            neverDie = false;
            currentHealth = 0;
            StartCoroutine(Heltti());
        }
    }

    IEnumerator Heltti()
    {
        yield return new WaitForSeconds(0.62f);
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
    }

    IEnumerator Invunerability()   //Pelaaja on hetken haavoittumaton menetetty‰‰n healthia
    {
        spriteRend.color = new Color(1, 0, 0, 1.0f);
        yield return new WaitForSeconds(0.75f);
        spriteRend.color = Color.white;
        canTakeDamage = true;
        //Physics2D.IgnoreLayerCollision(3, 9, true);
        //for (int i = 0; i < numberOffFlashes; i++)
        //{
        //    spriteRend.color = new Color(1, 0, 0, 1.0f);
        //    yield return new WaitForSeconds(iFramesDuration / (numberOffFlashes * 2));
        //    spriteRend.color = Color.white;
        //    yield return new WaitForSeconds(iFramesDuration / (numberOffFlashes * 2));
        //}
        //Physics2D.IgnoreLayerCollision(3, 9, false);
    }

    private void Deactivate()
    {
        gameObject.SetActive(false);
    }

    public void RespawnPoint()
    {
        AddHealth(startingHealth);

        //Activate all attached component classes
        foreach (Behaviour component in components)
            component.enabled = true;
    }
}
