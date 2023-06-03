using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefab;
    private float startDelay = 2.0f;
    private float spawnXRange = 20;

    private int leftAndRightSpawnXPos = 30;
    private int leftAndRightSpawnZTopPos = 17;
    private int leftAndRightSpawnZBottomPos = 0;
    private void Start()
    {
        Invoke("SpawnRandomAnimalTop", startDelay);
        Invoke("SpawnRandomAnimalFromLeft", startDelay);
        Invoke("SpawnRandomAnimalFromRight", startDelay);
    }

    private void SpawnRandomAnimalTop()
    {
        int animalIndex = Random.Range(0, animalPrefab.Length);
        float xPosition = Random.Range(-spawnXRange, spawnXRange);

        Instantiate(animalPrefab[animalIndex],
            new Vector3(xPosition, 0, 25),
            animalPrefab[animalIndex].transform.rotation = Quaternion.Euler(0, 180, 0));

        float spawnInterval = Random.Range(2, 6);
        Invoke("SpawnRandomAnimalTop", spawnInterval);
    }

    private void SpawnRandomAnimalFromLeft()
    {
        int animalIndex = Random.Range(0, animalPrefab.Length);
        float zPosition = Random.Range(leftAndRightSpawnZBottomPos, leftAndRightSpawnZTopPos);

        Instantiate(animalPrefab[animalIndex],
            new Vector3(-leftAndRightSpawnXPos, 0, zPosition),
            animalPrefab[animalIndex].transform.rotation = Quaternion.Euler(0,90,0));

        float spawnInterval = Random.Range(2, 6);
        Invoke("SpawnRandomAnimalFromLeft", spawnInterval);
    }

    private void SpawnRandomAnimalFromRight()
    {
        int animalIndex = Random.Range(0, animalPrefab.Length);
        float zPosition = Random.Range(leftAndRightSpawnZBottomPos, leftAndRightSpawnZTopPos);

        Instantiate(animalPrefab[animalIndex],
            new Vector3(leftAndRightSpawnXPos, 0, zPosition),
            animalPrefab[animalIndex].transform.rotation = Quaternion.Euler(0, 270, 0));

        float spawnInterval = Random.Range(2, 6);
        Invoke("SpawnRandomAnimalFromRight", spawnInterval);
    }
}
