using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballTrap90 : MonoBehaviour
{
    [SerializeField] private float attackCooldown;
    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject[] balls;
    private float cooldownTimer;
    public Animator anim;
    private void Attack()
    {
        cooldownTimer = 0;

        balls[FindBall()].transform.position = firePoint.position;
        balls[FindBall()].GetComponent<EnemyProjectile90>().ActivateProjectile();
        anim.SetTrigger("throw");
    }

    private int FindBall()
    {
        for (int i = 0; i < balls.Length; i++)
        {
            if (!balls[1].activeInHierarchy)
                return i;
        }
        return 0;
    }

    private void Update()
    {
        cooldownTimer += Time.deltaTime;

        if (cooldownTimer >= attackCooldown)
            Attack();

    }
}
