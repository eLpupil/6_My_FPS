using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
    [SerializeField] Camera FPCamera;
    [SerializeField] float maxRange = 100f;


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
        RaycastHit hit;
        bool rayHit = Physics.Raycast(FPCamera.transform.position, FPCamera.transform.forward, out hit, maxRange);
        if (rayHit)
        {
            print(hit.transform.name);
        }
    }
}
