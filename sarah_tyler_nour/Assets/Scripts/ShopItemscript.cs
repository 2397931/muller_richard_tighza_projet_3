using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit; 

public class ShopItemscript : MonoBehaviour
{
    public int argent;
    
    public GameObject lantern;
    public int lanternPrice = 650;

    public GameObject sword;
    public int swordPrice = 1200;

    public GameObject shield;
    public int shieldPrice = 800;

    public void OnTriggerEnter(Collider other)
    {
        // code pour la Lantern
        if(argent >= lanternPrice)
        {
            lantern.GetComponent<XRGrabInteractable>().enabled = true;
        }
        else
        {
            lantern.GetComponent<XRGrabInteractable>().enabled = false;
        }

        // code pour le sword
        if(argent >= swordPrice)
        {
            sword.GetComponent<XRGrabInteractable>().enabled = true;
        }
        else
        {
            sword.GetComponent<XRGrabInteractable>().enabled = false;
        }

        // code pour le Shield
        if(argent >= shieldPrice)
        {
            shield.GetComponent<XRGrabInteractable>().enabled = true;
        }
        else
        {
            shield.GetComponent<XRGrabInteractable>().enabled = false;
        }
    }
}