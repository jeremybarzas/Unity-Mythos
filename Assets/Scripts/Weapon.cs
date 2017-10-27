using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptables/Weapons/Weapon")]
public class Weapon : ScriptableObject, IDamager
{
    public Stats _weaponStats;
  
    public void DoDamage(IDamageable damageable)
    {
        damageable.TakeDamage(_weaponStats["Damage"].Value);
    }
}
