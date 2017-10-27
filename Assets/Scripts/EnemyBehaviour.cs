using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : EntityBehaviour, IDamageable
{
    public readonly int SWING = Animator.StringToHash("swing");
    public Weapon _weapon;
    private WeaponBehaviour _weaponBehaviour;
    public Animator _weaponAnimator;
    public float swingCooldown = 5.0f;
    public float swingTimer;    

    private void Start()
    {
        swingTimer = swingCooldown;
        _weaponBehaviour = GetComponentInChildren<WeaponBehaviour>(); //we only have one weapon
        _weaponBehaviour.SetWeapon(_weapon); //set the current weapon
    }

    public void TakeDamage(int amount)
    { 
        config["Health"].Value -= amount;        
    }

    private void Update()
    {
        swingTimer -= Time.deltaTime;
        if(swingTimer <= 0)
        {
            Attack();
            swingTimer = swingCooldown;     
        }
    }

    public void Attack()
    {
        _weaponAnimator.SetTrigger(SWING);
    }
}
