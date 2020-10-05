using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SunController : MonoBehaviour
{
    public float speedRotate;

    public int health = 20;
    public GameObject destroyEffect;

    public Slider healthBar;
    //public bool isDead;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * speedRotate * Time.deltaTime);

        if (health <= 0)
        {
            Instantiate(destroyEffect, transform.position, Quaternion.identity);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        healthBar.value = health;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("Hit!");
        if (other.CompareTag("Enemy"))
         {
            health -= other.GetComponent<Enemy>().damage;
            Destroy(other.GetComponent<Enemy>().gameObject);
            Instantiate(destroyEffect, transform.position, Quaternion.identity);
        }
    }
}
