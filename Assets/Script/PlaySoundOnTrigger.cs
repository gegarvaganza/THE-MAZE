using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnTrigger : MonoBehaviour
{
    public AudioClip soundClip; // The sound to play
    [Range(0f, 1f)] public float volume = 1f; // Volume adjustment (0 to 1)
    [Range(0.1f, 3f)] public float pitch = 1f; // Pitch adjustment (0.1 to 3)
    private AudioSource audioSource;

    void Start()
    {
        // Add an AudioSource component to the GameObject if not already present
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Set the AudioClip to the AudioSource
        audioSource.clip = soundClip;
        audioSource.volume = volume;
        audioSource.pitch = pitch;
        audioSource.playOnAwake = false; // Prevent the audio from playing automatically
    }

    // Trigger event when another collider enters
    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider belongs to the player (tagged as "Player")
        if (other.CompareTag("Player"))
        {
            // Play the sound
            if (!audioSource.isPlaying)
            {
                audioSource.volume = volume; // Adjust volume dynamically
                audioSource.pitch = pitch;   // Adjust pitch dynamically
                audioSource.Play();
            }
        }
    }
}
