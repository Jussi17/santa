using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingResp : MonoBehaviour
{
    public MovingPlatform mp;
    Health health;
    public GameObject red;
    public GameObject pink;
    public GameObject blue;
    public GameObject orange;
    public GameObject green;
    public GameObject purple;

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
    }


    void Update()
    {
        if (health.dead)
        {
            mp.moveSpeed = 12f;
            StartCoroutine(SpeedCalc());
        }
    }
    IEnumerator SpeedCalc()
    {
        yield return new WaitForSeconds(1f);
        mp.moveSpeed = 4;
    }
}
