using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    [SerializeField] private float movementSpeed = 27.0f;
    [SerializeField] private float xRange = 20.0f;

    public GameObject projectilePrefab;

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput= Input.GetAxis("Vertical");

        if (transform.position.x < -xRange)
            transform.position = new(-xRange, transform.position.y, transform.position.z);
        if (transform.position.x > xRange)
            transform.position = new(xRange, transform.position.y, transform.position.z);

        if (transform.position.z < -5)
            transform.position = new(transform.position.x, transform.position.y, -5);
        if (transform.position.z > 20)
            transform.position = new(transform.position.x, transform.position.y, 20);

        transform.Translate(Time.deltaTime * horizontalInput * movementSpeed * Vector3.right);
        transform.Translate(Time.deltaTime * verticalInput * movementSpeed * Vector3.forward);



        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
