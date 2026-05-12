using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pieges : MonoBehaviour
{
    public Transform startPoint;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Touched: " + other.name);

        if (other.CompareTag("Player"))
        {
            Debug.Log("Player touched the trap!");

            CharacterController cc = other.GetComponent<CharacterController>();

            if (cc != null)
            {
                cc.enabled = false;

                other.transform.position = startPoint.position;

                cc.enabled = true;

                Debug.Log("Player teleported to start point.");
            }
            else
            {
                other.transform.position = startPoint.position;

                Debug.Log("Teleported without CharacterController.");
            }
        }
    }
}