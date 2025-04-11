using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GameManager : MonoBehaviour
{
    public TalkManager talkManager;
    public GameObject talkPanel;
    public TextMeshProUGUI TalkText;
    public GameObject scanObject;
    public bool isAction;
    public int talkIndex;
    
    //2
    public void Action(GameObject scanObj)
    {

        scanObject = scanObj;
        ObjData objData  = scanObject.GetComponent<ObjData>();
        Talk(objData.id, objData.isNpc);
        talkPanel.SetActive(isAction);
        
    }

    void Talk(int id, bool isNpc)
    {
        string talkData = talkManager.GetTalk(id, talkIndex);

        if(talkData == null)
        {
            isAction = false;
            talkIndex = 0;
            return;
        }

        if(isNpc)
        {
            TalkText.text = talkData;
        }
        else
        {
            TalkText.text = talkData;
        }

        isAction = true;
        talkIndex++;
    }
}