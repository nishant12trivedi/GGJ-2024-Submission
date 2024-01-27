using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{
    // Time it takes for each enemy to spawn
    [SerializeField] private float spawnRate = 2.5f;
    // NOTE (donke): Enemy list de do isse
    // Ya to idhr ya editor me
    [SerializeField] private GameObject enemyPrefabs;
    [SerializeField] private bool canSpawn = true;

    private int gridSizeXaxisMin= -6 ,gridSizeXaxisMax= 6, gridSizeYaxisMin= -5, gridSizeYaxisMax= 5;

    private void Start()
    {
        StartCoroutine(Spawner());
    }

    private IEnumerator Spawner ()
    {
        WaitForSeconds wait = new WaitForSeconds(spawnRate);
        int count=0;
        while (canSpawn && count < 6)
        {
            //enable the prefab in scene
            enemyPrefabs.SetActive(true);
            ++count;
            Debug.Log("Spawned");
            yield return wait;

            //Generate random transform wrt to Scene Grid 
            int xrandom = Random.Range(gridSizeXaxisMin, gridSizeXaxisMax);
            int yrandom = Random.Range(gridSizeYaxisMin, gridSizeYaxisMax);
            Debug.Log("xaxis "+ xrandom + " y axis" + yrandom);
            
            Instantiate(enemyPrefabs, new Vector3(xrandom, yrandom, 0), Quaternion.identity);

           // int randEnemyIndex = Random.Range(0, enemyPrefabs.Length);
           //  GameObject enemyToSpawn = enemyPrefabs[randEnemyIndex];
           // Instantiate(enemyToSpawn, transform.position, Quaternion.identity);

        }
    }
}
