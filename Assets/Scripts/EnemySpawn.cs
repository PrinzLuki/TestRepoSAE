using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;
    public float spawnTime;
    // Start is called before the first frame update
    void Start()
    {
        //Spawn Enemy
        SpawnEnemy();
    }
    void SpawnEnemy()
    {
        Vector3 spawnPosition = transform.position;
        spawnPosition.x = -11.5f + Random.value * 11.5f * 2;
        spawnPosition.x = Random.Range(-11.5f, 11.5f);


        Instantiate(enemy, spawnPosition, transform.rotation);
        Invoke("SpawnEnemy", spawnTime);
    }
}
