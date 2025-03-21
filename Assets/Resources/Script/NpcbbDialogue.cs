using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DialogueData
{
    public string npcname;  // NPC �̸�
    public List<string> dialogueLines;  // ��ȭ ���� ���

    private int currentIndex = 0;

    public DialogueData(string name, List<string> lines)
    {
        npcname = name;
        dialogueLines = lines;
        currentIndex = 0;
    }

    // ���� ��ȭ �ܰ踦 ��ȯ�ϰ� ���� �ܰ�� �̵�
    public string GetNextDialogue()
    {
        if (currentIndex < dialogueLines.Count)
        {
            return dialogueLines[currentIndex++];
        }
        return null;  // ��ȭ�� �����ٸ� null ��ȯ
    }

    // ��ȭ �����
    public void ResetDialogue()
    {
        currentIndex = 0;
    }
}
