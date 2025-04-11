//using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> talkData;

    
    void Awake()
    {
        talkData = new Dictionary<int, string[]>();
        GenerateDate();
    }

    void GenerateDate()
    {
        talkData.Add(1000, new string[] {"ㅇ", "ㅇ"});        
    }
}
