using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit; 

public class ShopItemscript : MonoBehaviour
{
    public int argent;
    public GameObject lantern;

    public void OnTriggerEnter(Collider other)
    {
        //amasser argent
        if(argent>650)
        {
            lantern.GetComponent<XRGrabInteractable>().enabled = true;
        }
    }


  

}
