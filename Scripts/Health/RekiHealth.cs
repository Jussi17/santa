using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RekiHealth : MonoBehaviour
{
    [Header("Health")]
    [SerializeField] public float startingHealth;
    public float currentHealth { get; private set; }
    private Animator anim;
    private bool dead;
    public Movement2 movement;
    public Respawn respawn;
    public Hearth hearth;

    [Header("iFrames")]  //Kun pelaaja menett‰‰ healthia
    [SerializeField] private float iFramesDuration;
    [SerializeField] private float numberOffFlashes;
    private SpriteRenderer spriteRend;

    [Header("Components")]
    [SerializeField] private Behaviour[] components;

    private void Awake()
    {
        hearth = GetComponent<Hearth>();
        respawn = GetComponent<Respawn>();
        movement = GetComponent<Movement2>();
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
        spriteRend = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        dead = currentHealth == 0;
        if (dead)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            currentHealth = startingHealth;
        }
    }

    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

        if (currentHealth > 0)
        {
            anim.SetTrigger("hurt");
            StartCoroutine(Invunerability());
        }
    }
    public void AddHealth(float _value)  //Jos annetaan pelaajalle mahdollisuus ker‰t‰ syd‰mi‰?
    {
        currentHealth = Mathf.Clamp(currentHealth + _value, 0, startingHealth);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Hearth")
        {
            currentHealth++;
            startingHealth++;
        }
        if (collision.tag == "Bear")
        {
            currentHealth--;
        }
    }

    private IEnumerator Invunerability()   //Pelaaja on hetken haavoittumaton menetetty‰‰n healthia
    {
        Physics2D.IgnoreLayerCollision(8, 9, true);
        for (int i = 0; i < numberOffFlashes; i++)
        {
            spriteRend.color = new Color(1, 0, 0, 0.5f);
            yield return new WaitForSeconds(iFramesDuration / (numberOffFlashes * 2));
            spriteRend.color = Color.white;
            yield return new WaitForSeconds(iFramesDuration / (numberOffFlashes * 2));
        }
        Physics2D.IgnoreLayerCollision(8, 9, false);
    }

    private void Deactivate()
    {
        gameObject.SetActive(false);
    }

    //Respawn
    public void RespawnPoint()
    {
        AddHealth(startingHealth);
        anim.ResetTrigger("die");

        //Activate all attached component classes
        foreach (Behaviour component in components)
            component.enabled = true;
    }
}
