using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballTrapFinale : MonoBehaviour
{
    [SerializeField] private float attackCooldown;
    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject[] balls;
    private float cooldownTimer;

    private void Attack()
    {
        cooldownTimer = 0;

        balls[FindBall()].transform.position = firePoint.position;
        balls[FindBall()].GetComponent<EnemyProjectileFinale>().ActivateProjectile();
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