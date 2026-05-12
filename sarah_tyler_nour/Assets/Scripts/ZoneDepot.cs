using System.Collections.Generic;
using UnityEngine;

public class ZoneDepot : MonoBehaviour
{
    public int count;
    public GameObject UIVictoire;


    public ScorePersistant pointage;

    private HashSet<GameObject> objectsInside = new HashSet<GameObject>();

    private bool hasWon = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DropObject"))
        {
            
            if (!objectsInside.Contains(other.gameObject))
            {
             
                if (count < 7)
                {
                    count++;
                }

                objectsInside.Add(other.gameObject);

                // Update score UI
                pointage.OnChangerPointage(count);

                CheckWin();
            }
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

            if (UIVictoire != null)
            {
                UIVictoire.SetActive(true);
            }
        }
    }
}