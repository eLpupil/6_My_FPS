using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
    [SerializeField] Camera FPCamera;
    [SerializeField] float maxRange = 100f;
    [SerializeField] float damage = 10f;
    [SerializeField] ParticleSystem muzzleFlash;
    [SerializeField] ParticleSystem hitFX;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        muzzleFlash.Play();
        ProcessRayCast();
    }

    private void ProcessRayCast()
    {
        RaycastHit hit;
        bool rayHit = Physics.Raycast(FPCamera.transform.position, FPCamera.transform.forward, out hit, maxRange);
        if (rayHit)
        {
            ParticleSystem bulletImpact = Instantiate(hitFX, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(bulletImpact, 1);

            EnemyHealth enemyHealth = hit.transform.GetComponent<EnemyHealth>();
            if (enemyHealth == null) { return; }
            enemyHealth.TakeDamage(damage);
        } 
    }
}
