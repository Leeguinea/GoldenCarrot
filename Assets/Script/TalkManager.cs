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
        //QuizChicken,꼬꼬댁아줌마
        talkData.Add(1000, new string[] {"꼬끼오. 안녕 로니.", "날씨가 정말 좋지?"});


        //WoodyBeaver,비버아저씨   
        talkData.Add(2000, new string[] {"오, 로니가 왔군!", "무슨 일로 왔나? 내 돌다리를 구경하러 온 건가?"});         


        //ParaMeerKat, 모모, 수컷미어캣
        talkData.Add(3000, new string[] {"안녕 토끼친구!"});
        

        //BackgroundNpcs
        talkData.Add(500, new string[] {"로니씨 안녕하세요.", "맛있는 생초 사가세요~"});
        talkData.Add(600, new string[] {"좋은 하루입니다.", "오늘 채소가 정말 싱싱해요."});   


        //sign
        talkData.Add(100, new string[] {"싱싱생초 행복마켓에 오신걸 환영합니다.", "궁금한 것이 있으면 편하게 물어보세요!"});
        talkData.Add(150, new string[] {"당근밭 채소가게에 오신걸 환영합니다.", "오늘만 10% 특별할인!"});
        talkData.Add(200, new string[] {"오늘의 할 일", "행복한 하루 보내기", "마을 광장에 있는 꼬꼬댁 아줌마에게 인사하기"});
        talkData.Add(250, new string[] {"'나의 황금당근 컬렉션'이라고 적혀있다.", "텅 비어 보인다."});
        talkData.Add(300, new string[] {"비버 아저씨의 특제 돌다리", "'좋은다리는 건너기 전에 알아보는 것' -비버 아저씨-"});
        talkData.Add(350, new string[] {"돌다리도 두들겨보고 건너라.... 아니면", "그냥 건너도 됩니다. 선택은 자유!"});
        talkData.Add(400, new string[] {"미어캣 가족의 집", "지하 50개 방, 지상 1개 문", "환영합니다!(단, 뱀은 사절)"});
        talkData.Add(450, new string[] {"이 너머에는 미어캣만 아는 비밀이 있습니다.", "호기심 많은 토끼들은 주의하세요!"});

    }

    public string GetTalk(int id, int talkIndex)
    {
        if(talkIndex == talkData[id].Length)
            return null;
        else
            return talkData[id][talkIndex];
    }
}
