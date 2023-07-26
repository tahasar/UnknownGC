using UnityEngine;

namespace Enemy
{
    public class Enemy : MonoBehaviour
    {
        public float health = 100;
        public float damage = 10;

        public void Awake()
        {
            //ScriptableObject'ten statler çekilecek.
            //Level bilgisi çekilecek.
        }

        private void Start()
        {
            //Level bilgisi ile statler güncellenecek.
        }

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
            //Player'a damage verilecek.
        }
    }
}
