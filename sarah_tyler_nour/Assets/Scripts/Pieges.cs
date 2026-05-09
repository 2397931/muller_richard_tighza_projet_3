using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pieges : MonoBehaviour
{
    public Transform startPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CharacterController cc = other.GetComponent<CharacterController>();

            if (cc != null)
            {
                cc.enabled = false;
                other.transform.position = startPoint.position;
                cc.enabled = true;
            }
            else
            {
                other.transform.position = startPoint.position;
            }
        }
    }
}