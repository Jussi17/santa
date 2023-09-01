using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallJoke : MonoBehaviour
{
    [SerializeField] private AudioSource evilLaugh;
    public GameObject ball;
    private bool hasLaughed = false;
    private BoxCollider2D bx;

    void Start()
    {
        bx = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        if (PlayerPrefs.HasKey("BallOff"))
        {
            ball.SetActive(true);
            bx.enabled = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && !PlayerPrefs.HasKey("BallOff"))
        {
            ball.SetActive(false);
            if (!hasLaughed)
            {
                evilLaugh.Play();
                hasLaughed = true;
            }
            
            StartCoroutine(PalloLappa());
        }
    }
    IEnumerator PalloLappa()
    {
        yield return new WaitForSeconds(1.7f);
        PlayerPrefs.SetString("BallOff","BallOff");
        ball.SetActive(true);
    }
}
