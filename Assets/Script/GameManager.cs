using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GameManager : MonoBehaviour
{
    public GameObject talkPanel;
    public TextMeshProUGUI TalkText;
    public GameObject scanObject;
    public bool isAction;
    
    //2
    public void Action(GameObject scanObj)
    {
        if(isAction)    //Exit Action
        {
            isAction = false;
            talkPanel.SetActive(false);
        }
        else        //Enter Action
        {
            isAction = true;
            scanObject = scanObj;
            TalkText.text = "이것은 " + scanObject.name + "이다."; 
        }

        talkPanel.SetActive(isAction);
        
    }
}
