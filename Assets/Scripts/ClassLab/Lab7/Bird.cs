using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : Animal
{
    void Awake()
    {
        InitializeAnimal(100, "Angry Bird");
    }

    void Start()
    {
        MakeSound();
        Attack();
        TakeDamage(_attackingAnimal);
    }

    public override int GetRandomDamage()
    {
        return Random.Range(10, 51) * 2;
    }

    public override void MakeSound()
    {
        Debug.Log($"{_animalName} : Screams SCREEEE!");
    }

    public override void Attack()
    {
        base.Attack();
        Debug.Log($"{_animalName} is Pecking!");
    }
}