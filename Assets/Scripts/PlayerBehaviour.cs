
using UnityEngine;

public class PlayerBehaviour : EntityBehaviour, IDamageable
{
    public Weapon _weapon;    
    private WeaponBehaviour _weaponBehaviour;
    public Animator _weaponAnimator;    
    
    private void Start()
    {
        _weaponBehaviour = GetComponentInChildren<WeaponBehaviour>(); //we only have one weapon
        _weaponBehaviour.SetWeapon(_weapon); //set the current weapon
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            _weaponAnimator.SetTrigger("swing");
    }

    public void TakeDamage(int amount)
    {
        GetComponent<AudioSource>().Play();
        config["Health"].Value -= amount;       
    }
}
