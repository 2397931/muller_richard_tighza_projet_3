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
        BoxDialogue.SetActive(true);
    }

    public void StartDialogue(Dialogue dialogue)
    {
        Debug.Log("StartDialogue CALLED");

        BoxDialogue.SetActive(true);

        nameText.text = dialogue.speakerName;
        dialogueText.text = dialogue.sentences[0];
    }

    public void EndDialogue()
    {
        BoxDialogue.SetActive(false);
    }
}
