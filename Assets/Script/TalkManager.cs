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
        //Talk Data
        //QuizChicken,닭
        talkData.Add(1000, new string[] {"꼬끼오. 안녕 로니./0", "날씨가 정말 좋지?/0"});


        //WoodyBeaver,비버 
        talkData.Add(2000, new string[] {"오, 로니가 왔군!/0", "무슨 일로 왔나? 내 돌다리를 구경하러 온 건가?/0"});         


        //ParaMeerKat, 수컷미어캣
        talkData.Add(3000, new string[] {"안녕 토끼친구!/0"});
        

        //BackgroundNpcs, 상인인
        talkData.Add(1, new string[] {"로니씨 안녕하세요./0", "맛있는 생초 사가세요~/0"});
        talkData.Add(2, new string[] {"좋은 하루입니다./0", "오늘 채소가 정말 싱싱해요./0"});   


        //sign
        talkData.Add(100, new string[] {"싱싱생초 행복마켓에 오신걸 환영합니다.", "궁금한 것이 있으면 편하게 물어보세요!"});
        talkData.Add(150, new string[] {"당근밭 채소가게에 오신걸 환영합니다.", "오늘만 10% 특별할인!"});
        talkData.Add(200, new string[] {"오늘의 할 일", "행복한 하루 보내기", "마을 광장에 있는 꼬꼬댁 아줌마에게 인사하기"});
        talkData.Add(250, new string[] {"'나의 황금당근 컬렉션'이라고 적혀있다.", "텅 비어 보인다."});
        talkData.Add(300, new string[] {"비버 아저씨의 특제 돌다리", "'좋은다리는 건너기 전에 알아보는 것' -비버 아저씨-"});
        talkData.Add(350, new string[] {"돌다리도 두들겨보고 건너라.... 아니면", "그냥 건너도 됩니다. 선택은 자유!"});
        talkData.Add(400, new string[] {"미어캣 가족의 집", "지하 50개 방, 지상 1개 문", "환영합니다!(단, 뱀은 사절)"});
        talkData.Add(450, new string[] {"이 너머에는 미어캣만 아는 비밀이 있습니다.", "호기심 많은 토끼들은 주의하세요!"});


        //Quest Talk
        //10: 닭 quest
        talkData.Add(10 + 1000, new string[] {"로니! 요즘 황금당근을 모으고 있다는 소문이 들리던데, 정말이니?/0",
                                              "어떻게 알았냐구?/1",
                                              "이 마을에선 비밀이 오래 가지 않지!/0", 
                                              "나도 황금당근에 대한 정보가 있어./1", 
                                              "내 계란 찾아오면 정보를 줄게./0",
                                              "계란들이 어디론가 사라졌거든!/0"});


        talkData.Add(11 + 5000, new string[] {"계란을 찾았다!"});

        talkData.Add(11 + 1000, new string[] {"모든 계란을 찾아왔구나! 정말 고마워./0",
                                              "약속대로 황금당근에 대한 정보를 알려줄게./1",
                                              "폭포 근처에 사는 비버가 얼마 전에 황금당근에 대해 이야기하는 걸 들었어./0", 
                                              "그에게 내 이름을 말하면 분명 도움을 줄 거야!/1"});

        //20: 비버quest
        talkData.Add(20 + 2000, new string[] {"황금당근에 대해 알고 있냐고?/0",
                                              "아, 그 수다쟁이 닭이 알려줬구나./1",
                                              "흥미롭군/0",
                                              "사실 나도 특별한 것들을 모으는 걸 좋아해./1",
                                              "내 컬렉션에 도움을 준다면, 그 당근에 대한 정보를 알려주지/0"});

        talkData.Add(21 + 2000, new string[] {"내가 찾는건 '신선한 푸른 나무'의 껍질이야. 우리 마을 동쪽 숲에 있지./1",
                                              "숲에서 나무 껍질 세 개만 가져와주렴. 물론 나무가 아닌 바닥에서 줍는건 잊지말게나./0",
                                              "우리 모두 자연을 사랑하니깐!/0"});
        


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
        //portraitData.Add(4000 + 0, portraitArr[9]); //미션 전1 모습
        //portraitData.Add(4000 + 1, portraitArr[10]); //미션 전2 모습
        //portraitData.Add(4000 + 2, portraitArr[11]); //미션 완료 후 모습
        //backgroun NPC 초상화
        portraitData.Add(1 + 0, portraitArr[12]); //기본
        portraitData.Add(2 + 0, portraitArr[12]); //기본

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
