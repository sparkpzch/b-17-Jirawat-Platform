using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : Character
{
    // field & property
    [SerializeField] int damageHit;
    public int DamageHit
    {
        get
        {
            return damageHit;
        }
        set
        {
            damageHit = value;
        }
    }

    private void Start()
    {
        Behavior();
    }

    // abstract method
    public abstract void Behavior();
}
