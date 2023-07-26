using System;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] public Slider healthBar;
    
    public void SetMaxHealth(float maxHealth)
    {
        healthBar.maxValue = maxHealth;
    }
    
    public void SetHealth(float health)
    {
        healthBar.value = health;
    }
}
