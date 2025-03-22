using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcbbDialogue : MonoBehaviour
{
    public DialogueData dialogueData;  // DialogueData 객체 선언

    void Start()
    {
        dialogueData = new DialogueData(" bb", new List<string>
        {
            "안녕하세요.",
            "적당히 바람이 시원해 기분이 너무 좋아요 유후",
            "끝내줬어요",
            "긴장한 탓에 엉뚱한 얘기만 늘어놓았죠 바보 같이"
        });
    }

    // 다음 대화 반환
    public string GetNextDialogue()
    {
        return dialogueData.GetNextDialogue();
    }

    // 대화 리셋
    public void ResetDialogue()
    {
        dialogueData.ResetDialogue();
    }
}