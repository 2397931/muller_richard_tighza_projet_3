using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinscript : MonoBehaviour
{
 
public int count;

   private void OnTriggerExit(Collider other)
   {
    if(other.tag == "coin")
    {
        other.gameObject.SetActive(false);
        count ++;
    }

   }
}
