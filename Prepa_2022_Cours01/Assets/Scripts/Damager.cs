using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damager : MonoBehaviour
{
    [SerializeField]
    private int damage = 1;

    private void OnTriggerEnter(Collider other)
    {
        
        Damageable damageable = other.gameObject.GetComponentInParent<Damageable>();
        
        if (damageable != null)
        {
            //Debug.Log("Damager OntriggerEnter " + name + " triggered with " + other.name);
            damageable.TakeDamage(damage);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        //Debug.Log("Damager OntriggerExit" + name + " triggered with" + other.name);

    }
}
