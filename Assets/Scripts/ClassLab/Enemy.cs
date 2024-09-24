using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Enemy : Character
{
    private int damageHit;
    public int DamageHit
    {
        get { return damageHit; }
        set { damageHit = value; }
    }

    public abstract void Behaviour();

    void Start()
    {
        Behaviour();
    }
}
