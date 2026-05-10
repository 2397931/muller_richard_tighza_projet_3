using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;
    public GameObject BoxDialogue;

    private int index;
    private string[] sentences;

    void Start()
    {
        BoxDialogue.SetActive(false);
    }

    public void StartDialogue(Dialogue dialogue)
    {


        BoxDialogue.SetActive(true);

        nameText.text = dialogue.speakerName;

        sentences = dialogue.sentences;
        index = 0;

        dialogueText.text = sentences[index];

        Debug.Log("Zone Boutique entré");
        return;
    }

    public void DisplayNextSentence()
    {

        if (sentences == null || sentences.Length == 0)
        {
            Debug.LogWarning("No dialogue active!");
            return;
        }

        index++;

        if (index >= sentences.Length)
        {
            EndDialogue();
            return;
        }

        dialogueText.text = sentences[index];
    }

    public void EndDialogue()
    {
        BoxDialogue.SetActive(false);

        Debug.Log("Zone Boutique sortie");
        return;
    }

    void Update()
    {
        if (BoxDialogue.activeSelf && Input.GetKeyDown(KeyCode.Z))
        {
            DisplayNextSentence();
        }
    }
}
