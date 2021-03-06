﻿using System.Collections;
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
        QeustData.Add(0, new string[] { "첫번째 미니게임", "토끼의 시계가 고장이 났어요.\n 앨리스의 시계를 보고 토끼에게 시간을 알려 주세요!", "시계에서 짧은 바늘은 '시'를 나타내고 긴 바늘은 '분'을 나타내요.\n 긴 바늘이 12를 가리킬 때 몇 시를 나타내는데 짧은 바늘이 8을 가리킬 때 8시라고 읽어요.\n 긴 바늘이 6일 때 몇 시 30분을 나타내는데 시를 읽을 때는 짧은 바늘이 방금 지나온 숫자를 읽어야 해요.\n\n <1학년 2학기 5단원 - 시계보기와 규칙 찾기>"});
        QeustData.Add(1, new string[] { "두번째 미니게임", "방을 나가기 위해서는 더 넓은 문을 지나가야 해요. \n 앨리스는 어떤 문으로 지나가야 할까요?", "물건을 서로 겹쳐 보았을 때, 남는 부분이 많은 쪽이 더 넓습니다.\n\n <1학년 1학기 4단원 - 비교하기 >" });
        QeustData.Add(2, new string[] { "첫번째 미니게임", "케이크를 접시에 적힌 숫자만큼 나누어 주세요.", "접시에 적힌 숫자와 케이크의 개수가 같아야 해요." });
        QeustData.Add(3, new string[] { "두번째 미니게임", "이 마시멜로랑 모양이 닮은 건 무엇일까요?", "모양은 뾰족한 부분이 있고 잘 쌓을 수 있습니다.\n\n모양은 평평한 부분과 둥근 부분이 다 있습니다.\n\n모양은 잘 굴러가고 평평한 부분과 뾰족한 부분이 없습니다." });
        QeustData.Add(4, new string[] { "세번째 미니게임", "같은 모양의 쿠키끼리 나누어 주세요.", "□모양은 네모 모양, △모양은 세모 모양, ○모양은 동그라미 모양이라고 부를 수 있습니다." });
        QeustData.Add(5, new string[] { "네번째 미니게임", "토끼와 모자장수가 마신 차는 모두 몇 잔일까요?", "더하기는 ‘+’로, 같다는 = 로 나타냅니다. 모자 장수와 토끼가 마신 차를 각각 세어 덧셈식에 적고, 더하여 봅시다." });
        QeustData.Add(6, new string[] { "다섯번째 미니게임", "앨리스의 시계를 보고 모자장수와 토끼의 시계 중 같은 시각을 골라주세요.", "바늘이 있는 시계는 짧은 바늘은 '시'를 나타내고, 긴 바늘은 '분'을 나타내요. 긴 바늘이 12를 가리킬 때 몇 시를 나타내는데 짧은 바늘이 8을 가리킬 때 8시라고 읽어요.\n바늘이 없는 시계는 :앞에 있는 숫자가 ‘시’를 나타내고, :뒤에 있는 숫자는 ‘분’을 나타내요." });
        QeustData.Add(7, new string[] { "첫번째 미니게임", "카드 병사가 칠해 놓은 규칙에 따라 빈 곳에 알맞은 장미를 선택해 보세요.", "하얀색 장미와 빨간색 장미가 반복되고 있습니다." });
        QeustData.Add(8, new string[] { "두번째 미니게임", "카드 병사들이 지금까지 색칠한 장미는 모두 몇 송이인가요?", "1. 낱개끼리 더합니다. \n2. 10개씩 묶음의 수를 앞에 씁니다." });
        QeustData.Add(9, new string[] { "세번째 미니게임", "카드병사가 더 색칠해야 하는 장미는 모두 몇 송이인가요?", "1. 두 자릿수의 일의 자리에서 한 자릿수의 일의 자리를 뺍니다.\n 2. 두 자릿수의 십의 자리 수를 십의 자리에 씁니다." });
        QeustData.Add(10, new string[] { "네번째 미니게임", "카드병사들 중에 짝수 병사들만 골라 주세요!", "짝수는 둘씩 짝을 지을 수 있는 수를 짝수라고 하고, 홀수는 둘씩 짝을 지을 수 없는 수를 홀수라고 합니다. 일의 자리 숫자가 0, 2, 4, 6, 8이면 짝수이고, 일의 자리 숫자가 1, 3, 5, 7, 9이면 홀수입니다. " });
    }

    public string GetQeust(int qeustNum, int qeustIndex)
    {
        return QeustData[qeustNum][qeustIndex];
    }
}
