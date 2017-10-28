
using UnityEngine;

public class PlayerBehaviour : EntityBehaviour, IDamageable
{
    public Weapon _weapon;    
    private WeaponBehaviour _weaponBehaviour;
    public Animator _weaponAnimator;
    public Rigidbody _rigidbody;
    public AudioSource _audioSource;
    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _rigidbody = GetComponent<Rigidbody>();
        _weaponBehaviour = GetComponentInChildren<WeaponBehaviour>(); //we only have one weapon
        _weaponBehaviour.SetWeapon(_weapon); //set the current weapon
        
        
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            _weaponAnimator.SetTrigger("swing");
        _weaponAnimator.SetFloat("speed", _rigidbody.velocity.magnitude);
    }

    public void TakeDamage(int amount)
    {
        _audioSource.Play();
        config["Health"].Value -= amount;
        _weaponAnimator.SetInteger("health", config["Health"].Value);
    }
}
