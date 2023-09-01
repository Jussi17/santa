using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMovingPlatform : MonoBehaviour
{
    public List<Transform> points;
    public Transform platform;
    int goalPoint = 0;
    public float moveSpeed = 2;
    private bool isActive = false;
    Health health;
    public GameObject red;
    public GameObject pink;
    public GameObject blue;
    public GameObject orange;
    public GameObject green;
    public GameObject purple;
    [SerializeField] private Transform PlatForm;
    [SerializeField] private Transform respawnPoint;

    private void Start()
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
    }

    private void Update()
    {
        if (isActive)
        {
            platform.position = Vector2.MoveTowards(platform.position, points[goalPoint].position, 1 * Time.deltaTime * moveSpeed);

            if (Vector2.Distance(platform.position, points[goalPoint].position) < 0.1f)
            {
                if (goalPoint == points.Count - 1)
                    goalPoint = 0;
                else
                    goalPoint++;
            }
        }
        if (health.dead)
        {
            PlatForm.transform.position = respawnPoint.transform.position;
            goalPoint = 0;
            isActive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Reindeer"|| collision.gameObject.tag == "Player")
        {
            isActive = true;
        }
    }
}
