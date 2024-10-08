using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Weapon
{
    private Rigidbody2D rb;
    private Vector2 force;

    void Start()
    {
        Damage = 40;
        Move();
    }

    public override void Move()
    {
        Debug.Log($"{name} is moving by Rigidbody : Force");
    }

    public override void OnHitWith(Character character)
    {
        Debug.Log("Hit");
    }
}
