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
            other.transform.position = startPoint.position;
        }
    }
}
