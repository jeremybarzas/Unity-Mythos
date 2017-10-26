using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : EntityBehaviour, IDamageable
{
    public void TakeDamage(int amount)
    {
        config.health -= amount;
    }
}
