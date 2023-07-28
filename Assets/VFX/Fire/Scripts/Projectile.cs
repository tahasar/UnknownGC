using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float projectileSpeed;
    public GameObject impactEffectPrefab; // Changed variable name for clarity

    private Rigidbody2D _rigidbody;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _rigidbody.velocity = transform.right * projectileSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Instantiate(impactEffectPrefab, transform.position, Quaternion.identity);
            //Destroy(collision.gameObject); // Destroy the enemy, not the asset
            Destroy(this.gameObject); // Destroy the projectile
        }
     
    }
    
    
}