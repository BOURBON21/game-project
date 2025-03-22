using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueSystem : MonoBehaviour
{
    [SerializeField] Text targetText;
    [SerializeField] Text nameText;

    DialogueContainer currentDialogue;
    int currentTextLine;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PushText();
        }
    }

    private void PushText()
    {
        currentTextLine += 1;
        if (currentTextLine >= currentDialogue.line.Count)
        {
            Conclude();
        }
        else
        {
            targetText.text = currentDialogue.line[currentTextLine];
        }
    }

    public void Initialize(DialogueContainer dialogueContainer)
    {
        Show(true);
        currentDialogue = dialogueContainer;
        currentTextLine = 0;
        targetText.text = currentDialogue.line[currentTextLine];
    }

    private void Show(bool v)
    {
        gameObject.SetActive(v);
    }

    private void Conclude()
    {
        Show(false);
        Debug.Log("Dialogue test // Stickcode post ");
    }
}