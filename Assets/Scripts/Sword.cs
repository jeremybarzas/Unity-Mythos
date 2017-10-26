using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptables/Weapons/Sword")]
public class Sword : ScriptableObject, IDamager
{
    public int damageAmount;

    public void DoDamage(IDamageable damageable)
    {
        damageable.TakeDamage(damageAmount);
    }
    
}
