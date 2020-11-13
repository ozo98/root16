using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    //TalkManger에서는 어떤 대사가 들어가는지 저장한다.
    Dictionary<int, string[]> talkData;
    Dictionary<int, Sprite> portraitData;

    public Sprite[] portraitArr;

    //초대장 뜨게해야하는데 어케해야할지를 모르겠어서ㅠㅠ일단 어거지로 넣어봤습니다
    //public Animator invitePanel;
    //애니메이터 사용 x. 그냥 판넬이 뜨도록 만들자..
    public GameObject invitePanel;

    //챕터 넘어가는 버튼
    public GameObject gotoNextChapter;

    void Start()
    {
        talkData = new Dictionary<int, string[]>();
        GenerateData();
    }

    void GenerateData()
    {
        // 앨리스 : 0 - 3까지 (미소, 말함, 웃음, 화남/뾰루퉁) 지금설정:앨리스1, 토끼0
        // 토끼 : 4 - 7까지 (기본표정, 말함, 웃음, 화남)
        talkData.Add(0,new string[] { "아얏..:1", "근데 여기가 어디지?:1", "큰일이야!!:0", "떨어지면서 시계가 고장났어!:0", "거기 노란 머리 아가씨!:0", "토끼가 말을 하잖아?!:1", "혹시 지금 몇시인지 아니?:0" });
        talkData.Add(1, new string[] { "지금은 2시 30분이야!:1", "고마워 아가씨!:0", "아가씨도 파티에 놀러 와!:0", "나는 바빠서 먼저 갈게!:0", "잠깐만 어디로 가야 하는 거지?:1", "일단 토끼를 따라가보자!:1"});
        talkData.Add(2, new string[] { "챕터2에 들어갈 대본입니다.:1", "챕터2에 들어갈 대본입니다.:0" });
        talkData.Add(3, new string[] { "챕터2 대화창2에 들어갈 대본입니다.:1", "챕터2 대화창2에 들어갈 대본입니다.:0" });
        talkData.Add(4, new string[] { "챕터2 대화창3에 들어갈 대본입니다.:1", "챕터2 대화창3에 들어갈 대본입니다.:0" });
        talkData.Add(5, new string[] { "챕터2 대화창4에 들어갈 대본입니다.:1", "챕터2 대화창4에 들어갈 대본입니다.:0" });
        talkData.Add(6, new string[] { "챕터2 대화창5에 들어갈 대본입니다.:1", "챕터2 대화창5에 들어갈 대본입니다.:0" });
        talkData.Add(7, new string[] { "챕터2 마지막 대화에 들어갈 대본입니다.:1", "챕터2 마지막 대화에 들어갈 대본입니다.:0" });
        talkData.Add(8, new string[] { "챕터3 대화창1에 들어갈 대본입니다.:1", "챕터3 대화창1에 들어갈 대본입니다.:0" });
        talkData.Add(9, new string[] { "챕터3 대화창2에 들어갈 대본입니다.:1", "챕터3 대화창2에 들어갈 대본입니다.:0" });
        talkData.Add(10, new string[] { "챕터3 대화창3에 들어갈 대본입니다.:1", "챕터3 대화창3에 들어갈 대본입니다.:0" });
        talkData.Add(11, new string[] { "챕터3 대화창4에 들어갈 대본입니다.:1", "챕터3 대화창4에 들어갈 대본입니다.:0"});
        talkData.Add(12, new string[] { "챕터3 마지막 대화에 들어갈 대본입니다.:1", "챕터3 마지막 대화에 들어갈 대본입니다.:0" });
    }

    public string GetTalk(int id, int talkIndex)
    {
        if(id == 1 && talkIndex == 2)
        {
            invitePanel.SetActive(true);
        }

        if(id == 7 && talkIndex == 1)
        {
            gotoNextChapter.SetActive(true);
        }

        if (id == 12 && talkIndex == 1)
        {
            gotoNextChapter.SetActive(true);
        }

        if (talkIndex == talkData[id].Length)
            return null; //더이상 남아있는 문장이 없을 시 대화를 끝낸다.
        else
            return talkData[id][talkIndex]; //한 문장씩 가져온다.
    }

    public Sprite GetPortrait(int portraitIndex)
    {
        return portraitArr[portraitIndex];
    }

    public void FalsePanel()
    {
        invitePanel.SetActive(false);
    }
}

