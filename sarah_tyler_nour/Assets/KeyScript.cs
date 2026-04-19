using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KeyboardChest : MonoBehaviour
{
    public Animator chestAnimator; // Drag the lid/chest here
    public GameObject keyInside;   // Drag the key here

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            // 1. Play the animation
            chestAnimator.SetTrigger("OpenChest");

            // 2. Make the key appear (or enable it to be grabbed)
            if (keyInside != null)
            {
                keyInside.SetActive(true);
            }
            
            Debug.Log("Chest opening animation triggered!");
        }
    }
}