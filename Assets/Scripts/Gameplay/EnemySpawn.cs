using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;

    public float spawnTime = 2;

    private void Start()
    {
        SpawnEnemy();
    }

    void SpawnEnemy()
    {
        Vector3 spawnPosition = transform.position;

        //spawnPosition.x = -11.5f + Random.value * 11.5f * 2;
        spawnPosition.x = Random.Range(-11.5f, 11.5f);

        Instantiate(enemy, spawnPosition, transform.rotation);

        Invoke("SpawnEnemy", spawnTime);
    }
}
