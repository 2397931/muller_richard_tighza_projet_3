using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChest : MonoBehaviour
{
    public Animator animator;
    private bool isOpened = false;

    public void Open()
    {
        if (isOpened) return;

        animator.SetTrigger("Open");
        isOpened = true;
    }
}
