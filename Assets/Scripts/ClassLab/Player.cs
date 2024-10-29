using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character, IShootable
{
    [field: SerializeField] public GameObject BulletPrefab { get; set; }
    [field: SerializeField] public Transform BulletSpawnPoint { get; set; }

    [field: SerializeField] public float BulletSpawnTime { get; set; }
    [field: SerializeField] public float BulletTimer { get; set; }

    void Update()
    {
        Shoot();
        BulletTimer -= Time.deltaTime;
    }

    public void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (BulletTimer <= 0)
            {
                BulletTimer = BulletSpawnTime;
                Instantiate(BulletPrefab, BulletSpawnPoint.position, Quaternion.identity);
                Destroy(BulletPrefab, 3f);
            }
        }
    }

    public void OnHitWithEnemy(Enemy enemy)
    {
        Debug.Log($"Player is hit by {enemy.name}");
    }
}