using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DialogueData
{
    public string npcname;  // NPC 이름
    public List<string> dialogueLines;  // 대화 내용 목록

    private int currentIndex = 0;

    public DialogueData(string name, List<string> lines)
    {
        npcname = name;
        dialogueLines = lines;
        currentIndex = 0;
    }

    // 현재 대화 단계를 반환하고 다음 단계로 이동
    public string GetNextDialogue()
    {
        if (currentIndex < dialogueLines.Count)
        {
            return dialogueLines[currentIndex++];
        }
        return null;  // 대화가 끝났다면 null 반환
    }

    // 대화 재시작
    public void ResetDialogue()
    {
        currentIndex = 0;
    }
}
