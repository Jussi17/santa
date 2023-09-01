using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockDead : MonoBehaviour
{
    public GameObject red;
    public GameObject pink;
    public GameObject blue;
    public GameObject orange;
    public GameObject green;
    public GameObject purple;
    private BoxCollider2D bx;
    Health health;
    private Rigidbody2D rb;
    [SerializeField] private Transform rock;
    [SerializeField] private Transform respawnPoint;
    private bool isDead = false;
    void Start()
    {
        if (PlayerPrefs.HasKey("SantaRed"))
        {
            health = red.GetComponent<Health>();
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            health = pink.GetComponent<Health>();
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            health = blue.GetComponent<Health>();
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            health = orange.GetComponent<Health>();
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            health = green.GetComponent<Health>();
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            health = purple.GetComponent<Health>();
        }
        bx = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();
        bx.enabled = false;
    }

    void Update()
    {
        if (health.dead && !isDead)
        {
            isDead = true;
            bx.enabled = true;
            transform.rotation = Quaternion.Euler(0, 0, 0);
            rock.transform.position = respawnPoint.transform.position;
            rb.velocity = new Vector3(-4.5f, 0, 0);
            StartCoroutine(BxOff());
        }
    }
    IEnumerator BxOff()
    {
        yield return new WaitForSeconds(2);
        bx.enabled = false;
        isDead = false;
    }
}
