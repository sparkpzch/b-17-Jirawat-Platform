using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] private int damage;
    public int Damage
    {
        get { return damage; }
        set { damage = value; }
    }

    public string owner;

    public abstract void OnHitWith(Character character);

    public abstract void Move();

    public int GetShootDirection()
    {
        Debug.Log("GetShootDirection");
        return 1;
    }
}
