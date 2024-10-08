using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Crocodile : Enemy
{
    [SerializeField] private float attackRange = 5f;
    public Player player;

    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform BulletSpawnPoint;

    [SerializeField] private float bulletSpawnTime;
    [SerializeField] private float bulletTimer;

    void Update()
    {
        bulletTimer -= Time.deltaTime;

        Behaviour();

        if (bulletTimer < 0f)
        {
            bulletTimer = bulletSpawnTime;
        }
    }

    public override void Behaviour()
    {
        Vector2 direction = player.transform.position - transform.position;
        float distance = direction.magnitude;

        if (distance < attackRange)
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        if (bulletTimer <= 0)
        {
            Instantiate(bulletPrefab, BulletSpawnPoint.position, Quaternion.identity);
        }
    }
}
