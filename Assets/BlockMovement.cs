using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust the speed as needed.

    private void Update()
    {
        // Get the input for horizontal and vertical movement (arrow keys and W/S keys).
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the movement vector.
        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0);

        // Apply the movement to the Cube.
        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
}


