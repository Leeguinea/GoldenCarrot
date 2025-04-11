//using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> talkData;

    
    void Awake()
    {
        talkData = new Dictionary<int, string[]>();
        GenerateData();
    }

    void GenerateData()
    {
        talkData.Add(1000, new string[] {"빠빠", "빠빠빠"});      


        
        talkData.Add(500, new string[] {"로니씨 안녕하세요.", "맛있는 생초 사가세요~"});
        talkData.Add(600, new string[] {"좋은 하루입니다.", "오늘 채소가 정말 싱싱해요."});   


        //sign
        talkData.Add(100, new string[] {"싱싱생초 행복마켓에 오신걸 환영합니다.", "s"});
        talkData.Add(150, new string[] {"당근밭 채소가게에 오신걸 환영합니다.", "s"});
    }

    public string GetTalk(int id, int talkIndex)
    {
        return talkData[id][talkIndex];
    }
}
