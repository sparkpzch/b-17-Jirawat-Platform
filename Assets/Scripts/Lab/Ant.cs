using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ant : Enemy
{
    // show in unity inspector
    [SerializeField] private Vector2 velocity;
    [SerializeField] private Transform[] movePoints;

    private void Start()
    {
        Init(10);
    }

    private void FixedUpdate()
    {
        Behavior();
    }

    // override abstract method
    public override void Behavior()
    {
        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);

        if (rb.position.x <= movePoints[0].position.x && velocity.x < 0)
        {
            Flip();
        }

        else if (rb.position.x >= movePoints[1].position.x && velocity.x > 0)
        {
            Flip();
        }
    }

    // method
    private void Flip()
    {
        velocity *= -1;

        Vector2 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}
