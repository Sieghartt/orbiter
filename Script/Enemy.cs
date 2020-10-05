using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public GameObject destroyEffect;

    private Transform sunPos;
    private SunController sun;

    public float speed;
    public int damage;

    private Vector2 destryoedSunPosition;

    private void Start()
    {
        sun = GameObject.FindGameObjectWithTag("Sun").GetComponent<SunController>();
        sunPos = GameObject.FindGameObjectWithTag("Sun").transform;
    }

    private void Update()
    {

        if (sunPos != null)
        {
            
            transform.position = Vector2.MoveTowards(transform.position, sunPos.position, speed * Time.deltaTime);
        }
        else
        {
            Debug.Log("Hakdog");
            
        }

        if (health <= 0)
        {
            Instantiate(destroyEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

    }
    public void TakeDamage(int damage)
    {
        health -= damage;
    }

    private void OnTriggerEnter2d(Collider2D other)
    {
        Debug.Log("Hit!");
        /*if (other.CompareTag("Sun"))
        {
            TakeDamage(other.GetComponent<SunController>().damage);
            Instantiate(destroyEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }*/
    }
}

