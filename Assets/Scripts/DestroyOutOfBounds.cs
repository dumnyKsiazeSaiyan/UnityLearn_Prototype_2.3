using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    [SerializeField] private float topBound = 25;
    [SerializeField] private float lowerBound = -10;
    [SerializeField] private float rightLeftBound = 35;

    private GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void Update()
    {
        if(transform.position.z >= topBound )
        {
            Destroy(gameObject);
        }
        else if (transform.position.z <= lowerBound)
        {
            Destroy(gameObject);
            gameManager.AddLives(-1);
        }
        else if (transform.position.x >= rightLeftBound || transform.position.x <= -rightLeftBound)
        {
            Destroy(gameObject);
        }
    }
}
