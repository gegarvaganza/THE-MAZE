using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public Transform[] checkpoints; // Array of checkpoint locations
    private Transform currentCheckpoint; // Current active checkpoint
    private Vector3 startPosition; // Player's starting position

    private void Start()
    {
        // Set the starting position or the first checkpoint
        if (checkpoints.Length > 0)
        {
            currentCheckpoint = checkpoints[0];
        }
        startPosition = transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the player touched a hazardous object
        if (other.CompareTag("Lava"))
        {
            RespawnPlayer();
        }
    }

    public void SetCheckpoint(Transform checkpoint)
    {
        // Update the current checkpoint
        currentCheckpoint = checkpoint;
    }

    private void RespawnPlayer()
    {
        // Move player to the current checkpoint or starting position
        if (currentCheckpoint != null)
        {
            transform.position = currentCheckpoint.position;
        }
        else
        {
            transform.position = startPosition;
        }
    }
}
