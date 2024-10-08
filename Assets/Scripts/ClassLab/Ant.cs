using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ant : Enemy
{
    [SerializeField] private Vector2 _velocity;
    [SerializeField] private Transform[] _movePoints;


    private void Start()
    {
        // Init(10);
        // Debug.Log("Ant health: " + health);
    }

    private void FixedUpdate()
    {
        Behaviour();
    }

    public override void Behaviour()
    {
        rb.MovePosition(rb.position + _velocity * Time.fixedDeltaTime);

        if (rb.position.x < _movePoints[0].position.x && _velocity.x < 0)
        {
            Flip();
        }
        else if (rb.position.x > _movePoints[1].position.x && _velocity.x > 0)
        {
            Flip();
        }
    }

    void Flip()
    {
        _velocity.x *= -1;
    }

}
