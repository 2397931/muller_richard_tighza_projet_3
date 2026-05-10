using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScare : MonoBehaviour
{
    public Animator animator;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ZONE ENTERED");

        if (other.CompareTag("Player"))
        {
            Debug.Log("PLAY ANIMATION");

            animator.SetTrigger("PlayAnim");
        }
    }
}
