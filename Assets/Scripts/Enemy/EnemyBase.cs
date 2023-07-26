using UnityEngine;

namespace Enemy
{
    [CreateAssetMenu(fileName = "Enemy", menuName = "Enemy/EnemyBase")]
    public class EnemyBase : ScriptableObject
    {
        public GameObject enemyPrefab;
        public float health = 100;
        public float damage = 10;
        public float dropRate = 1;
    }
}