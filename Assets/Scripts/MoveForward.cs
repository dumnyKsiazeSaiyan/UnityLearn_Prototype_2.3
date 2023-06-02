using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] private float throwSpeed = 45.0f;


    private void Update()
    {
        transform.Translate(Time.deltaTime * throwSpeed * Vector3.forward);
    }
}
