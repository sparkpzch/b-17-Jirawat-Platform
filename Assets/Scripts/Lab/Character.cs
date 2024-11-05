using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    // attribute that makes field show and available to edit in Inspector
    [SerializeField] private int health;

    // property & field
    public int Health
    {
        get
        {
            return health;
        }
        set
        {
            health = value;
        }
    }

    public Animator anim;
    public Rigidbody2D rb;

    // method
    public bool IsDead()
    {
        if (health <= 0)
        {
            Destroy(this.gameObject);
            return true;
        }
        else return false;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Debug.Log("Take Damage: " + damage + " >> Health: " + Health);
    }

    public virtual void Init(int newHealth)
    {
        Health = newHealth;
        //get components for prefabs
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

}
