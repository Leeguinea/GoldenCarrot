using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GameManager : MonoBehaviour
{
    public TalkManager talkManager;
    public QuestManager questManager;
    public GameObject talkPanel;
    public Image portraitImg;
    public TextMeshProUGUI talkText;
    public GameObject scanObject;
    public bool isAction;
    public int talkIndex;
    
    //2
    public void Action(GameObject scanObj)
    {
        //Get Current Object
        scanObject = scanObj;
        ObjData objData  = scanObject.GetComponent<ObjData>();
        
         // 계란(5000)인 경우 Talk() 호출 없이 바로 처리
        if (objData.id == 5000)
        {
            QuestManager qm = FindAnyObjectByType<QuestManager>();
            qm.hasEgg = true;
            scanObj.SetActive(false);
            Debug.Log("계란을 획득했습니다!");
        }
        else // NPC인 경우에만 Talk() 호출
        {
            Talk(objData.id, objData.isNpc);
        }

        //Visible Talk For Action
        talkPanel.SetActive(isAction);
        
    }

    void Talk(int id, bool isNpc)
    {
        //Set Talk Data
        int questTalkIndex = questManager.GetQuestTalkIndex(id);
        string talkData = talkManager.GetTalk(id + questTalkIndex, talkIndex);
        
        //End Talk
        if(talkData == null)
        {
            isAction = false;
            talkIndex = 0;
            Debug.Log(questManager.CheckQuest(id));
            return;
        }

        //Continue Talk
        if(isNpc)
        {
            talkText.text = talkData.Split('/')[0];

            portraitImg.sprite = talkManager.GetPortrait(id, int.Parse(talkData.Split('/')[1]));
            portraitImg.color = new Color(1,1,1,1);
        }
        else
        {
            talkText.text = talkData;

            portraitImg.color = new Color(1,1,1,0);
        }

        isAction = true;
        talkIndex++;
    }
}