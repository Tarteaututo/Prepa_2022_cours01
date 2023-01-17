using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damageable : MonoBehaviour
{
    [SerializeField]
    private int health = 2;

    public void TakeDamage(int damage)
    {
        //health -= damage;
        health = health - damage;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
