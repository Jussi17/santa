using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowSnowman : MonoBehaviour
{
    public Transform snowman;
    public GameObject snowMan;
    JumpingSnowman jumpingSnowman;
    private SpriteRenderer sprite;

    private void Start()
    {
        jumpingSnowman = snowMan.GetComponent<JumpingSnowman>();
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        transform.position = new Vector2(snowman.position.x, transform.position.y);
        if (jumpingSnowman.isInAir == true)
        {
            sprite.enabled = true;
        }
        if (jumpingSnowman.isInAir == false)
        {
            sprite.enabled = false;
        }
    }
}
