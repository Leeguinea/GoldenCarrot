//using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> talkData;
    Dictionary<int, Sprite> portraitData;

    public Sprite[] portraitArr;

    void Awake()
    {
        talkData = new Dictionary<int, string[]>();
        portraitData = new Dictionary<int, Sprite>();
        GenerateData();
    }

    void GenerateData()
    {
        //QuizChicken,꼬꼬댁아줌마
        //0:기본, 1:눈 감음, 2: 미션 끝난 후
        talkData.Add(1000, new string[] {"꼬끼오. 안녕 로니./0", "날씨가 정말 좋지?/0"});


        //WoodyBeaver,비버아저씨 
        //3:기본, 4:기본2, 5: 미션 끝난 후  
        talkData.Add(2000, new string[] {"오, 로니가 왔군!/0", "무슨 일로 왔나? 내 돌다리를 구경하러 온 건가?/0"});         


        //ParaMeerKat, 모모, 수컷미어캣
        //6:기본, 7:입꼬리 다운, 8: 미션 끝난 후
        talkData.Add(3000, new string[] {"안녕 토끼친구!/0"});
        

        //ParaMeerKat, 캣캣, 암컷미어캣
        //9:기본, 10:입꼬리 다운운, 11: 미션 끝난 후


        //BackgroundNpcs
        //12
        talkData.Add(5000, new string[] {"로니씨 안녕하세요./0", "맛있는 생초 사가세요~/0"});
        talkData.Add(6000, new string[] {"좋은 하루입니다./0", "오늘 채소가 정말 싱싱해요./0"});   


        //sign
        talkData.Add(100, new string[] {"싱싱생초 행복마켓에 오신걸 환영합니다.", "궁금한 것이 있으면 편하게 물어보세요!"});
        talkData.Add(150, new string[] {"당근밭 채소가게에 오신걸 환영합니다.", "오늘만 10% 특별할인!"});
        talkData.Add(200, new string[] {"오늘의 할 일", "행복한 하루 보내기", "마을 광장에 있는 꼬꼬댁 아줌마에게 인사하기"});
        talkData.Add(250, new string[] {"'나의 황금당근 컬렉션'이라고 적혀있다.", "텅 비어 보인다."});
        talkData.Add(300, new string[] {"비버 아저씨의 특제 돌다리", "'좋은다리는 건너기 전에 알아보는 것' -비버 아저씨-"});
        talkData.Add(350, new string[] {"돌다리도 두들겨보고 건너라.... 아니면", "그냥 건너도 됩니다. 선택은 자유!"});
        talkData.Add(400, new string[] {"미어캣 가족의 집", "지하 50개 방, 지상 1개 문", "환영합니다!(단, 뱀은 사절)"});
        talkData.Add(450, new string[] {"이 너머에는 미어캣만 아는 비밀이 있습니다.", "호기심 많은 토끼들은 주의하세요!"});


        //초상화(Portrait)
        //닭 초상화
        portraitData.Add(1000 + 0, portraitArr[0]); //미션 전1 모습
        portraitData.Add(1000 + 1, portraitArr[1]); //미션 전2 모습
        portraitData.Add(1000 + 2, portraitArr[2]); //미션 완료 후 모습
        //비버 초상화
        portraitData.Add(2000 + 0, portraitArr[3]); //미션 전1 모습
        portraitData.Add(2000 + 1, portraitArr[4]); //미션 전2 모습
        portraitData.Add(2000 + 2, portraitArr[5]); //미션 완료 후 모습
        //수컷 미어캣 초상화
        portraitData.Add(3000 + 0, portraitArr[6]); //미션 전1 모습
        portraitData.Add(3000 + 1, portraitArr[7]); //미션 전2 모습
        portraitData.Add(3000 + 2, portraitArr[8]); //미션 완료 후 모습
        //암컷 미어캣 초상화
        portraitData.Add(4000 + 0, portraitArr[9]); //미션 전1 모습
        portraitData.Add(4000 + 1, portraitArr[10]); //미션 전2 모습
        portraitData.Add(4000 + 2, portraitArr[11]); //미션 완료 후 모습
        //backgroun NPC 초상화
        portraitData.Add(5000 + 0, portraitArr[12]); //기본
        portraitData.Add(6000 + 0, portraitArr[12]); //기본

    }

    public string GetTalk(int id, int talkIndex)
    {
        if(talkIndex == talkData[id].Length)
            return null;
        else
            return talkData[id][talkIndex];
    }


    public Sprite GetPortrait(int id, int portraitIndex)
    {
        return portraitData[id + portraitIndex];
    }
}
