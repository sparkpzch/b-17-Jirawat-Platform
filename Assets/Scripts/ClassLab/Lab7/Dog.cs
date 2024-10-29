using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    void Awake()
    {
        InitializeAnimal(100, name);
    }

    void Start()
    {
        MakeSound();
        Attack();
        TakeDamage(_attackingAnimal);
    }

    public override int GetRandomDamage()
    {
        return Random.Range(1, 51) + 5;
    }

    public override void MakeSound()
    {
        Debug.Log($"{_animalName} Says Woof! Woof!");
    }

    public override void Attack()
    {
        base.Attack();
        Debug.Log($"{_animalName} is Biting!");
    }
}
