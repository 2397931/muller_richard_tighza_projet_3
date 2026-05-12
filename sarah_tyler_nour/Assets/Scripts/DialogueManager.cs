using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.XR;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;
    public GameObject BoxDialogue;
    public ObjectiveUI objectiveUI;


    public AudioSource dialogueAudio;

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


        dialogueAudio.pitch = Random.Range(0.97f, 1.03f);
        dialogueAudio.Play();

        Debug.Log("Zone Boutique entré");
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


        dialogueAudio.pitch = Random.Range(0.97f, 1.03f);
        dialogueAudio.Play();

        dialogueText.text = sentences[index];
    }

    public void EndDialogue()
    {
        BoxDialogue.SetActive(false);


        dialogueAudio.pitch = Random.Range(0.97f, 1.03f);
        dialogueAudio.Play();

        objectiveUI.ShowObjective("Ramasse les objets dans le donjon", 4f);

        Debug.Log("Zone Boutique sortie");
    }

    void Update()
    {
        InputDevice rightHand = InputDevices.GetDeviceAtXRNode(XRNode.RightHand);

        bool aButtonPressed;

        if (rightHand.TryGetFeatureValue(CommonUsages.primaryButton, out aButtonPressed) && aButtonPressed)
        {
            // action
        }
    }
}