
using UnityEngine;
[RequireComponent(typeof(BoxCollider))]
public class WeaponBehaviour : MonoBehaviour
{
    public IDamager weapon;
    public string currentWeapon;    
     
    public void SetWeapon(IDamager damager)
    {
        weapon = damager;
        currentWeapon = weapon.ToString();                
    }

    private void OnTriggerEnter(Collider other)
    {
        var damageable = other.GetComponent<IDamageable>();

        //if (other.transform.root != transform.root)//if the other is not in the same heirarchy
        //{//so we don't hit ourselves
            if (damageable != null)//if the object we have entered with has a monobehaviour that implements IDamageable
            {
                weapon.DoDamage(damageable);            
            }
        //}
        
    }

}
