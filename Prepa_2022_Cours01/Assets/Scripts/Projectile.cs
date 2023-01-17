using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    /// modifier sa position dans un update
    /// movespeed
    /// 

    [SerializeField]
    private float moveSpeed = 1;
    
    [SerializeField]
    private float lifeTime = 6;

    private void Start()
    {
        Destroy(gameObject, lifeTime);
    }
    private void Update()
    {
        transform.position = transform.position + transform.forward * moveSpeed * Time.deltaTime;
    }

}
