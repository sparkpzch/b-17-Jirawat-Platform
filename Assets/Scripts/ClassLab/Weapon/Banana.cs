using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Weapon
{
    [SerializeField] private float _speed;

    void Start()
    {
        Damage = 30;
        _speed = 4f;
        Move();
    }

    public override void Move()
    {
        Debug.Log($"{name} is moving at constant speed using Transform");
    }

    public override void OnHitWith(Character character)
    {
        Debug.Log("Hit");
    }
}
