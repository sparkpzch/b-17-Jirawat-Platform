using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public Character character;
    public GameObject healthBar;

    void Update()
    {
        float health = character.Health;
        if (health <= 0)
        {
            healthBar.SetActive(false);
        }
        else
        {
            healthBar.SetActive(true);
            Vector3 scale = healthBar.transform.localScale;
            scale.x = health * 0.1f;
            healthBar.transform.localScale = scale;

            Color healthColor;
            if (health >= 1.0f)
            {
                healthColor = Color.green;
            }
            else if (health >= 0.5f)
            {
                healthColor = Color.yellow;
            }
            else
            {
                healthColor = Color.red;
            }
            healthBar.GetComponent<Renderer>().material.color = healthColor;
        }
    }
}
