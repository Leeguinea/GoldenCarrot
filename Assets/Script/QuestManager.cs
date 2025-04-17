using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public int questId;
    public int questActionIndex;
    public GameObject[] questObject;
    Dictionary<int, QuestData> questList;

    void Awake()
    {
        questList = new Dictionary<int, QuestData>();
        GenerateData();
    }


    void GenerateData()
    {
        questList.Add(10, new QuestData("계란 5개 얻기",
                                        new int[] {1000, 10000}));
        //questList.Add(20, new QuestData("계란 5개 얻기",
        //                               new int[] {10000, 1000}));                                        

    }

    public int GetQuestTalkIndex(int id)
    {
        return questId + questActionIndex;
    }

    //대화가 끝나면 index++
    public string CheckQuest(int id)
    {
        if(id == questList[questId].npcId[questActionIndex])
            questActionIndex++;

        if(questActionIndex == questList[questId].npcId.Length)
            NextQuest();

        return questList[questId].questName;
    }

    void NextQuest()
    {
        questId += 10;
        questActionIndex = 0;
    }
    
    void ControlObject()
    {
        
    }
