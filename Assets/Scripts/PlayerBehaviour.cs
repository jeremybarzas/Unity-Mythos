
using UnityEngine;

public class PlayerBehaviour : EntityBehaviour, IDamageable {

    public IDamager weapon;
    public IDamageable target;
    public Animator animator;
    public ScriptableObject so;
    public WeaponBehaviour weaponBehaviour;

    public void TakeDamage(int amount)
    {
        config.health -= amount;
    }

    private void Start()
    {
        weapon = (Sword)so;
        weaponBehaviour.SetWeapon(weapon);
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            animator.SetTrigger("swing");
    }
}
