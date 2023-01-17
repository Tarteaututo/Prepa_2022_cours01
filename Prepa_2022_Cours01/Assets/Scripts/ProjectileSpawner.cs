using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    [SerializeField]
    private Projectile _projectilePrefab;

    private void Start()
    {
        InvokeRepeating("CreateProjectile", 0f, 2);
    }

    private void CreateProjectile()
    {
        Projectile projectileInstance = Instantiate(_projectilePrefab, transform.position, transform.rotation);
    }
}
