using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;
    public GameObject BoxDialogue;

    void Start()
    {
        BoxDialogue.SetActive(false);
    }

    public void EndDialogue()
    {
        BoxDialogue.SetActive(false);
    }

    public void StartDialogue(Dialogue dialogue)
    {
        nameText.text = dialogue.name;
        dialogueText.text = dialogue.sentences[0];
    }
}
