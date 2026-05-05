using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PauseMEnu : MonoBehaviour
{
    public InputActionProperty boutonMenu;
    public GameObject canvaMenu;

    // Update is called once per frame
    void Update()
    {
        if (boutonMenu.action.WasPressedThisFrame())
        {
            canvaMenu.SetActive(true);
        }
    }
}
