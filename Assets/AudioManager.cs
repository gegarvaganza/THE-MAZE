using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("-------- Audio Source --------")]
    [SerializeField] private AudioSource musicSource;

    [Header("-------- Audio Clip --------")]
    [SerializeField] private AudioClip background;

    [Header("-------- Volume Settings --------")]
    [Range(0f, 1f)] public float volume = 1.0f; // Default volume level

    private void Start()
    {
        // Initialize AudioSource with clip, volume, and loop settings
        musicSource.clip = background;
        musicSource.volume = volume;
        musicSource.loop = true; // Enable looping
        musicSource.Play();
    }

    private void Update()
    {
        // Dynamically update the volume
        musicSource.volume = volume;
    }

    // Optional: Method to set volume via script
    public void SetVolume(float newVolume)
    {
        volume = Mathf.Clamp01(newVolume); // Ensure volume stays between 0 and 1
        musicSource.volume = volume;
    }
}