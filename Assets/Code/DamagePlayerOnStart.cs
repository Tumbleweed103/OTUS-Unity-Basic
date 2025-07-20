using UnityEngine;

namespace Code
{
    public class DamagePlayerOnStart : MonoBehaviour
    {
        public float baseDamage;
        public int multiplier;
        
        private void Start()
        {
            CalculateDamage(baseDamage, multiplier);
        }

        private void CalculateDamage(float baseDamage , int multiplier)
        {
            float damage = baseDamage * multiplier;
            Debug.LogError($"Total damage: {damage} (base damage: {baseDamage}; multiplier: {multiplier})");
        }
    }
}