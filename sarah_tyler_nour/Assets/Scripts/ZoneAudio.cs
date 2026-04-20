using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneAudio : MonoBehaviour
{
    private AudioSource _audioSource;

    void Start()
    {
        // Link the script to the AudioSource on this object
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Only play if the object entering has the "Player" tag
        if (other.CompareTag("Player"))
        {
            _audioSource.Play();
            Debug.Log("Player entered zone - Audio Playing");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Stop playing when the player leaves
        if (other.CompareTag("Player"))
        {
            _audioSource.Stop();
            Debug.Log("Player left zone - Audio Stopped");
        }
    }
}