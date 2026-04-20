using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class BuyableItem : MonoBehaviour
{
    public int price = 50;
    private XRGrabInteractable grabScript;
    private Wallet playerWallet;

    void Start()
    {
        // 1. Try to find the Grab script on THIS object
        grabScript = GetComponent<XRGrabInteractable>();
        
        // 2. Try to find the Wallet script in the SCENE
        playerWallet = FindObjectOfType<Wallet>();

        // CHECK 1: Did we find the grab script?
        if (grabScript != null)
        {
            grabScript.enabled = false;
        }
        else
        {
            Debug.LogError("ERROR: " + gameObject.name + " is missing the XR Grab Interactable component!");
        }

        // CHECK 2: Did we find the wallet?
        if (playerWallet == null)
        {
            Debug.LogError("ERROR: Could not find the Wallet script in the scene! Is it on the GameManager?");
        }
    }

    public void Purchase()
    {
        // Add a check here too so clicking the button doesn't crash the game
        if (playerWallet != null && grabScript != null)
        {
            if (playerWallet.money >= price)
            {
                playerWallet.money -= price;
                grabScript.enabled = true;
                Debug.Log("Item Purchased!");
                GetComponent<Renderer>().material.color = Color.white;
            }
            else
            {
                Debug.Log("Not enough money!");
            }
        }
    }
}