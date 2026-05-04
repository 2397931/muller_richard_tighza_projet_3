using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinscript : MonoBehaviour
{
    public int count;
    public AudioClip coinSound;

    private AudioSource audioSource;

    private void Start()
    {
 
        audioSource = GetComponent<AudioSource>();

        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("coin"))
        {
            audioSource.PlayOneShot(coinSound);
            other.gameObject.SetActive(false);
            count += 100;
        }
    }
}