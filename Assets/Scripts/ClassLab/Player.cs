using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    public void Shoot()
    {
        Debug.Log("Player is shooting");
    }

    public void OnHitWithEnemy(Enemy enemy)
    {
        Debug.Log($"Player is hit by {enemy.name}");
    }
}
