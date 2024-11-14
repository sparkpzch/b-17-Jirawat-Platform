using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField] private float health;

    public float Health
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

    public bool IsDead()
    {
        if (health <= 0)
        {
            Destroy(this.gameObject);
            return true;
        }
        else return false;
    }

    public void TakeDamage(float damage)
    {
        Health -= damage;
        Debug.Log("Take Damage: " + damage + " >> Health: " + Health);
        if (IsDead())
        {
            Debug.Log("Dead");
        }
    }

    public virtual void Init(float newHealth)
    {
        Health = newHealth;
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

}
