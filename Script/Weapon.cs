﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float offset;

    public GameObject projectile;
    //public GameObject shotEffect; shot animation at release
    public Transform firePoint;

    private float timeBtwShots;
    public float startTimeBtwShots;

    // Update is called once per frame
    void Update()
    {
        //Handles the weapon rotation
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);

        if (timeBtwShots <= 0)
        {
            if (Input.GetMouseButton(0))
            {
                //Instantiate(destroyEffect, firePoint.position, Quaternion.identity);
                Instantiate(projectile, firePoint.position, transform.rotation);
                timeBtwShots = startTimeBtwShots;
            }
        }
        else
        {
           timeBtwShots -= Time.deltaTime;
        }

    }

    /*void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("RevCounter"))
        {
            Debug.Log("Hit");
            RevolutionCounter.revCounter += 1;

        }
    }*/

}
