using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{

    private AnimalHunger animalHunger;

    private void Start()
    {
        animalHunger = GetComponent<AnimalHunger>();
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }

        if (other.CompareTag("Food"))
        {
            animalHunger.FeedAnamial(1);
            Destroy(other.gameObject);
        }
    }
}
