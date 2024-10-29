using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    protected string _animalName;
    protected int _damage;
    [SerializeField] protected Animal _attackingAnimal;

    private int _health;
    public int Health
    {
        get { return _health; }
        set { _health = Mathf.Clamp(value, 0, 100); }
    }

    public abstract void MakeSound();

    public abstract int GetRandomDamage();

    public void InitializeAnimal(int health, string animalName = "Animal")
    {
        Health = health;
        _animalName = animalName;
        _damage = GetRandomDamage();
        DisplayAnimalStatus();
    }

    public void DisplayAnimalStatus()
    {
        Debug.Log($"Animal Name : {_animalName} | Health : {Health} | Damage : {_damage}");
    }

    public void TakeDamage(Animal enemyAnimal)
    {
        Debug.Log($"{enemyAnimal._animalName} is Attacking!");
        Health -= enemyAnimal._damage;
        Debug.Log($"{_animalName} took {enemyAnimal._damage} damage | Remaining Health : {Health}");
        if (IsDead())
        {
            Debug.Log($"{_animalName} is Dead!");
        }
    }

    public bool IsDead()
    {
        return Health <= 0;
    }

    public virtual void Attack()
    {
        Debug.Log($"Animal is perform basic attack!");
    }
}
