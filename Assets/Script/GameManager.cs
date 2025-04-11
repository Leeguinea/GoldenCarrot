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
        if(isAction)    //Exit Action
        {
            isAction = false;
        }
        else        //Enter Action
        {
            isAction = true;
            scanObject = scanObj;
            ObjData objData  = scanObject.GetComponent<ObjData>();
            Talk(objData.id, objData.isNpc);
        }

        talkPanel.SetActive(isAction);
        
    }

    void Talk(int id, bool isNpc)
    {
        string talkData = talkManager.GetTalk(id, talkIndex);

        if(isNpc)
        {
            TalkText.text = talkData;
        }
        else
        {
            TalkText.text = talkData;
        }
    }
}