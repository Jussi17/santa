using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level9Manager : MonoBehaviour
{
    public GameObject redSanta1;
    public GameObject redSanta2;
    public GameObject redSanta3;
    public GameObject redReindeer;
    public GameObject redSanta4;
    public GameObject redSleigh;
    public GameObject redSanta5;

    void Start()
    {
            redSanta1.SetActive(true);
            redSanta2.SetActive(false);
            redSanta3.SetActive(false);
            redReindeer.SetActive(false);
            redSanta4.SetActive(false);
            redSleigh.SetActive(false);
            redSanta5.SetActive(false);     
    }

}
