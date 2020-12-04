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

    public GameObject go;

    void Start()
    {
        talkData = new Dictionary<int, string[]>();
        GenerateData();
    }

    void GenerateData()
    {
        //토끼:0, 앨리스:1, 모자장수:2, 채셔:3, 카드병사 : 4~5, 여왕:6, 공백:7
        talkData.Add(0,new string[] {
            "아얏..:1:audio_ch1_1_1", "이렇게 깊게 떨어졌는데 멀쩡하잖아!:1:audio_ch1_1_2",
            "그런데 여기는 어디일까?:1:audio_ch1_1_3",
            "큰일이야!!:0:audio_ch1_1_4", "떨어지면서 시계가 고장났어!:0:audio_ch1_1_5",
            "토끼가 말을 하잖아?!:1:audio_ch1_1_6",
            "어? 거기 노란 머리 친구!:0:audio_ch1_1_7",
            "저요? 저는 앨리스라고요!:1:audio_ch1_1_8",
            "앗, 미안 앨리스야. 내가 파티 시간에 늦을 거 같은데:0:audio_ch1_1_9",
            "혹시 지금 몇 시인지 아니?:0:audio_ch1_1_10",
            "제 시계를 보고 알려드릴게요!:1:audio_ch1_1_11"
        });

        talkData.Add(1, new string[] {
            "지금은 2시 30분이에요!:1:audio_ch1_2_1",
            "벌써 2시 30분이야? 파티에 늦겠다.:0:audio_ch1_2_2",
            "무슨 파티요?:1:audio_ch1_2_3",
            "오늘 티파티가 있어! 재미있을 거야.:0:audio_ch1_2_4",
            "앨리스도 파티에 놀러 와.:0:audio_ch1_2_5",
            "그래 좋아요!:1:audio_ch1_2_6",
            "여기 초대장을 줄게.:0:audio_ch1_2_7",
            "나는 새로운 버터 시계를 사야해서 먼저 가볼게~ 나중에 봐!:0:audio_ch1_2_8",
            "앗.. 잠깐.. 어디로 가야하는 거지? 토끼가 간 곳으로 가보자!:1:audio_ch1_2_9",
            "어? 티 파티로 갈 수 있는 문이 두 개잖아?:1:audio_ch1_2_10",
            "내가 지나갈 수 있는 문은 어떤 것이지?:1:audio_ch1_2_11"
        });

        talkData.Add(2, new string[] {
            "여기가 티파티를 하는 곳인가요?:1:audio_ch2_1_1",
            "자리가 없어!! 더는 자리가 없다고!!:2:audio_ch2_1_2",
            "자리는 매우 많은 걸요?:1:audio_ch2_1_3",
            "게다가 케이크도 나눠 먹기엔 너무 부족해!!:2:audio_ch2_1_4",
            "더 이상의 사람은 올 수 없어!!:2:audio_ch2_1_5",
            "그만! 이 친구는 내가 초대했어. 이름은 앨리스야. :0:audio_ch2_1_6",
            "케이크도 내가 더 가져 왔으니 충분할 거야!:0:audio_ch2_1_7",
            "앨리스, 케이크를 좀 나누어 줄래?:0:audio_ch2_1_8",
            "좋아요!:1:audio_ch2_1_9"
        });

        talkData.Add(3, new string[] {
            "자 이제 원하는 만큼 케이크를 먹을 수 있을 거예요.:1:audio_ch2_2_1",
            "고마워~ 이제 싸우지 말고 파티를 시작하자:0:audio_ch2_2_2",
            "아까 화내서 미안해 앨리스. :2:audio_ch2_2_3",
            "대신 내가 즐거운 파티를 위해서 엄청나게 재미있는 수수께끼를 내 볼게!:2:audio_ch2_2_4",
            "어떤 수수께끼인가요?:1:audio_ch2_2_5",
            "까마귀랑 책상이랑 뭐가 닮았을까?:2:audio_ch2_2_6",
            "잘 모르겠어요..:1:audio_ch2_2_7",
            "나도 잘 모르겠는걸 :0:audio_ch2_2_8",
            "그래서 답이 뭔가요? :1:audio_ch2_2_9",
            "나도 몰라! :2:audio_ch2_2_10",
            "저는 답이 없는 수수께끼보다, 답이 있는 수수께끼가 좋아요..!:1:audio_ch2_2_11",
            "좋아 이번에는 답이 있는 수수께끼를 내줄게!:2:audio_ch2_2_12"
        });

        talkData.Add(4, new string[] {
            "마시멜로는 머그컵과 닮았어요!:1:audio_ch2_3_1",
            "맞아! 그런데 나는 마시멜로보다 쿠키를 더 좋아하지. :2:audio_ch2_3_2",
            "그중에서도 네모 모양 쿠키를 가장 좋아해. :2:audio_ch2_3_3",
            "나는 세모 모양이 좋던데 :0:audio_ch2_3_4",
            "나는 동그라미 모양이 좋아! :3:audio_ch2_3_5",
            "고양이?! :1:audio_ch2_3_6",
            "안돼!!! :2:audio_ch2_3_7",
            "쿠키가 다 섞여버렸어.. :2:audio_ch2_3_8",
            "너무 엉망이야! :2:audio_ch2_3_9",
            "죄송해요. 너무 놀라서 그만...:1:audio_ch2_3_10",
            "이런, 동그라미 모양 쿠키가 맛없는 쿠키들이랑 섞여서 내 쿠키를 못 찾겠어.:3:audio_ch2_3_11",
            "정말 맛있어 보이는 쿠키였는데...:3:audio_ch2_3_12",
            "그럼, 제일 좋은 버터로 만든 거라고! 특히 세모 모양이 맛있지.:0:audio_ch2_3_13",
            "근데 이미 모든 게 엉망이 되었어.. 나는 네모 모양 쿠키만 먹는데 말이야!:2:audio_ch2_3_14",
            "제가 다시 쿠키를 모양별로 나눠놓을게요. :1:audio_ch2_3_15"
        });

        talkData.Add(5, new string[] {
            "아까보다 쿠키를 먹기 편해졌어! 고마워 앨리스:0:audio_ch2_4_1",
            "근데 쿠키만 먹으니까 목이 막히네. 차를 더 마셔야겠어.:2:audio_ch2_4_2",
            "나는 오늘 벌써 3잔이나 마셨어. :0:audio_ch2_4_3",
            "나는 5잔이나 마셨다고~ :2:audio_ch2_4_4",
            "오늘 우리가 마신 차는 모두 몇 잔일까? :0:audio_ch2_4_5",
            "나는 더하기가 아직 서툴러서 잘 모르겠어.. :2:audio_ch2_4_6",
            "앨리스는 오늘 우리가 마신 차가 모두 몇 잔인지 더해줄 수 있을까? :2:audio_ch2_4_7"
        });

        talkData.Add(6, new string[] {
            "앨리스는 더하기를 엄청나게 잘 하는 구나! 멋있다~ :2:audio_ch2_5_1",
            "그나저나 토끼야 벌써 다섯 시가 됐어! :2:audio_ch2_5_2",
            "무슨 소리야. 지금은 여섯 시야! :0:audio_ch2_5_3",
            "네 시계가 고장 났나 봐 :0:audio_ch2_5_4",
            "아니야 네 시계가 고장 난 것 같아. :2:audio_ch2_5_5",
            "내 시계는 가장 좋은 버터가 들어간 오늘 산 시계인걸? :0:audio_ch2_5_6",
            "버터기름은 시계에 안 맞는다고 했지! :2:audio_ch2_5_7",
            "잠시만요! 싸우지 마세요! :1:audio_ch2_5_8",
            "제가 가지고 있는 시계는 정확해요. :1:audio_ch2_5_9",
            "제 시계를 보면 어떤 시계가 고장 났는지 알 수 있을 거예요!:1:audio_ch2_5_10",
            "그래 고마..:2:audio_ch2_5_11",
            "뭐야! 바늘이 있잖아? 바늘을 뜨개질할 때 쓰는 거지!!:2:audio_ch2_5_12",
            "네 시계는 이상하게 생겼어! 정말 웃기는 시계네!:2:audio_ch2_5_13",
            "이게 뭐가 웃기다는 거죠? 바늘이 없으면 시간을 어떻게 봐요? :1:audio_ch2_5_14",
            "여기 표시되는 숫자를 읽으면 되잖아! :2:audio_ch2_5_15",
            "얼른 우리 둘 중 어느 시계가 정확한지 알려줘!! :0:audio_ch2_5_16"
        });

        talkData.Add(7, new string[] {
            "지금은 여섯 시에요!:1:audio_ch2_6_1",
            "그러니까 모자장수의 시계가 고장난 것 같아요.:1:audio_ch2_6_2",
            "거봐, 이곳은 항상 여섯 시거든!:0:audio_ch2_6_3",
            "잠깐만 여섯 시?!:1:audio_ch2_6_4",
            "무슨 문제라도 있어? :2:audio_ch2_6_5",
            "이제 집에 가봐야 할 거 같아요. 언니가 걱정하고 있을 거예요. :1:audio_ch2_6_6",
            "토끼 씨 굴 위로 가려면 어떻게 해야 하나요?:1:audio_ch2_6_7",
            "그건 여왕님께 부탁해야 해.:0:audio_ch2_6_8",
            "여왕님만 그곳으로 가는 방법을 알고 있거든. :0:audio_ch2_6_9",
            "그럼 여왕님은 어디에 계신가요? :1:audio_ch2_6_10",
            "그건 내가 알고 있어!! 나는 여왕님이랑 엄청나게 친하거든!:3:audio_ch2_6_11",
            "오늘 네 덕분에 내가 좋아하는 쿠키를 실컷 먹었으니, 내가 여왕님한테 데려다 줄게.:3:audio_ch2_6_12",
            "고마워요! :1:audio_ch2_6_13",
            "내가 마술을 써서 갈 거니까 놀라지 마! :3:audio_ch2_6_14",
            ":0"
        });

        talkData.Add(8, new string[] {
            "여기가 여왕님이 사는 성이야!:3:audio_ch3_1_1",
            "근데 여왕님은 어디 계시죠? :1:audio_ch3_1_2",
            "어떡하지 어떡해! 곧 여왕님께서 오실 텐데 어쩌지!:4:audio_ch3_1_3",
            "여왕님께 엄청 혼날 텐데 우린 이제 끝났어...:5:audio_ch3_1_4",
            "저기, 무슨 일인가요? :1:audio_ch3_1_5",
            "여왕님께서 하얀 장미랑 빨간 장미를 규칙에 맞게 심으라고 했는데\n 실수로 하얀 장미만 심어버렸어.:4:audio_ch3_1_6",
            "그래서 급하게 하얀 장미에 빨간 페인트를 칠하고 있는데\n 여왕님께서 오시기 전까지 끝내지 못할 거 같아. :4:audio_ch3_1_7",
            "그럼 제가 좀 도와드릴게요! :1:audio_ch3_1_8"
        });

        talkData.Add(9, new string[] {
            "고마워! 네 덕분에 일을 빨리 끝낼 수 있겠어! :4:audio_ch3_2_1",
            "스페이드야! 너는 몇 송이 칠했어?:4:audio_ch3_2_2",
            "나는 21송이 칠했어. 너는?:5:audio_ch3_2_3",
            "나는 8송이 칠했어! :4:audio_ch3_2_4",
            "그럼 우리가 모두 몇 송이 칠했지? :5:audio_ch3_2_5"
        });

        talkData.Add(10, new string[] {
            "모두 29송이 칠했어요! :1:audio_ch3_3_1",
            "너는 더하기도 잘 하는구나 대단해! :4:audio_ch3_3_2",
            "뭐야? 왜 하얀 장미가 남아있어? 얼른 칠해야지! :5:audio_ch3_3_3",
            "여왕님께서 하얀색 장미와 빨간색 장미를 규칙에 맞게 심으라고 했잖아. :4:audio_ch3_3_4",
            "무슨 소리야? 여왕님께서 빨간 장미로만 심으라고 하셨어!! :5:audio_ch3_3_5",
            "얼른 칠해야 해! 여왕님이 곧 오실 거야! :5:audio_ch3_3_6",
            "그럼 몇 송이나 더 칠해야 하는 거지? :4:audio_ch3_3_7"
        });

        talkData.Add(11, new string[] {
            "21송이 더 칠해야 하네요. :1:audio_ch3_4_1",
            "제가 열심히 도와드릴게요! :1:audio_ch3_4_2",
            "잠시 후.. :7:None",
            "드디어 다 칠했다! 고마워 네 덕분에 여왕님께 안 혼날 거 같아!!:4:audio_ch3_4_3",
            "다행이에요! 그래서 여왕님께서는 언제 오시죠? :1:audio_ch3_4_5",
            "저기 여왕님이시다!! :5:audio_ch3_4_6",
            "여왕님이 오신다!!! :4:audio_ch3_4_7",
            "으음~ 내 장미들은 예쁘게 빨간색으로 피어있구나~ :6:audio_ch3_4_8",
            "근데 이 꼬마 아가씨는 누구지? :6:audio_ch3_4_9",
            "안녕하세요. 저는 앨리스라고 해요. :1:audio_ch3_4_10",
            "여왕님께서 집으로 돌아가는 방법을 알고 계신다고 해서 찾아왔어요. :1:audio_ch3_4_11",
            "집으로 가는 길이라.. 그 방법은 아무에게나 알려줄 수 없단다. :6:audio_ch3_4_12",
            "하지만 나를 조금 도와준다면 돌아갈 수 있게 해줄게. :6:audio_ch3_4_13",
            "오늘은 짝수 카드병사들이 일해야 하는데 일할 병사들을 찾아와 주겠니? :6:audio_ch3_4_14",
            "네! 알겠어요! :1:audio_ch3_4_15"
        });

        talkData.Add(12, new string[] {
            "도와줘서 고맙구나. 앨리스. :6:audio_ch3_5_1",
            "약속대로 너를 집으로 보내줄게. :6:audio_ch3_5_2",
            "고마워요. 여왕님! :1:audio_ch3_5_3",
            ":None"
        });
    }

    public string GetTalk(int id, int talkIndex)
    {
        if(id == 1 && talkIndex == 7)
        {
            invitePanel.SetActive(true);
        }

        if(id == 7 && talkIndex == 14)
        {
            go.SendMessage("Chap3Scene1");
        }

        if (id == 12 && talkIndex == 3)
        {
            go.SendMessage("Ending");
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

