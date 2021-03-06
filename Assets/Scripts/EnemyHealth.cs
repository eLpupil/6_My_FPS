﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float hitPoints = 100f;

    public void TakeDamage(float damage)
    {
        if (hitPoints > 0)
        {
            hitPoints -= damage;
        }
        else
        {
            //enemy die sequence
            Destroy(gameObject);
        }
    }

}
