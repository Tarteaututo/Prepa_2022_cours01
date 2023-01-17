using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField]
    private Projectile projectilePrefab;

    [SerializeField]
    private string _inputName = "Fire1";

    [SerializeField]
    private float fireRate = 1;

    private float currentFireRate = 0;

    private void Start()
    {
        currentFireRate = fireRate;
    }

    private void Update()
    {
        // we are counting seconds
        currentFireRate += Time.deltaTime;
        
        if (currentFireRate >= fireRate)
        {
            if (Input.GetButton(_inputName) == true)
            {
                Projectile projectileInstance = Instantiate(projectilePrefab, transform.position, transform.rotation);

                currentFireRate = 0;
            }
        }
    }
}
