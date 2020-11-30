using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //챕터 관리
    public Text chapterText;
    public GameObject chapterPanel;

    //대화 관리
    public TalkManager talkManager; //대화 매니저를 변수로 선언 후, 함수 사용
    public GameObject talkPanel; //토크 판넬을 가져온다.
    public Image portraitImg; //초상화
    public TypeEffect talk; //전달할 내용
    public Text nameText;
    public bool isAction; //판넬 상태 저장용 변수
    public int talkIndex;
    public int id;
    public string voiceName; // 보이스 변수

    //퀘스트 관리
    public QeustManager qeustManger;
    public GameObject qeustPanel;
    public Text qeustText;
    public Text qeustTitle;
    public int qeustCount;
    //퀘스트 힌트관리
    public GameObject hintPanel;
    public Text hintText;

    //퀘스트1 관련
    public InputField qeustOneHour;
    public InputField qeustOneMin;

    //퀘스트2 관련
    public bool qeustTwoCheck;

    //실패/성공 팝업
    public GameObject clearPanel;
    public Text clearText;
    public GameObject failPanel;
    public Text failText;
    public Text failHintText;

    //퀘스트3 관련
    public DragCount plateOneCount;
    public DragCount plateTwoCount;
    public DragCount plateThreeCount;

    //퀘스트4 관련
    public bool qeust4Check;

    //C2-G2 관련 (퀘스트5)
    public DragCount circleCookiesCount;
    public DragCount triangleCookiesCount;
    public DragCount squareCookiesCount;

    //정답 입력형 퀘스트에 사용되는 변수
    public InputField answer;
    public InputField input1;
    public InputField input2;

    // C3-G1 (무늬맞추기) 관련
    public DragCount matchPatternOne;
    public DragCount matchPatternTwo;

    // 마지막문제 관련
    public DragCount countEvenNum;

    void Start()
    {
        
    }

    void Update()
    {

    }

    public void Action()
    {
        isAction = true;
        Talk(id);
        talkPanel.SetActive(isAction);
    }

    void Talk(int talkId)
    {
        string talkData = talkManager.GetTalk(talkId, talkIndex);

        if(talkData == null)
        {
            isAction = false;
            talkIndex = 0;
            id++;
            Qeust(qeustCount);
            return;
        }

        talk.SetMsg(talkData.Split(':')[0]); //문자를 기준으로 string을 잘라 배열을 만들기 때문에 [0]이 대화 내용이다.
        portraitImg.sprite = talkManager.GetPortrait(int.Parse(talkData.Split(':')[1]));
        //portraitImg.color = new Color(1, 1, 1, 1);

        //voiceName에 해당하는 Voice 출력
        voiceName = talkData.Split(':')[2];
        if(voiceName != "None"){
            SoundManager2.instance.PlaySound(voiceName, 2);
        }

        if (int.Parse(talkData.Split(':')[1]) == 1)
        {
            nameText.text = "앨리스";
        }
        else if (int.Parse(talkData.Split(':')[1]) == 0)
        {
            nameText.text = "토끼";
        }
        else if (int.Parse(talkData.Split(':')[1]) == 2)
        {
            nameText.text = "모자장수";
        }
        else if (int.Parse(talkData.Split(':')[1]) == 3)
        {
            nameText.text = "채셔";
        }
        else if (int.Parse(talkData.Split(':')[1]) == 4)
        {
            nameText.text = "하트";
        }
        else if (int.Parse(talkData.Split(':')[1]) == 5)
        {
            nameText.text = "스페이드";
        }
        else if (int.Parse(talkData.Split(':')[1]) == 6)
        {
            nameText.text = "하트 여왕";
        }
        else if(int.Parse(talkData.Split(':')[1]) == 7)
        {
            nameText.text = "";
        }

        isAction = true;
        talkIndex++;
    }

    void Qeust(int qCount)
    {
        qeustPanel.SetActive(true);
        //퀘스트 카운트에 맞는 퀘스트 내용을 뿌려주면 된다.
        qeustTitle.text = qeustManger.GetQeust(qCount, 0);
        qeustText.text = qeustManger.GetQeust(qCount, 1);
        SoundManager2.instance.PlaySound("Q" + qCount, 2);
        qeustCount++;
    }

    public void QeustOneCheck()
    {
        SoundManager2.instance.PlaySound("Button0", 1);
        //버튼을 누르면 쟤네를 비교하고, 반환값으로 bool을 받아서 씬을 넘기거나, 실패 대사를 띄우면서 되돌리거나 해야함.
        //답을 입력하지 않았을 시, 답을 입력하라고 해야하니까 null이 아닌지 검사해봐야한다.
        //그러면 일단..버튼을 누르는 순간의 값을 받아와서 저장하고, 얘네가 널이 아닌지 검사해보고! 비교를 해야겠군용
        if (qeustOneHour.text == "2" && qeustOneMin.text == "30")
        {
            clearText.text = qeustOneHour.text + "시 " + qeustOneMin.text + "분!" + "\n정답이에요!";
            clearPanel.SetActive(true);
            SoundManager2.instance.PlaySound("audio_ch1_Q1_correct answer", 2);
            //정답 팝업 띄우고 확인 버튼 누르면 씬매니저에서 관리하는걸로 ㅇㅇ
            return;
        }
        failText.text = qeustOneHour.text + "시 " + qeustOneMin.text + "분?" + "\n다시 한 번 해볼까요?";
        failHintText.text = qeustManger.GetQeust(qeustCount, 2);
        failPanel.SetActive(true);
        SoundManager2.instance.PlaySound("audio_ch1_Q1_wrong answer", 2);
    }

    public void showHint()
    {
        hintPanel.SetActive(true);
        hintText.text = qeustManger.GetQeust(qeustCount, 2);
        SoundManager2.instance.PlaySound("H"+qeustCount.ToString(), 2);
    }

    public void hideHint()
    {
        SoundManager2.instance.StopSound("H" + qeustCount.ToString(), 2);
        hintPanel.SetActive(false);
    }

    public void QeustTwoCheck()
    {
        SoundManager2.instance.PlaySound("Button0", 1);
        if (qeustTwoCheck == true)
        {
            clearText.text = "좋아!\n 이 문으로 나가면 파티에 갈 수 있겠지?";
            clearPanel.SetActive(true);
            SoundManager2.instance.PlaySound("audio_ch1_Q2_correct answer", 2);
            return;
        }
        failText.text = "여기로는 지나갈 수 없겠어요..\n다시 한 번 해볼까요?";
        failHintText.text = qeustManger.GetQeust(qeustCount, 2);
        failPanel.SetActive(true);
        SoundManager2.instance.PlaySound("audio_ch1_Q2_wrong answer", 2);
    }

    // 케이크 나눠주기 게임
    public void Qeust3Check()
    {
        SoundManager2.instance.PlaySound("Button0", 1);
        if (plateOneCount.count == 4 && plateTwoCount.count == 3 && plateThreeCount.count == 2)
        {
            clearText.text = "모두 맛있는 케이크를 먹을 수 있게 되었어요!";
            clearPanel.SetActive(true);
            SoundManager2.instance.PlaySound("audio_ch2_Q1_correct answer", 2);
            return;
        }
        failText.text = "케이크를 잘못 나누어준 것 같아요, 다시 한번 해볼까요?";
        failHintText.text = qeustManger.GetQeust(qeustCount, 2);
        failPanel.SetActive(true);
        SoundManager2.instance.PlaySound("audio_ch2_Q1_wrong answer", 2);
    }

    // 도형 맞추기 게임(수수께끼)
    public void QeustFourCheck()
    {
        SoundManager2.instance.PlaySound("Button0", 1);
        if (qeust4Check == true)
        {
            clearText.text = "두 모양 다 평평한 부분과 둥근 부분이 있네요!!";
            clearPanel.SetActive(true);
            SoundManager2.instance.PlaySound("audio_ch2_Q2_correct answer", 2);
            return;
        }
        failText.text = "두 모양은 조금 다른 것 같아요, 다시 한번 생각해 봅시다.";
        failHintText.text = qeustManger.GetQeust(qeustCount, 2);
        failPanel.SetActive(true);
        SoundManager2.instance.PlaySound("audio_ch2_Q2_wrong answer", 2);
    }

    // 쿠키 도형별로 나누기
    public void Qeust5Check()
    {
        SoundManager2.instance.PlaySound("Button0", 1);
        if (circleCookiesCount.count == 3 && squareCookiesCount.count == 3 && triangleCookiesCount.count == 3)
        {
            clearText.text = "이제 원하는 쿠키를 편하게 먹을 수 있을 거예요!";
            clearPanel.SetActive(true);
            SoundManager2.instance.PlaySound("audio_ch2_Q3_correct answer", 2);
            return;
        }
        failText.text = "쿠키를 잘못 나누어 준 것 같아요, 다시 한번 해볼까요?";
        failHintText.text = qeustManger.GetQeust(qeustCount, 2);
        failPanel.SetActive(true);
        SoundManager2.instance.PlaySound("audio_ch2_Q3_wrong answer", 2);
    }

    // 찻잔 계산
    public void Qeust6Check()
    {
        SoundManager2.instance.PlaySound("Button0", 1);
        if((input1.text == "5" || input1.text == "3")&&(input2.text == "5" || input2.text == "3"))
        {
            if (answer.text == "8")
            {
                clearText.text = "모두 8잔 마셨어요!";
                clearPanel.SetActive(true);
                SoundManager2.instance.PlaySound("audio_ch2_Q4_correct answer", 2);
                return;
            }
        }
        failText.text = "다시 한번 생각해볼까요?";
        failHintText.text = qeustManger.GetQeust(qeustCount, 2);
        failPanel.SetActive(true);
        SoundManager2.instance.PlaySound("audio_ch2_Q4_wrong answer", 2);
    }

    // 시계보기 게임(버튼형)
    public void Qeust7Wrong()
    {
        SoundManager2.instance.PlaySound("Button0", 1);
        failText.text = "다시한 번 생각해 볼까요?";
        failHintText.text = qeustManger.GetQeust(qeustCount, 2);
        failPanel.SetActive(true);
        SoundManager2.instance.PlaySound("audio_ch2_Q5_wrong answer", 2);
    }

    public void Qeust7Right()
    {
        SoundManager2.instance.PlaySound("Button0", 1);
        clearText.text = "지금은 여섯 시에요!";
        clearPanel.SetActive(true);
        SoundManager2.instance.PlaySound("audio_ch2_Q5_correct answer", 2);
        return;
    }

    // 규칙찾아 꾸미기 게임
    public void Qeust8Check()
    {
        SoundManager2.instance.PlaySound("Button0", 1);
        if (matchPatternOne.count == 1 && matchPatternTwo.count == 1)
        {
            clearText.text = "완벽해요!";
            clearPanel.SetActive(true);
            SoundManager2.instance.PlaySound("audio_ch3_Q1_correct answer", 2);
            return;
        }
        failText.text = "잘못 색칠한 것 같아요.. 다시 한번 해볼까요?";
        failHintText.text = qeustManger.GetQeust(qeustCount, 2);
        failPanel.SetActive(true);
        SoundManager2.instance.PlaySound("audio_ch3_Q1_wrong answer", 2);
    }

    //두자릿수 한자릿수 더하기 빼기
    public void Qeust9Check()
    {
        SoundManager2.instance.PlaySound("Button0", 1);
        if (answer.text == "29")
        {
            clearText.text = "모두 29송이 칠했어요!";
            clearPanel.SetActive(true);
            SoundManager2.instance.PlaySound("audio_ch3_Q2_correct answer", 2);
            return;
        }
        failText.text = "다시 한번 생각해볼까요?";
        failHintText.text = qeustManger.GetQeust(qeustCount, 2);
        failPanel.SetActive(true);
        SoundManager2.instance.PlaySound("audio_ch3_Q2_wrong answer", 2);
    }

    public void Qeust10Check()
    {
        SoundManager2.instance.PlaySound("Button0", 1);
        if (answer.text == "21")
        {
            clearText.text = "21송이 더 칠해야 하네요.";
            clearPanel.SetActive(true);
            SoundManager2.instance.PlaySound("audio_ch3_Q3_correct answer", 2);
            return;
        }
        failText.text = "다시 한번 생각해 볼까요?";
        failHintText.text = qeustManger.GetQeust(qeustCount, 2);
        failPanel.SetActive(true);
        SoundManager2.instance.PlaySound("audio_ch3_Q3_wrong answer", 2);
    }
    public void Qeust11Check()
    {
        SoundManager2.instance.PlaySound("Button0", 1);
        if (countEvenNum.count == 3)
        {
            clearText.text = "오늘 일할 병사들이 모두 모였어요!";
            clearPanel.SetActive(true);
            SoundManager2.instance.PlaySound("audio_ch3_Q4_correct answer", 2);
            return;
        }
        failText.text = "오늘 일할 병사들이 제대로 모이지 않았어요... 다시 한번 해볼까요?";
        failHintText.text = qeustManger.GetQeust(qeustCount, 2);
        failPanel.SetActive(true);
        SoundManager2.instance.PlaySound("audio_ch3_Q4_wrong answer", 2);
    }
}
