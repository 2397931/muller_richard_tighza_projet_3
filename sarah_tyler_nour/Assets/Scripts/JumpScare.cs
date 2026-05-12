using UnityEngine;

public class JumpScare : MonoBehaviour
{
    public Animator animator;

    private bool played = false;

    private void OnTriggerEnter(Collider other)
    {
        if (played) return;

        if (other.transform.root.CompareTag("Player"))
        {
            played = true;

            Debug.Log("PLAY JUMPSCARE");

            animator.SetTrigger("PlayAnim");
        }
    }
}