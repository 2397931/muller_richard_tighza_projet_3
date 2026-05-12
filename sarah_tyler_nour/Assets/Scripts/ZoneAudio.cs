using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneAudio : MonoBehaviour
{
    private AudioSource _audioSource;

    void Start()
    {

        _audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            _audioSource.Play();
            Debug.Log("nagasin");
            Debug.Log("Player entered zone - Audio Playing");
        }
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            _audioSource.Stop();
            Debug.Log("Player left zone - Audio Stopped");
        }
    }
}