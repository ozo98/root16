using Packages.Rider.Editor.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QeustManager : MonoBehaviour
{
    Dictionary<int, string[]> QeustData;
    //걍 퀘스트 매니저에서 텍스트 가져와가지구 거기다 넣는거징..

    void Start()
    {
        QeustData = new Dictionary<int, string[]>();
        GenerateData();
    }

    void GenerateData()
    {
        QeustData.Add(0, new string[] { "첫번째 미니게임 - 시계 보기", "토끼의 시계가 고장이 났어요.\n 앨리스의 시계를 보고 토끼에게 시간을 알려 주세요!", "시계에서 짧은 바늘은 '시'를 나타내고 긴 바늘은 '분'을 나타내요.\n 긴 바늘이 12를 가리킬 때 몇 시를 나타내는데 짧은 바늘이 8을 가리킬 때 8시라고 읽어요.\n 긴 바늘이 6일 때 몇 시 30분을 나타내는데 시를 읽을 때는 짧은 바늘이 방금 지나온 숫자를 읽어야 해요.\n\n <1학년 2학기 5단원 - 시계보기와 규칙 찾기>"});
        QeustData.Add(1, new string[] { "두번째 미니게임 - 크기 비교", "토끼를 쫓아가려면 더 넓은 문을 지나가야 해요. \n 앨리스는 어떤 문으로 지나가야 할까요?", "물건을 서로 겹쳐 보았을 때, 남는 부분이 많은 쪽이 더 넓습니다.\n\n <1학년 1학기 4단원 - 비교하기 >" });
        QeustData.Add(2, new string[] { "첫번째 미니게임 - 케이크 나누기", "첫번째 미니게임 설명입니다.", "첫번째 미니게임 힌트입니다." });
        QeustData.Add(3, new string[] { "두번째 미니게임 - 도형 문제", "두번째 미니게임 설명입니다.", "두번째 미니게임 힌트입니다." });
        QeustData.Add(4, new string[] { "세번째 미니게임 - 도형 찾기 문제", "세번째 미니게임 설명입니다.", "세번째 미니게임 힌트입니다." });
        QeustData.Add(5, new string[] { "네번째 미니게임 - 한자릿수 덧셈 문제", "네번째 미니게임 설명입니다.", "네번째 미니게임 힌트입니다." });
        QeustData.Add(6, new string[] { "다섯번째 미니게임 - 시계 보기 문제", "다섯번째 미니게임 설명입니다.", "다섯번째 미니게임 힌트입니다." });
        QeustData.Add(7, new string[] { "첫번째 미니게임 - 규칙 찾아 꾸미기 문제", "첫번째 미니게임 설명입니다.", "첫번째 미니게임 힌트입니다." });
        QeustData.Add(8, new string[] { "두번째 미니게임 - 두자릿수 더하기 한자릿수 문제", "두번째 미니게임 설명입니다.", "두번째 미니게임 힌트입니다." });
        QeustData.Add(9, new string[] { "세번째 미니게임 - 두자릿수 빼기 한자릿수 문제", "세번째 미니게임 설명입니다.", "세번째 미니게임 힌트입니다." });
        QeustData.Add(10, new string[] { "네번째 미니게임 - 짝수 홀수 문제", "네번째 미니게임 설명입니다.", "네번째 미니게임 힌트입니다." });
    }

    public string GetQeust(int qeustNum, int qeustIndex)
    {
        return QeustData[qeustNum][qeustIndex];
    }
}
