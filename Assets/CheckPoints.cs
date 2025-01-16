using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoints : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Update the player's current checkpoint
            Debug.Log("Player reached a checkpoint!");
            PlayerDeath playerDeath = other.GetComponent<PlayerDeath>();
            if (playerDeath != null)
            {
                playerDeath.SetCheckpoint(transform);
                Debug.Log("Checkpoint updated.");
            }
        }
    }
}
