using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcbbDialogue : MonoBehaviour
{
    public DialogueData dialogueData;  // DialogueData ��ü ����

    void Start()
    {
        dialogueData = new DialogueData(" bb", new List<string>
        {
            "�ȳ��ϼ���.",
            "������ �ٶ��� �ÿ��� ����� �ʹ� ���ƿ� ����",
            "��������",
            "������ ſ�� ������ ��⸸ �þ������ �ٺ� ����"
        });
    }

    // ���� ��ȭ ��ȯ
    public string GetNextDialogue()
    {
        return dialogueData.GetNextDialogue();
    }

    // ��ȭ ����
    public void ResetDialogue()
    {
        dialogueData.ResetDialogue();
    }
}