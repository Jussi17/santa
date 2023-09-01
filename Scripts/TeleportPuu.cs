using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPuu : MonoBehaviour
{
	public GameObject Portal;
	public GameObject Kasa;

	public void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Rounded" || other.gameObject.tag == "Cannon")
		{
			StartCoroutine(Teleporting());
		}
	}


	IEnumerator Teleporting()
	{
		yield return new WaitForSeconds(0.2f);
		Kasa.transform.position = new Vector2(Portal.transform.position.x, Portal.transform.position.y);
	}
}