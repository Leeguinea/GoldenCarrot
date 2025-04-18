using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public int questId;
    public int questActionIndex;
    public bool hasEgg = false; // 계란 획득 여부

    public GameObject[] questObject;

    Dictionary<int, QuestData> questList;

    void Awake()
    {
        questList = new Dictionary<int, QuestData>();
        GenerateData();
    }


    void GenerateData()
    {
        questList.Add(0, new QuestData("시작 전", new int[] {}));
        questList.Add(10, new QuestData("닭과 대화하기", new int[] {1000, 1000}));
        questList.Add(20, new QuestData("닭의 계란 찾아주기", new int[] {5000, 1000}));
        //questList.Add(30, new QuestData("비버와 대화하기", new int[] {1000, 2000}));
    }

    public int GetQuestTalkIndex(int id)
    {
        return questId + questActionIndex;
    }

    //대화가 끝나면 index++
    public string CheckQuest(int id)
    {
        // 현재 퀘스트의 NPC ID 배열 길이 체크
        if (questActionIndex < questList[questId].npcId.Length)
        {
            if (id == questList[questId].npcId[questActionIndex])
                questActionIndex++;
        }

        ControlObject();

        // 퀘스트 완료 체크 (계란 퀘스트 추가 조건)
        if (questActionIndex == questList[questId].npcId.Length)
        {
            if (questId == 10 && !hasEgg)
            {
                return "계란을 먼저 찾아주세요!"; // 안내 메시지
            }
            else
            {
                NextQuest();
            }
        }

        return questList[questId].questName;
    }

    void NextQuest()
    {
        questId += 10;
        questActionIndex = 0;
        hasEgg = false; // 다음 퀘스트를 위한 초기화
    }

    void ControlObject()
    {
        switch(questId)
        {
            case 10:
                if (questActionIndex == 1)
                {
                    questObject[0].SetActive(true); // 계란 활성화
                }
                break;
            case 20:
                if (questActionIndex == 1)
                {
                    questObject[0].SetActive(false); // 계란 비활성화
                }
                break;
        }
    }

}

