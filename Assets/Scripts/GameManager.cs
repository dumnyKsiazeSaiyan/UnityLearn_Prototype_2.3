using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private int score = 0;
    private int lives = 3;

    private void Start()
    {
        Debug.Log($"Score = {score}");
        Debug.Log($"Lives= {lives}");
    }

    private void Update()
    {

    }


    public void AddLives(int value)
    {

        lives += value;
        if (lives <= 0)
            Debug.Log("Game Over player was killed by animal");
        Debug.Log($"Lives = {lives}");
    }

    public void AddScore(int values)
    {
        score += values;
        Debug.Log($"Score = {score}");
    }
}
