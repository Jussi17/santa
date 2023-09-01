using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gob81 : MonoBehaviour
{
    public GameObject player;
    HealthFinale health;
    EightZone eightZone;
    public GameObject checkPoint;
    private Animator anim;
    public GameObject redSanta;
    public GameObject pinkSanta;
    public GameObject blueSanta;
    public GameObject orangeSanta;
    public GameObject greenSanta;
    public GameObject purpleSanta;
    public GameObject goblin;
    EnemyPatrol enPat;
    [SerializeField] private Transform goblini;
    [SerializeField] private Transform respawnPoint1;
    [SerializeField] private Transform respawnPoint2;
    void Start()
    {
        eightZone = checkPoint.GetComponent<EightZone>();
        enPat = goblin.GetComponent<EnemyPatrol>();
        anim = goblin.GetComponent<Animator>();
        if (PlayerPrefs.HasKey("SantaRed"))
        {
            player = redSanta;
        }
        if (PlayerPrefs.HasKey("SantaPink"))
        {
            player = pinkSanta;
        }
        if (PlayerPrefs.HasKey("SantaBlue"))
        {
            player = blueSanta;
        }
        if (PlayerPrefs.HasKey("SantaOrange"))
        {
            player = orangeSanta;
        }
        if (PlayerPrefs.HasKey("SantaGreen"))
        {
            player = greenSanta;
        }
        if (PlayerPrefs.HasKey("SantaPurple"))
        {
            player = purpleSanta;
        }
        health = player.GetComponent<HealthFinale>();
    }

    void Update()
    {
        if (goblin.gameObject.transform.position.x > player.gameObject.transform.position.x)
        {
            enPat.speed = 0;
            anim.SetBool("moving", false);
        }
        if (goblin.gameObject.transform.position.x < player.gameObject.transform.position.x)
        {
            enPat.speed = 5.67f;
            anim.SetBool("moving", true);
        }
        if (health.dead && eightZone.isZone1)
        {
            goblini.transform.position = respawnPoint1.transform.position;
        }
        if (health.dead && eightZone.isZone2)
        {
            goblini.transform.position = respawnPoint2.transform.position;
        }
    }
}
