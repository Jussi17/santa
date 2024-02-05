using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whichPlayer : MonoBehaviour
{
    public bool onYksi = false;
    public bool onKaksi = false;
    public bool onKolme = false;
    public bool onPoro = false;
    public bool onNelja = false;
    public bool onNeljaYksi = false;
    public bool onKuusi = false;
    public bool onSeiska = false;

    public bool liikkuu = false;

    void Update()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        if (player != null)
        {
            Movement movement = player.GetComponent<Movement>();
            Movement2 movement2 = player.GetComponent<Movement2>();
            Movement3 movement3 = player.GetComponent<Movement3>();
            Movement4 movement4 = player.GetComponent<Movement4>();
            Movement41 movement41 = player.GetComponent<Movement41>();
            Movement6 movement6 = player.GetComponent<Movement6>();
            Movement7 movement7 = player.GetComponent<Movement7>();

            if (movement != null)
            {
                onYksi = true;
                if (movement.rb.velocity.y < 0.2f && movement.rb.velocity.y > -0.2f)
                {
                    liikkuu = false;
                }
                else
                {
                    liikkuu = true;
                }
            }
            if (movement2 != null)
            {
                onKaksi = true;
                if (movement2.rb.velocity.y < 0.2f && movement2.rb.velocity.y > -0.2f)
                {
                    liikkuu = false;
                }
                else
                {
                    liikkuu = true;
                }
            }
            if (movement3 != null)
            {
                onKolme = true;
                if (movement3.rb.velocity.y < 0.2f && movement3.rb.velocity.y > -0.2f)
                {
                    liikkuu = false;
                }
                else
                {
                    liikkuu = true;
                }
            }
            if (movement4 != null)
            {
                onNelja = true;
                if (movement4.rb.velocity.y < 0.2f && movement4.rb.velocity.y > -0.2f)
                {
                    liikkuu = false;
                }
                else
                {
                    liikkuu = true;
                }
            }
            if (movement41 != null)
            {
                onNeljaYksi = true;
                if (movement41.rb.velocity.y < 0.2f && movement41.rb.velocity.y > -0.2f)
                {
                    liikkuu = false;
                }
                else
                {
                    liikkuu = true;
                }
            }
            if (movement6 != null)
            {
                onKuusi = true;
                if (movement6.rb.velocity.y < 0.2f && movement6.rb.velocity.y > -0.2f)
                {
                    liikkuu = false;
                }
                else
                {
                    liikkuu = true;
                }
            }
            if (movement7 != null)
            {
                onSeiska = true;
                if (movement7.rb.velocity.y < 0.2f && movement7.rb.velocity.y > -0.2f)
                {
                    liikkuu = false;
                }
                else
                {
                    liikkuu = true;
                }
            }
        }
        else
        {
            GameObject reindeer = GameObject.FindGameObjectWithTag("Reindeer");

            ReindeerMovement reindeerMovement = reindeer.GetComponent<ReindeerMovement>();
            if (reindeerMovement != null)
            {
                onPoro = true;
                if (reindeerMovement.rb.velocity.y < 0.2f && reindeerMovement.rb.velocity.y > -0.2f)
                {
                    liikkuu = false;
                }
                else
                {
                    liikkuu = true;
                }
            }
        }
    }
}
