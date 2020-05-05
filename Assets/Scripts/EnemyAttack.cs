using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    PlayerHealth target;
    [SerializeField] float damage = 10f;

    private void Start()
    {
        target = FindObjectOfType<PlayerHealth>();
    }
    public void AttackPlayerEvent()
    {
        if (target != null)
        {
            target.TakeDamage(damage);
        }
    }
}
