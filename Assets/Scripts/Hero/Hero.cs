using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public float health = 100;
    public float damage = 10;
    
    //Token bilgileri çekilecek.
    
    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }
    
    public void Die()
    {
        Destroy(gameObject);
    }
    
    public void Attack()
    {
        //Enemy'e damage verilecek.
    }
}
