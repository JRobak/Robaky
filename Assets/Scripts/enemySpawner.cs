using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    
    public float spawnRate;
    public GameObject[] enemyPrefabs;
    public bool canSpawn = true;

    public void Start()
    {
        StartCoroutine(Spawner());
    }

    private IEnumerator Spawner ()
    {
        WaitForSeconds wait = new WaitForSeconds(spawnRate);

        while(true)
        {
            yield return wait;
            int rand = Random.Range(0, enemyPrefabs.Length);

            GameObject enemyToSpawn = enemyPrefabs[rand];

            Instantiate(enemyToSpawn, new Vector3(Random.Range(-8.5f, 8.5f), Random.Range(-4.5f, 4.5f), 0), Quaternion.identity);

        } 
    }

    
}
