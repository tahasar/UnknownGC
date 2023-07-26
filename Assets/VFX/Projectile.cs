using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float projectileSpeed;
    public GameObject impactEffect;

    private Rigidbody2D rigidbody;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = transform.right * projectileSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Instantiate(impactEffect, transform.position, Quaternion.identity);
            Destroy(GameObject.FindWithTag("Enemy"));
            Destroy(this.gameObject);
            Destroy(impactEffect.gameObject);
        }
    }
}
