using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigButtons90 : MonoBehaviour
{
    public Transform leftButton;
    public Transform rightButton;

    [SerializeField] private Transform respawnNormalLeft;
    [SerializeField] private Transform respawnBigLeft;
    [SerializeField] private Transform respawnNormalRight;
    [SerializeField] private Transform respawnBigRight;

    void Update()
    {
        if (PlayerPrefs.HasKey("BigButtons"))
        {
            leftButton.transform.position = new Vector2(respawnBigLeft.transform.position.x, respawnBigLeft.transform.position.y);
            rightButton.transform.position = new Vector2(respawnBigRight.transform.position.x, respawnBigRight.transform.position.y);
            leftButton.localScale = new Vector3(6.5f, 6.5f, 1.0f);
            rightButton.localScale = new Vector3(6.5f, 6.5f, 1.0f);

        }
        if (!PlayerPrefs.HasKey("BigButtons"))
        {
            leftButton.transform.position = new Vector2(respawnNormalLeft.transform.position.x, respawnNormalLeft.transform.position.y);
            rightButton.transform.position = new Vector2(respawnNormalRight.transform.position.x, respawnNormalRight.transform.position.y);
            leftButton.localScale = new Vector3(4.5f, 4.5f, 1.0f);
            rightButton.localScale = new Vector3(4.5f, 4.5f, 1.0f);
        }
    }
}
