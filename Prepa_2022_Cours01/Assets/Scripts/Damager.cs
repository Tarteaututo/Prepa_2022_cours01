using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damager : MonoBehaviour
{
    [SerializeField]
    private int damage = 1;

    [SerializeField]
    private bool _destroyIfGiveDamage = false;

    [SerializeField]
    private bool _destroyIfCollideWithAnything = false;


    private void OnTriggerEnter(Collider other)
    {
        // Technique pour remplacer le check de tag
        MySuperUniqueComponent uniqueComp = other.gameObject.GetComponentInParent<MySuperUniqueComponent>();
        if (uniqueComp != null)
        {

        }

        bool willDestroy = false;
        Damageable damageable = other.gameObject.GetComponentInParent<Damageable>();

        if (damageable != null)
        {
            //Debug.Log("Damager OntriggerEnter " + name + " triggered with " + other.name);
            damageable.TakeDamage(damage);
            if (_destroyIfGiveDamage == true)
            {
                Destroy(gameObject);
                willDestroy = true;
            }
        }
    
        if (willDestroy == false && _destroyIfCollideWithAnything == true)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //Debug.Log("Damager OntriggerExit" + name + " triggered with" + other.name);

    }
}
