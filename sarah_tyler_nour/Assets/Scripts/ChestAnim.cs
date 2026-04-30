using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ChestAnim : MonoBehaviour
{
    Animator chestLid;
    public InputActionProperty boutonSecondaire;

    // Start is called before the first frame update
    void Start()
    {
         chestLid = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.O))
        {
            chestLid.Play("LidOpen");
        }
        if(Input.GetKeyDown(KeyCode.C))
        {
            chestLid.Play("LidClose");
        } 


        if(boutonSecondaire.action.WasPressedThisFrame())
        {
           chestLid.Play("LidOpen");  
        } 
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="RightController")
        {
            Debug.Log("Open Chest");
             chestLid.Play("LidOpen");
        }

    }

}
