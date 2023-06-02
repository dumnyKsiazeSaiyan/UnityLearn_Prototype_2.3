using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefab;
    private float startDelay = 2.0f;
    private float spawnInterval = 1.5f;
    private float spawnXRange = 20;
    private void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    private void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefab.Length);
        float xPosition = Random.Range(-spawnXRange, spawnXRange);

        Instantiate(animalPrefab[animalIndex], 
            new Vector3(xPosition, 0, 25), 
            animalPrefab[animalIndex].transform.rotation);
    }
}
