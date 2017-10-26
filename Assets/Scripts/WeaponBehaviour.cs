using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBehaviour : MonoBehaviour
{
    public IDamager weapon;

    public void SetWeapon(IDamager damager)
    {
        weapon = damager;
    }
    private void OnTriggerEnter(Collider other)
    {
        weapon.DoDamage(other.GetComponent<IDamageable>());
    }

}
