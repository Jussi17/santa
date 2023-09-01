using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
	public GameObject Portal;
	public GameObject PlayerRed;
	public GameObject PlayerPink;
	public GameObject PlayerBlue;
	public GameObject PlayerOrange;
	public GameObject PlayerGreen;
	public GameObject PlayerPurple;

	public GameObject panelBlack;

	[SerializeField] ParticleSystem particleTele;
	[SerializeField] private AudioSource teleSound;

    private void Start()
    {
		panelBlack.SetActive(false);
    }

    private void Update()
    {
        if (PlayerPrefs.HasKey("SantaPink"))
        {
			PlayerRed = PlayerPink;
        }
		if (PlayerPrefs.HasKey("SantaBlue"))
		{
			PlayerRed = PlayerBlue;
		}
		if (PlayerPrefs.HasKey("SantaOrange"))
		{
			PlayerRed = PlayerOrange;
		}
		if (PlayerPrefs.HasKey("SantaGreen"))
		{
			PlayerRed = PlayerGreen;
		}
		if (PlayerPrefs.HasKey("SantaPurple"))
		{
			PlayerRed = PlayerPurple;
		}
	}

    public void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			teleSound.Play();
		    StartCoroutine(Teleporting());
		}
	}


	IEnumerator Teleporting()
	{
		yield return new WaitForSeconds(0.2f);
		panelBlack.SetActive(true);
		PlayerRed.transform.position = new Vector2(Portal.transform.position.x, Portal.transform.position.y);
		yield return new WaitForSeconds(0.87f);
		panelBlack.SetActive(false);
		particleTele.Play();
	}
}