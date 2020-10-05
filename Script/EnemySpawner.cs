using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public Transform[] spawnPoints;
    private float timeBtwSpawns;
    public float startTimeBtwSpawns;


    void Start()
    {
        timeBtwSpawns = startTimeBtwSpawns;
    }


    void Update()
    {
        if (timeBtwSpawns <=0)
        {
            int randPos = Random.Range(0, spawnPoints.Length);
            Instantiate(enemy, spawnPoints[randPos].position, Quaternion.identity);
            timeBtwSpawns = startTimeBtwSpawns;
        }

        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }
    }
}
