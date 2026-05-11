using System.Collections.Generic;
using UnityEngine;

public class ZoneDepot : MonoBehaviour
{
    private HashSet<GameObject> objectsInside = new HashSet<GameObject>();

    private bool hasWon = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DropObject"))
        {
            objectsInside.Add(other.gameObject);

            CheckWin();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("DropObject"))
        {
            objectsInside.Remove(other.gameObject);
        }
    }

    void CheckWin()
    {
  
        if (!hasWon && objectsInside.Count >= 7)
        {
            hasWon = true;

            Debug.Log("Victoire");
        }
    }
}