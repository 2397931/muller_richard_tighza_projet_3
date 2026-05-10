using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public DialogueManager dialogueManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            dialogueManager.StartDialogue(dialogue);

            dialogueManager.objectiveUI.ShowObjective("Parle au marchand", 1f);
        }
    }

    private void OnTriggerExit(Collider other) 
    { 
        if (other.CompareTag("Player")) 
            { dialogueManager.EndDialogue(); 
        } 
    }
}
