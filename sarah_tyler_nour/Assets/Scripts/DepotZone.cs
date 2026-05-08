using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepotZone : MonoBehaviour
{
  private const int objetsRequis = 2;

    private HashSet<GameObject> objetsDansZone = new HashSet<GameObject>();

    private bool victoire = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DropObject"))
        {
            objetsDansZone.Add(other.gameObject);

            Debug.Log("Objet déposé : " + other.name);

            VerifierVictoire();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("DropObject"))
        {
            objetsDansZone.Remove(other.gameObject);

            Debug.Log("Objet retiré : " + other.name);
        }
    }

    private void VerifierVictoire()
    {
        if (!victoire && objetsDansZone.Count >= objetsRequis)
        {
            victoire = true;

            Debug.Log("VICTOIRE !");
        }
    }

}
