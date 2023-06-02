using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    [SerializeField] private float topBound = 25;
    [SerializeField] private float lowerBound = -10;

    private void Update()
    {
        if(transform.position.z >= topBound )
        {
            Destroy(gameObject);
        }
        else if (transform.position.z <= lowerBound)
        {
            Destroy(gameObject);
            Debug.Log("Game Over!");
        }
    }
}
